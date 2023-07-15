//Hello World
// Console.WriteLine("Hello, World!");


//Input
// string str = Console.ReadLine();
// Console.WriteLine(str);


//Identifiers and Keywords
// int a = 3;
// int b = 5;
// int c = a + b;
// int d = a - b;
// Console.Write("Sum : ");
// Console.WriteLine(c);
// // Console.WriteLine("The Sum is {0}", c);
// Console.WriteLine("The Difference is {0}", d);


//Variables and Constants
// const double pi = 3.14;  //constant declaration
// double r;
// r = 10;
// double area = pi * r * r;
// double circumference = 2 * pi * r;
// Console.WriteLine("The Area of Circle is {0}", area);
// Console.WriteLine("The Circumference of Circle is {0}", circumference);


//Type Conversions
// int i = 57;
// //implicit type conversions
// long l = i;
// //implicit type conversions
// float f = l;
// Console.WriteLine("Integer Value : " + i);
// Console.WriteLine("Long Value : " + l);
// Console.WriteLine("Float Value : " + f);
// double d = 12.234;
// //explicit type conversions
// int a = (int)d;
// Console.WriteLine("Value of a is " + a);


//Boxing and Unboxing
// int n = 2021;
// //boxing
// object obj = n;
// n = 500;
// Console.WriteLine("Value type value of n is " + n);
// Console.WriteLine("Object /Reference type of  obj is " + obj);
// //unboxing
// int i=(int)obj;
// Console.WriteLine("Value of object obj is " + obj);
// Console.WriteLine("Value of i is " + i);


// Expressions and Operators
// int result;
// int x = 11, y = 5;
// int a = 20, b;
// int result1;
// int r = 5, s = 9, t = 3;
// // Division 
// result = (x / y);
// Console.WriteLine("Division Operator : " + result);
// //Modulo
// result = (x % y);
// Console.WriteLine("Modulo Operator : " + result);
// //Post-increment
// b = a++;
// Console.WriteLine("a is {0} and Post-increment is {1}", a, b);
// //Bitwise AND Operator
// result1 = (r & s);
// Console.WriteLine("Bitwise AND : " + result1);
// t += 10;
// Console.WriteLine("Add Assignment Operator : " + t);


// Controlflow Statements - Decision making Statements
//nested if-else condition 
// int num1 = 3, num2 = 5, num3 = 2;
// if (num1 > num2)
// {
//     if (num1 > num3)
//     {
//         Console.WriteLine("{0} is the Largest", num1);
//     }
//     else
//     {
//         Console.WriteLine("{0} is the Largest", num3);
//     }
// }
// else
// {
//     if (num2 > num3)
//     {
//         Console.WriteLine("{0} is the Largest", num2);
//     }
//     else
//     {
//         Console.WriteLine("{0} is the Largest", num3);
//     }

// }
//switch-case
// char ch;
// Console.WriteLine("Enter the alphabet");
// ch = Convert.ToChar(Console.ReadLine());
// switch (ch)
// {
//     case 'a':
//         Console.WriteLine("It is a vowel");
//         break;
//     case 'e':
//         Console.WriteLine("It is a vowel");
//         break;
//     case 'i':
//         Console.WriteLine("It is a vowel");
//         break;
//     case 'o':
//         Console.WriteLine("It is a vowel");
//         break;
//     case 'u':
//         Console.WriteLine("It is a vowel");
//         break;
//     default:
//         Console.WriteLine("It is not a vowel");
//         break;
// }
//ternary operator
// int num = 4;
// bool checkNum;
// checkNum = (num % 2 == 0);
// Console.WriteLine(checkNum);


//  Looping Statement 
// For Loop
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}












