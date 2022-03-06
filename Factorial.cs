using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        private int number;
        private int factor;

        public int Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }

        public int Factor
        {
            set
            {
                factor = value;
            }
            get
            {
                return factor;
            }
        }

        public void CalculateFactorial()
        {
            Factor = 1;

            for (int i = 1; i <= Number; i++)
            {
                Factor = Factor * i;
            }
        }
    }
}
