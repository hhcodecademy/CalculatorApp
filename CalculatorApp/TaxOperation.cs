using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class TaxOperation
    {
        public static float CalculateTax(float firstMontIncome, float secondMontIncome, float? thirdMontIncome = 0)
        {
            float result = firstMontIncome * secondMontIncome + (float)thirdMontIncome; ;

            return result;
        }


        public static void CalculateTotalDept(float firstMontIncome, float secondMontIncome, float thirdMontIncome, out float taxAmount, out float dsmfAmunt, out float wAmount, out float iAmount)
        {

            taxAmount = (firstMontIncome + secondMontIncome + thirdMontIncome) * 0.17f;
            dsmfAmunt = (firstMontIncome+ secondMontIncome + thirdMontIncome) * 0.03f;
            wAmount = (firstMontIncome + secondMontIncome + thirdMontIncome) * 0.005f;
            iAmount = (firstMontIncome+ secondMontIncome + thirdMontIncome) * 0.02f;
        }
    }
}
