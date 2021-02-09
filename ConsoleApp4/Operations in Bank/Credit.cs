using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Credit:Instance
    {
        public Client Client { get; set; }
        public double Amount { get; set; }
        public double Percent { get; set; }

        public int Months { get; set; }
        public double Payment { get; set; }
        public double PaymentPerMonth { get; set; }
    }
}
