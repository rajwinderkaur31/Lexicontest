using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Lexicontest
{
    class Program
    {
        public static void Main()
        {
            var program = new Program();

            // int list = int.Parse(Console.ReadLine());
            // int arg = list;
            string choice;
            DisplayMenu();
            choice = Console.ReadLine();
            while (choice != "16")
            {
                switch (choice)
                {
                    case "1":
                        HelloWorld();
                        break;
                    case "2":
                        Input();
                        break;
                    case "3":
                        ChangeTextColor();
                        break;
                    case "4":
                        DateAndTime();
                        break;
                    case "5":
                        TwoInputValue();
                        break;
                    case "6":
                        GetRandomNumber();
                        break;
                    case "7":
                        WriteInFile();
                        break;
                    case "8":
                        ReadInFile();
                        break;
                    case "9":
                        DecimalNumber();
                        break;
                    case "10":
                        Multiplikationstabell();
                        break;
                    case "11":
                        RandomNumber();
                        break;
                    case "12":
                        Palindrome();
                        break;
                    case "13":
                        TwoInputs();
                        break;

                    case "14":
                        OddAndEven();
                        break;

                    case "15":
                        NumberAdded();
                        break;

                    case "16":
                        Class();
                        break;


                    default:
                        Console.WriteLine("case 14");
                        Console.Clear();
                        DisplayMenu();
                        break;
                }
                // Console.Clear();
                //DisplayMenu();
                choice = Console.ReadLine();
            }

        }
        static void DisplayMenu()
        {
            Console.WriteLine("Välja från lista");
            Console.WriteLine("1:Hello word");
            Console.WriteLine("2:Input from user");
            Console.WriteLine("3:Change the text color");
            Console.WriteLine("4:Date and Time");
            Console.WriteLine("5:Two Input Value");
            Console.WriteLine("6:Get Random Number");
            Console.WriteLine("7:Write In File");
            Console.WriteLine("8:Read In File");
            Console.WriteLine("9:Decimal Number");
            Console.WriteLine("10:Multiplikationstabell");
            Console.WriteLine("11:RandomNumber");
            Console.WriteLine("12:Palindrome");
            Console.WriteLine("13:TwoInputs");
            Console.WriteLine("14:OddAndEven");
            Console.WriteLine("15:NumberAdded");
            Console.WriteLine("16:Class");
            Console.WriteLine("0:Exit");

            // Console.WriteLine("Enter Choice: 16");
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static void Input()
        {
            Console.WriteLine("about yourself.");
            Console.Write("Type your first name: ");

            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.Write("What is your age? ");
            int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

        }
        static void ChangeTextColor()
        {
            Console.WriteLine("Default Foreground Color: {0}",
                                     Console.ForegroundColor);

            // Set the Foreground color to blue
            Console.ForegroundColor
                = ConsoleColor.Blue;

            // Display current Foreground color
            Console.WriteLine("Changed Foreground Color: {0}",
                                    Console.ForegroundColor);
            Console.ResetColor();
            Console.ReadLine();
        }
        static void DateAndTime()
        {
            
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm tt"));
        }
        static void TwoInputValue()
        {

            Console.WriteLine("First Number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int number2 = int.Parse(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Greatest Number: " + max);

        }
        static void GetRandomNumber()
        {
            int total = 1,
             low = 0,
             high = 0;
            int ranNum1,
                guess;

            string guessStr;

            Random ranNumGen = new Random();
            ranNum1 = ranNumGen.Next(1, 100);

            Console.Write("Enter your guess >> ");
            guessStr = Console.ReadLine();
            guess = Convert.ToInt16(guessStr);

            while (guess != ranNum1)
            {
                while (guess < ranNum1)
                {
                    Console.WriteLine("Your guess is to low, try again.");
                    Console.Write("\nEnter your guess >> ");
                    guessStr = Console.ReadLine();
                    guess = Convert.ToInt16(guessStr);
                    ++total;
                    ++low;
                }
                while (guess > ranNum1)
                {
                    Console.WriteLine("Your guess is to high, try again.");
                    Console.Write("\nEnter your guess >> ");
                    guessStr = Console.ReadLine();
                    guess = Convert.ToInt16(guessStr);
                    ++total;
                    ++high;
                }
            }
            
            Console.WriteLine("It took you {0} guesses to correctly guess {1}", total, ranNum1);
        }

        static void WriteInFile()
        {
            Console.WriteLine("Enter a Text");
            string text = Console.ReadLine();
            string path = @"C:\Users\rajwi\Desktop\textFile.text";
            File.WriteAllText(path, text);
            Console.WriteLine("Text has been saved on your desktop.");
        }
        static void ReadInFile()
        {
            string path = @"C:\Users\rajwi\Desktop\textFile.text";
            Console.WriteLine("Reading File using File.ReadAllText()");
            string str = File.ReadAllText(path);
            Console.WriteLine(str);
        }

        static void DecimalNumber()
        {
            double res;
            res = Math.Pow(2, 1);
            Console.WriteLine("Math.Pow(2,1) = " + res);
            res = Math.Pow(10, 1);
            Console.WriteLine("Math.Pow(10,1) = " + res);
        }
        static void Multiplikationstabell()
        {
            int i, n;
            Console.WriteLine("enter a number:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
            Console.ReadLine();
        }
        static void RandomNumber()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }

            Console.WriteLine("After Ascending Numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void Palindrome()
        {
            Console.WriteLine("Start = s");
            string y = Console.ReadLine().ToLower();
            while (true)
            {
                if (y == "s")
                {
                    Console.WriteLine("Enter text");
                    string text = Console.ReadLine().ToUpper().Trim().Replace(" ", string.Empty).Replace("i", "I");
                    string control = "";
                    control.ToUpper().Trim().Replace(" ", string.Empty).Replace("i", "I");
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        control += text[i];
                    }
                    Console.WriteLine("Control = " + control);
                    Console.WriteLine("Text = " + text);
                    if (control == text)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                Console.ReadLine();
            }

        }

        static void TwoInputs()
        {
            int num1, num2, result;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            Console.ReadLine();
        }
        static void OddAndEven()

        {
            Console.WriteLine("Separate multiple numbers by comma:");
            string userNumbersAsString = Console.ReadLine();

            List<int> userNumbers = userNumbersAsString.Split(',').Select(int.Parse).ToList();

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < userNumbers.Count; i++)
            {
                if ((userNumbers.ElementAt(i) % 2) == 0)
                    evenNumbers.Add(userNumbers.ElementAt(i));
                else
                    oddNumbers.Add(userNumbers.ElementAt(i));
            }

            Console.WriteLine("\nEven numbers:");

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                Console.WriteLine(evenNumbers.ElementAt(i));
            }

            Console.WriteLine("\nOdd numbers:");

            for (int i = 0; i < oddNumbers.Count; i++)
            {
                Console.WriteLine(oddNumbers.ElementAt(i));
            }
        }
        static void NumberAdded()
        {
            Console.WriteLine("Separate multiple numbers by comma:");
            string userNumbersAsString = Console.ReadLine();

            List<int> userNumbers = userNumbersAsString.Split(',').Select(int.Parse).ToList();

            int sum = 0;
            for (int i = 0; i < userNumbers.Count; i++)
            {
                sum += userNumbers.ElementAt(i);
            }

            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine();
        }

        static void Class()
        {
            Console.WriteLine("Enter your name 1");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter your name 2");
            string name2 = Console.ReadLine();
            Console.Write("The Names Entered are {0} and {1}", name1, name2);

            Console.ReadLine();
        }








        
    }
}



               

    
 


      