using CalculatorApp;
using System.ComponentModel;

Console.WriteLine("1-ci ayin gelirini giriniz");
float fValue = float.Parse(Console.ReadLine());

Console.WriteLine("2-ci ayin gelirini giriniz");
float sValue = float.Parse(Console.ReadLine());

Console.WriteLine("3-ci ayin gelirini giriniz");
float tValue = float.Parse(Console.ReadLine());

float tOutValue = 0;
float dsmfOutValue = 0;
float wOutValue = 0;
float iOutValue = 0;
TaxOperation.CalculateTotalDept(fValue, sValue,tValue, out tOutValue,out dsmfOutValue,out wOutValue,out iOutValue);



Console.WriteLine("Borclariniz asagidaki kimidir");

Console.WriteLine($"Vergi borcunuz:{tOutValue}");
Console.WriteLine($"DSMF borcunuz:{dsmfOutValue}");
Console.WriteLine($"Issizlik borcunuz:{wOutValue}");
Console.WriteLine($"Icbari sigort borcunuz:{iOutValue}");

//Console.WriteLine("1-ci ededi giriniz");
//int firstNumber = int.Parse(Console.ReadLine());

//Console.WriteLine("2-ci ededi giriniz");
//int secondNumber = int.Parse(Console.ReadLine());

//Console.WriteLine("33-ci ededi giriniz");
//int thirdNumber = int.Parse(Console.ReadLine());



//int additionResult = MatOperation.add(firstNumber, secondNumber);
//Console.WriteLine("Iki ededinin toplaminin cemi :" + additionResult);
//int additionResult3 = MatOperation.add(firstNumber, secondNumber,thirdNumber);
//Console.WriteLine("Iki ededinin toplaminin cemi :" + additionResult3);


//int subResult = MatOperation.substraction(firstNumber, secondNumber);
//int smultiply = MatOperation.multiply(firstNumber, secondNumber);
//float sdiv = MatOperation.divy(firstNumber, secondNumber);
//WriteToScreen(additionResult, subResult, smultiply, sdiv);
// static void WriteToScreen(int addR, int subR, int multR, float divR)
//{

//    Console.WriteLine("Iki ededinin toplaminin cemi :" + addR);
//    Console.WriteLine("Iki ededinin cixilmasinin cemi :" + subR);
//    Console.WriteLine("Iki ededin vurulmsi:" );
//    Console.WriteLine(multR);
//    Console.WriteLine("Iki ededin bolunmesi:");
//    Console.WriteLine(divR);
//}