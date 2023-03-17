using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class MatOperation
    {
        public static int add(int number1, int number2)
        {

            int sum = number1 + number2;
            return sum;

        }
        public static float add(int number1, float number2)
        {

            float sum = number1 + number2;
            return sum;

        }
        public static float add(float number1, float number2)
        {

            float sum = number1 + number2;
            return sum;

        }

        public static int add(int number1, int number2, int number3)
        {

            int sum = number1 + number2 + number3;
            return sum;

        }
        public static float add(int number1, int number2, float number3)
        {

            float sum = number1 + number2 + number3;
            return sum;

        }
        public static int add(int number1, int number2, int number3, int number4)
        {

            int sum = number1 + number2 + number3+number4;
            return sum;

        }

        public static int substraction(int number1, int number2)
        {
            int sum = number1 - number2;

            return sum;

        }
        public static int multiply(int number1, int number2)
        {
            int sum = number1 * number2;
            return sum;
        }
        public static float divy(int number1, int number2)
        {
            float sum = number1 / number2;
            return sum;
        }

      
    }
}
