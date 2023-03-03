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
            {
                return 0;
            }

            try
            {
                var numbers = number.Split(',', '\n');
                if (numbers.Length == 1)
                {
                    return Convert.ToInt32(numbers[0]);
                }
                else if (numbers.Length == 2)
                {
                    return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
                }
            }
            catch
            {
                throw new ArgumentException();
            }

            throw new ArgumentException();
        }
    }
}
