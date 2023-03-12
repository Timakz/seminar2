// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 ->8

// 12 ->2

// 85 ->8

//int BiggestDigit (int num)
//{
  // int ed = num % 10;
   //int dec = num / 10;

    //if (dec>ed) return dec;
    //else return ed;
//}

//int randomnum = new Random().Next(10, 100);

//int result = BiggestDigit(randomnum);
//Console.WriteLine($"Biggest digit of {randomnum} -> {result}");

//Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 ->46

// 782 ->72

// 918 ->98

//int DeleteDigit(int num)
//{
  //  int sot = num / 100;
    //int ed = num % 10;
    //return sot * 10 + ed;
//}

//int randomnum = new Random().Next(100, 1000);

//Console.WriteLine(randomnum);
//Console.WriteLine(DeleteDigit(randomnum));