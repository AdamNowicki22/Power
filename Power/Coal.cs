using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class Coal
    {
        ResourceStorage resources = new ResourceStorage();

        static int mineProduction = (int)ResourceStorage.MineOutput.CoalMine;
        static int plantOutput = (int)ResourceStorage.PowerOutput.CoalPlant;

        static int forHowManyCoalPlantsSupply(int qtyOfCoalMines)
        {
            return (qtyOfCoalMines * mineProduction) / (int)ResourceStorage.Consumption.CoalPlant;
        }

        static int howManyPlantsCanOperate(int qtyOfCoalMines, int qtyOfCoalPlants)
        {
            return forHowManyCoalPlantsSupply(qtyOfCoalMines) > qtyOfCoalPlants ? qtyOfCoalPlants : forHowManyCoalPlantsSupply(qtyOfCoalMines);
        }

        static public int totalPowerGeneratedByCoalPlants(int qtyOfCoalMines, int qtyOfCoalPlants)
        {
            return howManyPlantsCanOperate(qtyOfCoalMines, qtyOfCoalPlants) * plantOutput;
        }

    }
}
