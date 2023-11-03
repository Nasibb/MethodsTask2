#region Task1
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.+

//int TwoNum (int n, int m)
//{
//    int sum = default;
//    for (int i=n; i<=m; i++)
//    {
//        if (i%2 == 1)
//        { sum += i; };
//    }
//    return sum;
//}
//Console.WriteLine(TwoNum (1,100));

#endregion

#region Task2
//Verilmish arrayin icindeki tek ededlerin cemini tapin.+

//int SumOddNumbers(params int[] numbers)
//{
//    int sum = default;
//    foreach (int i in numbers)
//    {
//        if (i%2 != 0)
//        {
//            sum += i;
//        }    
//    }
//    return sum;
//}
//Console.WriteLine(SumOddNumbers (1,2,3,4,5,6,7,8,9,10));

#endregion

#region Task3
//Verilmish arrayin icindeki cut ededlerin sayini tapin.+

//int CountEvenNumbers (int[] numbers)
//{
//    int count = 0;
//    foreach (int n in numbers)
//        if (n %2== 0)
//        {
//            count++;
//        }
//    return count;
//}
//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12 };
//Console.WriteLine(CountEvenNumbers(nums));

#endregion

#region Task4
//Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//string FindNumbers(int n)
//{
//    int count = default;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//            if (count > 2)
//            {
//                return "murekkeb";
//            }
//        }
//    }
//    return "sade";
//}
//Console.WriteLine(FindNumbers(1039));


//int num = 1037;
//int count = 0;
//for (int i = 1; i <= num; i++)
//{
//    if (num % i == 0)
//    {
//        count++;
//    }
//}
//if (count > 2)
//{
//    Console.WriteLine("Number is even");
//}
//else
//{
//    Console.WriteLine("Number is odd");
//}

#endregion

#region Task5

//n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//Meselen: Cavablar ola biler: 2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

//int num = int.Parse(Console.ReadLine());


#endregion

#region Task6
//Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18).+RETURN

//int MultiNumbers(params int[] numbers)
//{
//    int multi = 1;
//    foreach (int number in numbers)
//        if (number >= 1 && number <= 20)
//        {
//            multi *= number;
//        }
//    return multi;
//}
////Console.WriteLine(MultiNumbers(21, 23, 123, 35));
//Console.WriteLine(MultiNumbers(21,23,5,15,18,123,35,20,1,10,5));

#endregion

#region Task7
//Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.+RETURN

//int Calculate(params int[] numbers)
//{
//    int sum = 0;
//    int exponentiation = 0;
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        { 
//            sum += number;
//            exponentiation = sum * sum;
//        }
//    }
//    return exponentiation;
//}
//Console.WriteLine(Calculate(1,2,3,4,5,6,7,8,9,10));

#endregion

#region Task8
//int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin
//və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın

//int[] number = { -29, 2, -30, -123, 5 };
//int ExchangeNumbers (params int[] numbers)
//{
//    int save = 0;
//    foreach (int number in numbers)
//    {
//        if (number < 0)
//        {
//            save = 1;
//        }
//    }
//    return numbers[0];
//}
//Console.WriteLine(ExchangeNumbers(-29,2,-30,-123,5));

#endregion


