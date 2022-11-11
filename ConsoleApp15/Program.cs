//int[] intArray = { 54, 67, 89, 23, 55, 88, 93 };
//string userNumber = Console.ReadLine();
//int userSelectNumber = 0;
//bool checkUserNumber = int.TryParse(userNumber, out userSelectNumber);
//if (checkUserNumber == false)
//{
//    Console.WriteLine("Eded daxil edin");
//    return;
//}
//for (int i = 0; i < intArray.Length; i++)
//{
//    if (intArray[i] == userSelectNumber)
//    {
//        Console.WriteLine(intArray[i] + " Ededi Massivde Var");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Bele bir eded massivde yoxdur");
//        break;
//    }
//}

//string userNumber1 = Console.ReadLine();
//string userNumber2 = Console.ReadLine();
//int num1 = 0;
//int num2 = 0;
//int num = 0;
//bool checknumber1 = int.TryParse(userNumber1, out num1);
//bool checknumber2 = int.TryParse(userNumber2, out num2);
//if (checknumber1 == false || checknumber2 == false)
//{
//    Console.WriteLine("Eded Daxil edin");
//    return;
//}
//else
//{
//    num = 180 - (num1 + num2);
//    Console.WriteLine(num);
//}
//int[] numberArray = { 678, 45, 67, 89, 23, 545, 188, 293 };
//int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };

//task1
//int sumNumber()
//{
//    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };
//    int sum = 0;
//    for (int i = 0; i < numberArray.Length; i++)
//    {
//        // sum += numberArray[i];
//        sum = sum + numberArray[i];
//    }
//    Console.WriteLine(sum);
//    return sum;
//}

//Task2
//getSum();
//int getSum()
//{
//    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };
//    int sum = 0;
//    int orta = 0;
//    for (int i = 0; i < numberArray.Length; i++)
//    {
//        sum = sum + numberArray[i];
//        orta = sum / numberArray.Length;
//    }
//    Console.WriteLine(orta);
//    return orta;
//}

//Task3
//Yol1
//Console.WriteLine(numberArray.Length);
//Yol2
//int counter = 0;
//int[] numberArray = { 11, 12, 31, 41, 15, 61, 71 };
//for (int i = 0; i < numberArray.Length; i++)
//{
//counter++;
//}
//Console.WriteLine();

//Task4
//int[] numberArray = { 678, 45, 67, 89, 23, 545, 188, 293 };
//for (int i = 0; i < numberArray.Length; i++)
//{
//    if(numberArray[i] >100 && numberArray[i] < 200)
//    {
//        Console.WriteLine(numberArray[i]);
//    }
//}
//Task5
//int[] numberArray = { 678, 45, 67, 89, 23, 545, 188, 293 };
//for(int i = 0; i < numberArray.Length; i++)
//{
//    if(numberArray[i]%2==0)
//    {
//        Console.WriteLine(numberArray[i]);
//    }
//}
//task6
//int[] numberArray = {293 , 45, 67, 89, 23,  188, 545, 678 };
//int maxvalue = numberArray[2];
//for(int i = 0; i < numberArray.Length; i++)
//{
//    if(numberArray[i] > maxvalue)
//    {
//        maxvalue = numberArray[i];
//    }
//}
//Console.WriteLine(maxvalue);

//Task8
//int[] numbers = { 67, 45,  89, 23, 545, 188, 293 };
//int maxValue = numbers[0];
//int minValue = numbers[0];
//int result = 0;
//for(int i = 0; i < numbers.Length; i++)
//{
//    if (maxValue < numbers[i])
//    {
//        maxValue = numbers[i];
//    }
//    if (minValue > numbers[i])
//    {
//        minValue = numbers[i];
//    }
//    result = maxValue - minValue;
//}
//Console.WriteLine(result);


//string name = Console.ReadLine();
//int z = sum(9,3,"+");
//Console.WriteLine(z);


//int sum(int num1,int num2,string sym)
//{
//    int cem = 0;
//    if(sym == "+")
//    {
//        cem = num1 + num2;
//    }
//    return cem;
//}