using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number == "")
                return 0;
            throw new ArgumentException();
        }
    }
}
