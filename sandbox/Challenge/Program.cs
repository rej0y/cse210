// using System.Collections.Generic;

// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // List<int> numbers = [0,1,2,3,4,5,6,7,8,9];
// // List<int> evens = new List<int>();


// // foreach (int number in numbers)
// // {
// //     if (number % 2 == 0)
// //     {
// //         evens.Add(number);
// //     }
// // }


// // foreach (int number in evens)
// // {
// //     Console.WriteLine(number);
// // }



// string aString = "helloworld";

// for (int i=aString.Length - 1; i>=0; i--)
// {
//     Console.Write(aString[i]);
// }



// static bool PasswordValidator(string password)
// {
//     if (password.Length >= 8)
//     {
//         foreach (char c in password)
//         {
//             if (c == '!')
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }


// Console.Write("Type: ");
// if (PasswordValidator(Console.ReadLine()))
// {
//     Console.WriteLine("Right!");
// }
// else
// {
//     Console.WriteLine("False");
// }



// static string TitleCase(string aString)
// {
//     for (int i=0; i<aString.Length; i++)
//     {
//         if (i == 0)
//         {
//             char.ToUpper(aString[i]);
//         }
//     }
// }