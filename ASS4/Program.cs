using System.ComponentModel;

namespace ASS4
{
    internal class Program
    {
        //Q1
        public static int powerof2(int number)
        {
            number *= number;
            return number;
        }
        public static int PowerOf2(ref int number)
        {
            number *= number;
            return number;
        }

        //Q2
        public static void DublicateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
        }
        public static void DublicateArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
        }

        //Q3
        static void Q3SumAndSub(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        //Q4
        static int Q4SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        //5
        static bool Q5IsPrime(int n)
        {
            bool flag = true;
            if (n == 1 || n == 0)
            { flag = false; }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                { flag = false; break; }
            }
            return flag;
        }

        //6
        static void Q6MinMaxArray(int[] arr, ref int max, ref int min)
        {
            if (arr is not null)
            {
                max = int.MinValue; min = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                    if (arr[i] < min)
                        min = arr[i];

                }
            }
        }

        //7
        static long Q7GitFactorial(int n)
        {
            if (n == 0) return 1;
            long fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        //8
        static void Q8ChangeChar(ref string s, int pos, char newch)
        {
            if (s != null && pos < s.Length)
            {
                string temp = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == pos)
                        temp += newch;
                    else
                        temp += s[i];
                }
                s = temp;
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            //*********************************************************************
            ////passing by value :
            // Copies the value from the main stack frame to the function frame,
            // so any change inside the function will NOT affect the original variable        
            //int num = 5;
            //Console.WriteLine($"Before calling the function num = {num}");
            //int result = powerof2(num);
            //Console.WriteLine($"After calling the function num = {num}");
            //Console.WriteLine("The result = " + result);

            ////passing by reference :
            // The function will use the same address of the parameter in the main stack frame,
            // so any change inside the function will affect the original variable.
            //int num2 = 5;
            //Console.WriteLine($"Before calling the function num2 = {num2}");
            //int result2 = powerof2(ref num2);
            //Console.WriteLine($"After calling the function num2 = {num2}");
            //Console.WriteLine("The result2 = " + result2);

            #endregion

            #region Q2
            //Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            //*********************************************************************
            //passing by value :
            //copy the original reference from the main stack frame to a new reference in the function frame
            //both references point to the same object in the heap, so changing the object’s data will affect the original
            //but if you change the reference itself (make it point to a new object), it will NOT affect the original reference
            //after the function ends, the new reference is removed from memory

            //Console.WriteLine("caling finction by value:");
            //int[] arr = { 2, 4, 6, 8 };
            //Console.WriteLine($"Before calling the function: {arr[0]}");
            //DublicateArray(arr);
            //Console.WriteLine($"After calling the function: {arr[0]}");
            //////////////////////////////////////////////////////
            //passing by reference :
            //the function uses the same reference from the main stack frame
            //so any change in the object’s data or the reference itself will affect the original

            //Console.WriteLine("caling finction by reference:");
            //int[] arr2 = { 2, 4, 6, 8 };
            //Console.WriteLine($"Before calling the function: {arr2[0]}");
            //DublicateArray(ref arr2);
            //Console.WriteLine($"After calling the function: {arr2[0]}");
            #endregion

            #region Q3
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //*********************************************************************
            //int num1 =5, num2=2, sumResult, subResult;
            //Q3SumAndSub(num1, num2, out sumResult, out subResult);
            //Console.WriteLine($"sum = {sumResult}");
            //Console.WriteLine($"sub = {subResult}");
            #endregion

            #region Q4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //*********************************************************************
            //Console.WriteLine("Enter number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine($"The sum of digits of number = {Q4SumOfDigits(number)}");
            #endregion

            #region Q5
            //Create a function named "IsPrime", which receives an integer number and
            //returns true if it is prime, or false if it is not
            //*********************************************************************
            //int number = 13;
            //if (Q5IsPrime(number))
            //    Console.WriteLine("number is Prime");
            //else
            //    Console.WriteLine("number is NOT Prime");
            #endregion

            #region Q6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //using reference parameters
            //*********************************************************************
            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //int min = 0, max = 0;
            //Q6MinMaxArray(array, ref max, ref min);
            //Console.WriteLine($"max element : {max}");
            //Console.WriteLine($"min element : {min}");


            #endregion

            #region Q7
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //*********************************************************************
            //Console.WriteLine("enter number : ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"the factorial is {Q7GitFactorial(num)}");
            #endregion

            #region Q8
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //*********************************************************************
            string str = "hellow";
            Q8ChangeChar(ref str, 0, 'f');
            Console.WriteLine(str);

            #endregion
            #region Q16
            //Write a program to create two multidimensional arrays of same size.
            //Accept value from user and store them in first array.
            //Now copy all the elements of first array on second array and print second array
            //*********************************************************************
            //Console.WriteLine("enter size of 2D array");
            //Console.Write("Enter rows : ");
            //int.TryParse(Console.ReadLine(), out int row);
            //Console.Write("Enter columns : ");
            //int.TryParse(Console.ReadLine(), out int column);
            //int[,] arr1 = new int[row, column];
            //int[,] arr2 = new int[row, column];
            //Console.WriteLine("Enter elements in array");
            //for (int i = 0; i < row; i++)
            //{
            //    Console.WriteLine($"Row{i + 1}");
            //    for (int j = 0; j < column; j++)
            //    {
            //        int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //        arr2[i,j]=arr1[i,j];//===>copying
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine("Array 2 After Copy : ");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(arr2[i, j]+" ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            //////////===========>other questions are already solved
        }
    }
}
