using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter a Number please: ");
            //int.TryParse(Console.ReadLine(),out int Number);
            //if (Number % 3 == 0 && Number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region Q2)Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter a Number please: ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //if (Number < 0)
            //    Console.WriteLine("Negative");
            //else 
            //    Console.WriteLine("Positive");



            #endregion


            #region Q3)Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int []arr=new int[3];

            //for (int i = 0; i < 3; i++) {
            //    Console.Write($"Enter the {i+1} Number: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //int min= arr[0];
            //int max = arr[0];
            //for (int i = 0; i < 3; i++) { 
            //    if (arr[i] <min)
            //        min = arr[i];   
            //    if (arr[i] > max )
            //        max= arr[i];    
            //}
            //Console.WriteLine($"Max Number is {max},Min Number is {min}");
            #endregion

            #region Q4)Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter a Number please: ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //if(Number %2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");
            #endregion

            #region Q5)Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            //Console.Write("Enter a Character please: ");
            //char.TryParse(Console.ReadLine(), out char charactar);

            //switch (charactar) {
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'o':
            //    case 'O':
            //    case 'i':
            //    case 'I':
            //    case 'u':
            //    case 'U':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}

            #endregion

            #region Q6)Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a Number please: ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //for (int i = 1; i <= Number; i++) {
            //    Console.Write(i);
            //    if(i!=Number)
            //        Console.Write(",");
            //}
            #endregion


            #region Q7)Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter a Number Please :");
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i <= 12; i++){
            //    Console.WriteLine($"{i} * {Number} ={i * Number}");
            //}
            #endregion

            #region Q8)Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a Number Please :");
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i <= Number; i++) {
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}

            #endregion


            #region Q9)Write a program that takes two integers then prints the power.
            //Console.Write("Enter a Number Please :");
            //int.TryParse(Console.ReadLine(), out int Number);
            //Console.Write("Enter the power Please :");
            //int.TryParse(Console.ReadLine(), out int Power);
            // int result=1;
            //for (int i = 0; i < Power; i++) {

            //    result = result * Number;

            //}
            //Console.WriteLine(result);
            #endregion

            #region Q10)Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] arr = new int[5];
            //int total=0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter the {i + 1} Mark: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < arr.Length; i++) {
            //    total += arr[i];
            //}

            //Console.WriteLine($"Total marks is {total}, Avg marks is {total / arr.Length},Percentage is {(float) total / (arr.Length * 100) * 100}");
      
            #endregion
        }

    }
    }

