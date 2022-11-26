        // На Семинаре
// Console.WriteLine("масив из N элементов");
// int num = Convert.ToInt32(Console.ReadLine());
// string? [];

// int count = 0;
// int [] mass = new int [count];
// for (int i=0; i < count; i++)
// {
//     mass[i] = new Random().Next(0,2);
//     Console.WriteLine(mass [i]);
// }
//   От Алексея!
//   for (int i=0; i<myArray.Length; i++)
//   {
//     myArray[i] = new Random().Next(0,30);
//     // Console.Write(" "  +myArray[i]);
//   }
//   Console.Write('[' + string.Join(",",myArray) + ']');


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int [] myArray = new int [] {1, 2, 5, 7, 19};
// Console.Write('[' + string.Join(",",myArray) + ']');

// int [] myArray = new int [] {6, 1, 33,};
// Console.Write('[' + string.Join(",",myArray) + ']');
// myArray[0] = 1;
// myArray[1] = 2;
// myArray[2] = 5;
// myArray[3] = 7;
// myArray[4] = 19;
        
        
        // РЕШЕНИЕ!
// int [] myArray = {1, 2, 5, 7, 19};
//    for (int i = 0; i<myArray.Length; i++)
//    {
// Console.Write('[' + string.Join(",",myArray) + ']');
//    }

        // РЕШЕНИЕ!
// int [] myArray = {6, 1, 33,};
//    for (int i = 0; i<myArray.Length; i++)
//    {
// Console.Write('[' + string.Join(",",myArray) + ']');
//    }






/////////////////////////////////////



               //   СЕМИНАР
//       Console.WriteLine("Ввод числа");
//  int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//  int count = 0;
 
//  if (num != 0)
//  {
//     while (num > 0)
//  {
//     count++;
//     num = num / 10;
//  }
//  }
 
//  else {count = 1;}
//  Console.WriteLine("Сумма цифр:  " +count);



                     //   ДЗ
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Ввод числа:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num1)
  {
    
    int cnt = Convert.ToString(num1).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < cnt; i++)
    {
      adv = num1 - num1 % 10;
      result = result + (num1 - adv);
      num1 = num1 / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num1);
Console.WriteLine("Сумма: " + sumNumber);





// ///////////////////////////////////////////////




// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");
int Exponentiation(int num1, int num2)
{
 int result = 1;
  for(int i=1; i <= num2; i++){
    result = result * num1;
  }
     return result;
}

Console.WriteLine("Ввод числа А :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод числа B :");
int num2 = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(num1, num2);
  Console.WriteLine("Ответ: " + exponentiation);