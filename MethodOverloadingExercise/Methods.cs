using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool myBool)
        {            
            if (myBool == true)
            {
                int sum = num1 + num2;
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else return $"{sum} dollars";
            }
            else
            {
                return "Bummer, you don't get anything.";
            }
        }
    }
}
