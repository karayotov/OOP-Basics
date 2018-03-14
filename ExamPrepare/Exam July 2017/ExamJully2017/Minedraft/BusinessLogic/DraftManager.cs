using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{

    private List<Harvester> harvesters;
    private List<Provider> providers;

    private HarvesterFactory harvestFactory;
    private ProviderFactory providerFactory;

    private double totalEnergyStored;
    private double totalMinedOre;
    private string mode;

    public DraftManager()
    {
        harvesters = new List<Harvester>();
        providers = new List<Provider>();
        harvestFactory = new HarvesterFactory();
        providerFactory = new ProviderFactory();
        mode = "Full";
        totalEnergyStored = 0;
        totalMinedOre = 0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = harvestFactory.CreateHarvester(arguments);
            harvesters.Add(harvester);
            return $"Successfully registered {harvester.Type} Harvester - {harvester.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var provider = providerFactory.CreateProvider(arguments);
            providers.Add(provider);
            return $"Successfully registered {provider.Type} Provider - {provider.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }

    public string Day()
    {

        double dayEnergyProvided = providers.Sum(p => p.EnergyOutput);
        totalEnergyStored += dayEnergyProvided;

        double dayEnergyReqired, dayMinedOre, realDayMinedOre = 0;

        if (mode == "Full")
        {
            dayEnergyReqired = harvesters.Sum(h => h.EnergyRequirement);
            dayMinedOre = harvesters.Sum(h => h.OreOutput);
        }
        else if (mode == "Half")
        {
            dayEnergyReqired = harvesters.Sum(h => h.EnergyRequirement) * 0.6;
            dayMinedOre = harvesters.Sum(h => h.OreOutput) * 0.5;
        }
        else
        {
            dayEnergyReqired = 0;
            dayMinedOre = 0;
        }

        if (totalEnergyStored >= dayEnergyReqired)
        {
            totalMinedOre += dayMinedOre;
            totalEnergyStored -= dayEnergyReqired;
            realDayMinedOre = dayMinedOre;
        }
        return $"A day has passed."
            + Environment.NewLine +
            $"Energy Provided: {dayEnergyProvided}"
            + Environment.NewLine +
            $"Plumbus Ore Mined: {realDayMinedOre}";

    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        Unit unit = (Unit)harvesters.FirstOrDefault(h => h.Id == id) ?? providers.FirstOrDefault(p => p.Id == id);
        if (unit != null)
            return unit.ToString();
        else
            return $"No element found with id - {id}";

    }

    public string ShutDown()
    {
        return $"System Shutdown" +
            Environment.NewLine +
            $"Total Energy Stored: {totalEnergyStored}" +
            Environment.NewLine +
            $"Total Mined Plumbus Ore: {totalMinedOre}";

    }
}