using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bell_Vouncher_Calculator
{
    //Class to represent a Bell Voucher in Animal Crossing: New Horizons. 
    public sealed class BellVoucher
    {
        public int MilesPerVoucher { get; }
        public int BellsPerVoucher { get; }

        //Bell Vouchers in Animal Crossing: New Horizons are worth 500 miles and award 3000 bells each. This means that for every 500 miles you redeem, you will receive 3000 bells in return.
        public BellVoucher()
        {
            MilesPerVoucher = 500;
            BellsPerVoucher = 3000;
        }

    }
}
