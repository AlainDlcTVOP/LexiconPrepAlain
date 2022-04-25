using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LexiconAlain
{
    class Program
    {
        // Flow meny -> switcase 1 - 16 call the functions 

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void UserInfo()
        {
            Console.WriteLine("Enter your name :");
            string fnamn = Console.ReadLine();
            Console.WriteLine("Enter your lastname:");
            string lnamn = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            var ageAsString = Console.ReadLine();
            // validation if user press not a number 
            bool parseSuccess = int.TryParse(ageAsString, out int age);
            if (parseSuccess)
                Console.WriteLine($"Userinformation, {fnamn} {lnamn} {age} years old\n");
            else
                Console.WriteLine("This is not a number!");
        }


        static void ColorChanges()
        {
            if (Console.ForegroundColor == ConsoleColor.Magenta)
            {
                Console.ResetColor();
                Console.WriteLine("Default color");

            }
            else if (Console.ForegroundColor != ConsoleColor.White)
            {

                Console.ForegroundColor
                    = ConsoleColor.Magenta;
                Console.WriteLine("Now the terminal color is {0}",
                                     Console.ForegroundColor);

            }
        }
        static void GetDate()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Today's date is  " + now);
        }

        static void LargestValueOfToInputs()
        {
            Console.WriteLine("Enter a number\n");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound number\n");
            var secound = Convert.ToInt32(Console.ReadLine());
            var result = first > secound ? $"{first} is greater than {secound}" : $"{first} is less than {secound}";
            Console.WriteLine(result);

        }
        public static void GuessGame()
        {
            var number = new Random().Next(1, 100);
            var count = 0;
            Console.Write("Guess the number : 1 - 100 \n");

            while (true)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                count++;
                if (guess < number)
                {
                    Console.WriteLine("To low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("To high");
                }
                else if (guess == number)
                {
                    Console.WriteLine("High five!");
                    break;
                }


                Console.Write("Try again\n");
            }
            Console.WriteLine($"Guesses {count} and the answer is {number}");
        }

        static void WriteTexttoFile()
        {
            try
            {
                StreamWriter writer;
                // Use your own Path ****
                string path = @"C:\Users\Kungen\Desktop\TetsC\test.txt";
                writer = new StreamWriter(path);
                Console.WriteLine("Create a text in a file.");
                string Text = Console.ReadLine();
                writer.WriteLine(Text);
                writer.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Success saved! ");
            }
        }
        static void ReadTexttoFile()
        {
            try
            {     // Use your own Path **** to open the file
                StreamReader reader = new StreamReader(@"C:\Users\Kungen\Desktop\TetsC\test.txt");
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine($"The word you have written is : {line}\n");

                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Succes reading the text file.\n");

            }

        }
        static void SquarePowOfTwoAndTen()
        {
            const double POWER_OF_TWO = 2;
            const double POWER_OF_TEN = 10;
            Console.WriteLine("Enter a number (decimal): ");

            var num = Convert.ToDecimal(Console.ReadLine());
            decimal square = (decimal)Math.Sqrt((double)num);
            var pow2 = (decimal)Math.Pow((double)num, (double)POWER_OF_TWO);
            var pow10 = (decimal)Math.Pow((double)num, (double)POWER_OF_TEN);

            Console.WriteLine($"Square of {num} is {square}");
            Console.WriteLine($"Number {num} power of {POWER_OF_TWO} is = {pow2} ");
            Console.WriteLine($"Number {num} power of {POWER_OF_TEN} is = {pow10} ");

        }
        static void MultiplTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine("\n");
            }

        }
        static void FillRandomArray()
        {

            int Min = 0;
            int Max = 100;

            int[] arr1 = new int[6];

            Random randNum = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = randNum.Next(Min, Max);
            }

            foreach (var number in arr1)
            {
                Console.WriteLine($"Array filled with random number {number}");
            }

            int[] arr2 = new int[6];
            arr1.CopyTo(arr2, 0);

            for (int i = 0; i <= arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        (arr2[j], arr2[i]) = (arr2[i], arr2[j]);
                    }
                }
            }
            Console.WriteLine("");
            foreach (var number in arr2)
            {
                Console.WriteLine($"Array is sorted {number}");
            }

        }

        static void IsPalindrom()
        {
            Console.Write("Enter a string to Check Palindrome : \n");
            string word = Console.ReadLine();
            char[] inputWord = word.ToCharArray();
            Array.Reverse(inputWord);
            string reverse = new string(inputWord);

            if (word.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{word} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not Palindrome");
            }
        }

        static void PrintBetweenTwoValues()
        {
            Console.WriteLine("Enter 2 numbers to see which ones are in between\n");
            Console.Write("Input1: ");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input2: ");
            var input2 = Convert.ToInt32(Console.ReadLine());
            if (input1 > input2)
            {
                Console.WriteLine("Please enter from low number to high number\n");
                return;
            }
            Console.Write($"Between  inputs {input1} and {input2} is :\n");

            for (int i = input1 + 1; i <= input2 - 1; i++)
            {

                Console.Write($"{i}\t ");

            }
        }
        static void PrintEvenOrOdd()
        {

            string Numbers;
            var Odd = new List<int>();
            var Even = new List<int>();


            Console.Write("Please enter values seperated by a ',' (comma): \n");
            Numbers = Console.ReadLine();


            int[] numbers = Numbers.Split(',').Select(input => Convert.ToInt32(input)).ToArray();
            Array.Sort(numbers);


            foreach (var i in numbers)
            {
                var num = i;
                if (num % 2 == 0)
                    Even.Add(num);
                else
                    Odd.Add(num);
            }


            Console.Write("Odd numbers : \n");
            foreach (var odd in Odd)
                Console.Write($"{odd}\t");
            Console.WriteLine();

            
            Console.Write("Even numbers : \n");
            foreach (var even in Even)
                Console.Write($"{even}\t");
            Console.WriteLine();


        }

        static void AddedCommaSeparatedDigits()
        {
            string Numbers;
            int sum = 0;


            Console.Write("Please enter values seperated by a ',' (comma): \n ");
            Numbers = Console.ReadLine();


            var NumbersList = Numbers.Split(",").ToList();


            foreach (var i in NumbersList)
            {
                var num = int.Parse(i);
                sum += num;
            }
            Console.WriteLine($"Sum of {Numbers} is {sum}");
        }

        class Player
        {

            public string name;
            public int health;
            public int luck;
            public int strength;

        }

        static void HealthStrengthAndLuck()
        {

            Random rand = new Random();
            Console.WriteLine("Your character name? ");
            Player character = new Player
            {
                name = Console.ReadLine(),
                health = rand.Next(20, 100),
                luck = rand.Next(1, 10),
                strength = rand.Next(80, 300)
            };



            Console.WriteLine("The opponents name? ");
            Player Opponents = new Player
            {
                name = Console.ReadLine(),
                health = rand.Next(20, 100),
                luck = rand.Next(1, 10),
                strength = rand.Next(80, 300)
            };
            Console.WriteLine("");
            Console.WriteLine("-------------------------LetsPlay-----------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Character\n{character.name} \nStrength: {character.strength} \nHealth: {character.health} \nLuck: {character.luck}");
            Console.WriteLine("");
            Console.WriteLine($"Opponents\n{Opponents.name} \nStrength: {Opponents.strength} \nHealth: {Opponents.health} \nLuck: {Opponents.luck}");


        }
        static void Main()
        {
            bool finished = false;

            do
            {
                Console.WriteLine("Welcome to lexicon menu! enter a number to choose a function.\n");
                Console.WriteLine("1 --> Hello World.");
                Console.WriteLine("2 --> Create user information.");
                Console.WriteLine("3 --> Color changes the text.");
                Console.WriteLine("4 --> Today's date.");
                Console.WriteLine("5 --> See witch the input value is the larges.");
                Console.WriteLine("6 --> Guss the number between 1 and 100.");
                Console.WriteLine("7 --> Save a text in a file.");
                Console.WriteLine("8 --> Read the saved text from file.");
                Console.WriteLine("9 --> Submits a decimal number, raised to 2 and raised to 10.");
                Console.WriteLine("10 --> multiplication table from 1 to 10.");
                Console.WriteLine("11 --> Random numbers in ascending order.");
                Console.WriteLine("12 --> See if the word is palindrom.");
                Console.WriteLine("13 --> Prints all numbers that are between the two inputs.");
                Console.WriteLine("14 --> Prints sorted odd and even values.");
                Console.WriteLine("15 --> Prints added comma-separated digits.");
                Console.WriteLine("16 --> Prints add random values ​​for Health, Strength and Luck.");

                Console.Write("----------------------------------------------------------------------\n");

                Console.Write("Choose : 1 to 16  \n");


                int selection = int.Parse(Console.ReadLine());


                Console.Write("----------------------------------------------------------------------\n");

                switch (selection)
                {
                    case 1:
                        SayHello();
                        break;
                    case 2:
                        UserInfo();
                        break;
                    case 3:
                        ColorChanges();
                        break;
                    case 4:
                        GetDate();
                        break;
                    case 5:
                        LargestValueOfToInputs();
                        break;
                    case 6:
                        GuessGame();
                        break;
                    case 7:
                        WriteTexttoFile();
                        break;
                    case 8:
                        ReadTexttoFile();
                        break;
                    case 9:
                        SquarePowOfTwoAndTen();
                        break;
                    case 10:
                        MultiplTable();
                        break;
                    case 11:
                        FillRandomArray();
                        break;
                    case 12:
                        IsPalindrom();
                        break;
                    case 13:
                        PrintBetweenTwoValues();
                        break;
                    case 14:
                        PrintEvenOrOdd();
                        break;
                    case 15:
                        AddedCommaSeparatedDigits();
                        break;
                    case 16:
                        HealthStrengthAndLuck();
                        break;
                    default:
                        Console.WriteLine("No valid selection please choose (1-16)");
                        break;
                }




                Console.WriteLine("\nWill you like to choose another option? press Y to continue or Q to quit");
                char c = char.Parse(Console.ReadLine());


                if (c == 'y')
                {
                    finished = false;
                }
                else if (c == 'q')
                {

                    finished = true;

                }

                Console.Clear();
            } while (!finished);




        }


    }



}

