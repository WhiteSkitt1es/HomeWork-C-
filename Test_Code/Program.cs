// double x = 8, y = 2;
// double result = Math.Pow(x,y);
// Console.WriteLine($"{x} ^ {y} = {result}");
// double result1 = Math.Sqrt(result);
// Console.WriteLine($"Квадратный корень {result} равен: {result1}");


// Console.WriteLine("Введите: ");
// string number = Console.ReadLine()!;
// char[] array = number.ToCharArray();
// string revnumber;
// for (int i = array.Length - 1; i > -1; -- i)
// {
//     revnumber = Convert.ToString(array[i]);
//     Console.Write(revnumber);
// }


// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// 
// if (number.Length == 5)
// {
//     Checkingnumber(number);
// }
// else Console.WriteLine($"Введи правильное число");
// 
// void Checkingnumber(string number)
// {
//     if(number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine("Данное число является палеондромом!");
//     }
//     else Console.WriteLine("Данное число не является палеондромом!");
// 
// }


// Console.WriteLine("Введите число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// int number2 = 0;
// while (number1 > 0)
// {
//     number2 += number1 % 10;
// }
// Console.WriteLine(number2);

int[,,] matrix = new int[2, 2, 2];

        void PrintArray(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for(int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.WriteLine($"{matrix[i,j,k]}");
                    }
                }
            }
        }

        void FillArray(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = new Random().Next(1, 10);
                    }
                }
            }
        }
        PrintArray(matrix);
        FillArray(matrix);
        PrintArray(matrix);