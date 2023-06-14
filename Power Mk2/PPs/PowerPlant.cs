using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Mk2
{
    public abstract class PowerPlant
    {
        public int EfficiencyDaily;
        public int ResourceConsumption;

        public int EnergyProductionPerGivenDaysDefault30FullResources(int qtyPlant, int days = 30)
            => EfficiencyDaily * qtyPlant * days;

        public int ResourcesRequiredPerGivenDaysDefault30(int qtyPlant, int days = 30) //mamy dosc surowców
            => ResourceConsumption * qtyPlant *  days;
        //mamy resource z mine, jeżeli resource < resource required

        public int EnergyProductionIfNotEnoughResources(int resources)// nie mamy, czy dni są potrzebne?
            =>  (resources/ ResourceConsumption) * EfficiencyDaily;


    }
}
