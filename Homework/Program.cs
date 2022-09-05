// Задача № 1

// int Degree(int x, int n)
// {
//     if (n ==0)
//     {
//         return 1;
//     }

//     int result  = 1;

//     for (int i = 0; i < n; i++)
//     {
//         result *= x;
//     }

//     return result;
// }

// System.Console.WriteLine(Degree(2, 3));

// Задача № 2

// int Sum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }

//     return sum;
// }

// System.Console.WriteLine(Sum(912));

// Задача № 3
int [] Array(int size = 8)
{
    var arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(15);
    }
    return arr;
}
foreach (var item in Array())
{
System.Console.Write(item + ", ");
}

