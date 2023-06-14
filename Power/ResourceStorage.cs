using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class ResourceStorage
    {
        public Consumption consumption = new Consumption();

        public enum Consumption
        {
            CoalPlant = 100,
            NuclearPlant = 1,
            FusionPlant = 1,
        }
        public enum PowerOutput
    {
        CoalPlant = 7,
        SolarPlant = 2,
        NuclearPlant = 10000,
        FusionPlant = 200000,

    }
    public enum MineOutput
    {
        CoalMine = 40,
        NuclearUraniumMine = 100,
        FusionMoonMine = 10,

    }
    }
}
