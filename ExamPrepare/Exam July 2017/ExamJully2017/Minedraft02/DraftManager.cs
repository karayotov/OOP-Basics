using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class DraftManager
{
    public DraftManager()
    {
        Harvesters = new List<Harvester>();
        Providers = new List<Provider>();
        harvesterFactory = new HarvesterFactory();
        providerFactory = new ProviderFactory();

        totalEnergyStored = 0;
        totalMinedOre = 0;
        workingMode = "Full";
    }

    private List<Harvester> Harvesters { get; set; }

    private List<Provider> Providers { get; set; }

    private HarvesterFactory harvesterFactory;

    private ProviderFactory providerFactory;

    private double
        totalEnergyStored,
        totalMinedOre;

    private string workingMode;

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester harvester = harvesterFactory.CreateHarvester(arguments);
            this.Harvesters.Add(harvesterFactory.CreateHarvester(arguments));
            return string.Format(Messages.RegisterHarvesterMessage, harvester.Type, harvester.Id);
            //return $"Successfully registered {harvester.Type} Harvester - {harvester.Id}";
        }
        catch (ArgumentException e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider provider = providerFactory.CreateProvider(arguments);
            this.Providers.Add(provider);
            //return $"Successfully registered {provider.Type} Provider - {provider.Id}";
            return string.Format(Messages.RegisterProviderMessage, provider.Type, provider.Id);
        }
        catch (ArgumentException e)
        {
            return e.Message;
        }
    }

    public string Day()
    {
        double
        dayEnergyOutput,
        dayEnergyRequired,
        dayMinedOre,
        eventualDayMinedOre;



        //calculate day needs and capabilities
        dayEnergyOutput = 0;
        dayMinedOre = 0;
        eventualDayMinedOre = 0;
        dayEnergyRequired = 0;

        dayEnergyOutput = Providers.Sum(p => p.EnergyOutput);
        totalEnergyStored += dayEnergyOutput;


        if (workingMode != "Energy")
        {
            dayEnergyRequired = Harvesters.Sum(h => h.EnergyRequirement);

            if (workingMode == "Full")
            {
                eventualDayMinedOre = Harvesters.Sum(h => h.OreOutput);
            }
            else if (workingMode == "Half")
            {
                dayEnergyRequired = dayEnergyRequired * 0.6; //consume 60 % of their energy requirements
                eventualDayMinedOre = Harvesters.Sum(h => h.OreOutput) * 0.5;

                 //produce 50 % of their ore output
                
            }
        }
        else
        {
            dayEnergyRequired = 0;
            dayMinedOre = 0;

        }

        if (totalEnergyStored >= dayEnergyRequired)
        {
            dayMinedOre = eventualDayMinedOre;
            totalEnergyStored -= dayEnergyRequired;
            totalMinedOre += dayMinedOre;
        }

        return string.Format(Messages.DayHasPassed, 
            Environment.NewLine, dayEnergyOutput, 
            Environment.NewLine, dayMinedOre);//Environment.NewLine, summedEnergyOutput, Environment.NewLine, summedOreOutput
    }

    public string Mode(List<string> arguments)
    {
        workingMode = arguments[0];
        //return $"Successfully changed working mode to {workingMode} Mode";
        return string.Format(Messages.ModeChanged, workingMode);
    }

    public string Check(List<string> arguments)
    {
        string checkThisId = arguments[0];

        Unit unit = (Unit)Harvesters.FirstOrDefault(h => h.Id == checkThisId) ?? Providers.FirstOrDefault(p => p.Id == checkThisId);

        if (unit != null)
        {
            return unit.ToString();
        }
        //return $"No element found with id - {checkThisId}";
        return string.Format(Messages.UnitNotFound, checkThisId);
    }

    public string ShutDown()
    {
        //    return $"System Shutdown" +
        //Environment.NewLine +
        //$"Total Energy Stored: {totalEnergyStored}" +
        //Environment.NewLine +
        //$"Total Mined Plumbus Ore: {totalMinedOre}";
        return string.Format(Messages.Shutdouwn,
            Environment.NewLine, totalEnergyStored,
            Environment.NewLine, totalMinedOre);//Environment.NewLine, totalEnergyStored, Environment.NewLine, totalMinedOre
    }
}
