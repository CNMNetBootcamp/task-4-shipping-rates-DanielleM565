using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            double weight;
            string shippingCost;
            string continueResponse = "Y";

            //input
            do
            {
                do
                {
                    Console.WriteLine("What is the package's weight in lbs?");
                } while (!Double.TryParse(Console.ReadLine(), out weight));

                //process
                if (weight <= 2)

                {
                    shippingCost = "$2";
                }
                else if (weight > 2 && weight <= 6)
                {
                    shippingCost = "$4";
                }
                else if (weight > 6 && weight <= 10)
                {
                    shippingCost = "$6";
                }
                else
                {
                    shippingCost = "$8";
                }
                //please note that while the assignment did not explicitly say less that Or equal to... I did not what the program to have a bug if weight equals 6 so I added that on my own

            //output
                Console.WriteLine("The shipping cost for that package will be " + shippingCost);
                Console.WriteLine("Do you have another package to ship? (Y)es or (N)o");
                continueResponse = Console.ReadLine();
            } while (continueResponse.ToUpper() == "Y");
        }
    }
}

