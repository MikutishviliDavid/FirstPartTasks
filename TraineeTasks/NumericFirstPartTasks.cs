using System;
using System.Linq;

namespace TraineeTasks
{
    public class NumericFirstPartTasks
    {
        public string ChangeEvenBitsToZero(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must not be less than zero");
            }

            var binary = Convert.ToString(number, 2);
            string result = "";

            for (int i = 0; i < binary.Length; i++)
            {
                result = (i % 2) != 0 ? result += 0 : result += binary[i];
            }

            return result;
        }

        public int FindCountBitsEqualOne(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must not be less than zero");
            }

            var binary = Convert.ToString(number, 2);

            return binary.Count(c => c == '1');
        }
    }
}
