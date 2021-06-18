using System;
using System.Collections.Generic;
using System.Text;



namespace Assignment01
{
    class Class1
    {
        public static int ValidateUserInput(string chosenNumber)
        {
            int aNumber = 1;
            bool isValid = false;



            while (isValid == false)
            {
                Console.WriteLine($"Enter the {chosenNumber} of rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();



                bool result = int.TryParse(userInput, out aNumber);
                if (aNumber < 1)
                {
                    result = false;
                }



                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }



                else
                {
                    isValid = true;
                    Console.WriteLine($"Your Rectangle's {chosenNumber}  is {aNumber}.\n");
                }
            }



            return aNumber;
        }



        static void Main(string[] args)



        {

            bool flag = false;
            int length; int width;
            Rectangle rec1 = new Rectangle();//rectangle with length= 1 and width= 1
            length = ValidateUserInput("length");
            width = ValidateUserInput("width");
            Rectangle rec2 = new Rectangle(length, width);
            rec1 = rec2;



            while (flag != true)



            {
                Console.WriteLine("\nSelect the option from the menu");
                Console.WriteLine("\n1.Get Rectangle Length\n2.Change Rectangle Length\n3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");
                int selection = Convert.ToInt32(Console.ReadLine());




                switch (selection)
                {
                    case 1:
                        {



                            int oldlength = rec2.GetLength();
                            Console.WriteLine("The length of the rectangle is {0}", oldlength);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the New length of the rectangle");
                            int rlength = Convert.ToInt32(Console.ReadLine());
                            int new_length = rec2.setLength(rlength);
                            Console.WriteLine("The new length of the rectangle  is {0}", new_length);
                            break;
                        }
                    case 3:
                        {
                            int old_width = rec2.getWidth();
                            Console.WriteLine("The width of the rectange is {0}", old_width);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the New width of the rectangle");
                            int rwidth = Convert.ToInt32(Console.ReadLine());
                            int new_width = rec2.setWidth(rwidth);
                            Console.WriteLine("The new width of the rectangle is  {0}", new_width);
                            break;
                        }
                    case 5:
                        {
                            int prm = rec2.GetPerimeter();
                            Console.WriteLine(prm);
                            break;
                        }
                    case 6:
                        {
                            int area = rec2.GetArea();
                            Console.WriteLine(area);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("EXITING");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("INVALID VALUE! try again");
                        break;
                }




            }




        }
    }
}