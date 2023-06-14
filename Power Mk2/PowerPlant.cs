using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Mk2
{
    public abstract class PowerPlant
    {
        public int efficiencyDaily;
        public int resourceConsumption;

        public int energyProductionPerGivenDaysDefault30FullResources(int qtyPlant, int days = 30)
            => efficiencyDaily * qtyPlant * days;

        public int resourcesRequiredPerGivenDaysDefault30(int qtyPlant, int days = 30) //mamy dosc surowców
            => resourceConsumption * qtyPlant *  days;
        //mamy resource z mine, jeżeli resource < resource required

        public int energyProductionIfNotEnoughResouces(int resources)// nie mamy, czy dni są potrzebne?
            =>  (resources/ resourceConsumption) * efficiencyDaily;


    }
}
