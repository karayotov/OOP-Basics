using System;
using System.Collections.Generic;
using System.Text;

namespace Minedraft
{
    class DraftManager
    {

        private List<Harvester> harvesters;

        public List<Harvester> Harvesters
        {
            get { return harvesters; }
            set { harvesters = value; }
        }

        private List<Provider> providers;

        public List<Provider> Providers
        {
            get { return providers; }
            set { providers = value; }
        }

        private double producedEnergy;

        public double ProducedEnergy
        {
            get { return producedEnergy; }
            set { producedEnergy = value; }
        }

        private double producedOre;

        public double ProducedOre
        {
            get { return producedOre; }
            set { producedOre = value; }
        }

        private string mode;

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private HarvesterFactory harvestFactory;

        public HarvesterFactory HarvestFactory
        {
            get { return harvestFactory; }
            set { harvestFactory = value; }
        }

        private ProviderFactory providerFactory;

        public ProviderFactory ProviderFactory
        {
            get { return providerFactory; }
            set { providerFactory = value; }
        }








        //string RegisterHarvester(List<string> arguments)
        //{
        //    bool IsHammer = arguments.Count == 4;
        //    bool IsSonic = arguments.Count == 5;

        //    if (IsSonic)
        //    {
        //        RegisterSonic(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4]));

        //    }
        //    if (IsHammer)
        //    {
        //        RegisterHammer(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]));
        //    }

        //}

        //private void RegisterHammer(string id, double oreOutput, double energyRequirement)
        //{
        //    throw new NotImplementedException();
        //}

        //private void RegisterSonic(string id, double oreOutput, double energyRequirement, int sonicFactor)
        //{

        //}

        //string RegisterProvider(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string Day()
        //{
        //    //TODO: Add some logic here …
        //}
        //string Mode(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string Check(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string ShutDown()
        //{
        //    //TODO: Add some logic here …
        //}

    }
}
