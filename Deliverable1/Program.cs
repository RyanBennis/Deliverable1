using System;

class MainClass
{

    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Please enter your starting unit: 1 = inches 2 = feet 3 = Fidget spinners 4 = memes");

            int unit = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the unit you wish to convert to: 1 = inches 2 = feet 3 = Fidget spinners 4 = memes");

            int convertedunit = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number of units you wish to convert");
            //Console.WriteLine(score "to" convert);
            float number = float.Parse(Console.ReadLine());
            // same unit to same unit 
            if (unit == convertedunit)
            {
                Console.WriteLine(number * 1);
            }
          
            // inches to fidget spinners 
            else if (unit == 1 && convertedunit == 3)
            {
                Console.WriteLine(number * 3.5 + " Fidget Spinners");
            }
            //fidget spinner to inches
            else if (unit == 3 && convertedunit == 1)
            {
                Console.WriteLine(number / 3.5 + " Inches");
                // feet to meme
            }
            else if (unit == 2 && convertedunit == 4)
            {
                Console.WriteLine(number * 5 + " Memes");
            }
            // meme to feet 
            else if (unit == 4 && convertedunit == 2)
            {
                Console.WriteLine(number / 5 + " Feet");
            }

            while (true) // Continue asking until a correct answer is given.
            {
                Console.Write("Do you want to Convet again [Y/N]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    break; // Exit the inner while-loop and continue in the outer while loop.
                if (answer == "N")
                    return; // Exit the Main-method.
            }
        }
    }

}