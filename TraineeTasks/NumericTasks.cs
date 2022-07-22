using System;
using System.Linq;

namespace TraineeTasks
{
    public class NumericTasks
    {
        public int ChangeEvenBitsToZero(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must not be less than zero");
            }

            return (int)(number & 0xAAAAAAAA);
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
