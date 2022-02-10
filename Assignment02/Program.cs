using System;

namespace Assignment02
{
    class Program
    {

        static void Main(string[] args)
        {
            int number;
            bool exit = false;
            Rectangle rectangle = new Rectangle(GetValue("Length"), GetValue("Width"));
            do
            {

                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Area");
                Console.WriteLine("6. Get Rectangle perimeter");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please Choose Any option between 1-7:::");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Get Rectangle Length :" + rectangle.GetLength() + "\n");
                        break;

                    case 2:
                        Console.WriteLine("Chnage Rectangle Length :");
                        rectangle.SetLength(GetValue("Length"));
                        Console.WriteLine("Your Length is " + rectangle.GetLength() + "\n");

                        break;

                    case 3:
                        Console.WriteLine("Get Rectangle Width ::" + rectangle.GetWidth() + "\n");
                        break;

                    case 4:
                        Console.WriteLine("Change Rectangle Width ::");
                        rectangle.SetWidth(GetValue("Width"));
                        Console.WriteLine("Your Width is " + rectangle.GetWidth() + "\n");
                        break;
                    case 5:
                        Console.WriteLine("Area Of Rectangle is::" + rectangle.GetArea() + "\n");
                        break;
                    case 6:
                        Console.WriteLine("Perimeter Of Rectangle is:" + rectangle.GetPerimeter() + "\n");
                        break;
                    case 7:
                        exit = true;
                        break;

                }

            } while (!exit);

        }
        static int GetValue(string name)
        {
            bool invalid = true;
            string rectangle;
            int value;
            do
            {
                Console.WriteLine("Please enter the  rectangle  of" + name);
                rectangle = Console.ReadLine();

                if (!int.TryParse(rectangle, out value))
                {
                    Console.WriteLine("Value should be in Numeric");
                }
                else if (value < 1)
                {
                    Console.WriteLine("Value Should be Greater than Zero");
                }
                else
                {
                    invalid = false;
                }

            } while (invalid);

            return value;
        }
    }

}