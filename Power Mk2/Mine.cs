using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Mk2
{
    public abstract class Mine
    {
        public int efficiencyDaily; 

        public int GetResourcePerGivenDaysDefault30(int mineQty, int days = 30)
        {
            return mineQty * efficiencyDaily * days;
        }

    }
}
