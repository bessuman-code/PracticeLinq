using System;
using System.Security.Cryptography.X509Certificates;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your animal?");
            var animal = Console.ReadLine();
            var theStrory = adlibStory(name, color, animal);

            Console.WriteLine("Let's add two numbers");
            Console.WriteLine("number 1");
            var add1 = int.Parse(Console.ReadLine());
            Console.WriteLine("number 2");
            var add2 = int.Parse(Console.ReadLine());
            var add2numbers = Add(add1, add2);
            //Console.WriteLine(add2numbers);

            Console.WriteLine("Let's multiply two numbers");
            Console.WriteLine("number 1");
            var multiply1 = int.Parse(Console.ReadLine());
            Console.WriteLine("number 2");
            var multiply2 = int.Parse(Console.ReadLine());
            var multiply2numbers = Add(multiply1, multiply2);

            Console.WriteLine("Choose number of number you want to add: 2, 3 or 5");
            var addMult = int.Parse(Console.ReadLine());

            if (addMult == 2)
            {
               
                    Console.WriteLine("number 1");
                    var a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("number 2");
                    var a2 = int.Parse(Console.ReadLine());
                    var addMult2 = Add(a1, a2);
             
                
                Console.WriteLine($"Viola: story {theStrory}. Sum: {add2numbers}. Multiplied: {multiply2numbers}. Another Sum {addMult2}");
            }
            if (addMult == 3)
            {
                Console.WriteLine("number 1");
                var a1 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 2");
                var a2 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 3");
                var a3 = int.Parse(Console.ReadLine());
                var addMult3 = MoreSum3(a1, a2, a3);
                Console.WriteLine($"Viola: story {theStrory}. Sum: {add2numbers}. Multiplied: {multiply2numbers}. Another Sum {addMult3}");
            }
            if (addMult == 5)
            {
                Console.WriteLine("number 1");
                var a1 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 2");
                var a2 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 3");
                var a3 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 4");
                var a4 = int.Parse(Console.ReadLine());
                Console.WriteLine("number 5");
                var a5 = int.Parse(Console.ReadLine());
                var addMult5 = MoreSum5(a1, a2, a3, a4, a5);
                Console.WriteLine($"Viola: story {theStrory}. Sum: {add2numbers}. Multiplied: {multiply2numbers}. Another Sum {addMult5}");
            }

            
            //Console.WriteLine($"Viola: story {theStrory}. Sum: {add2numbers}. Multiplied: {multiply2numbers}.");
                
            

        }
        public static String adlibStory (String name, String color, String animal)
        {
            
            return $"{name} {color} {animal}";
        }

        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {

            return num1*num2;
        }
        public static int MoreSum3(int num1, int num2, int num3)
        {
            
            return num1 + num2+num3;
        }
        public static int MoreSum5(int num1, int num2, int num3, int num4, int num5)
        {

            return num1 + num2 + num3+num4+num5;
        }
        
        }

    }

