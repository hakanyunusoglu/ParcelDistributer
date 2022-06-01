using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDistributer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //n -> Boxes
            //k -> Parcels
            string n = "0", k = "0", tempN = "0", answer = "";
            int nn = 0, kk = 0;
        enterN:
            Console.Write("[Between 3 and 20] Enter the Boxes(n): ");
            n = Console.ReadLine();
            if (String.IsNullOrEmpty(n))
            {
                Console.WriteLine("Please enter the [N] value. [N] cannot be empty!");
                goto enterN;
            }
            if (Convert.ToInt32(k) != 0 && (Convert.ToInt32(k) > 2 && Convert.ToInt32(k) < 100))
            {
                goto continueCircle;
            }
        enterK:
            Console.Write("[Between 2 and 100] Enter the Parcels(k): ");
            k = Console.ReadLine();
            if (String.IsNullOrEmpty(k))
            {
                Console.WriteLine("Please enter the [K] value. [K] cannot be empty!");
                goto enterK;
            }
            tempN = n;
            nn = Convert.ToInt32(n);
            kk = Convert.ToInt32(k);
        continueCircle:
            if (!string.IsNullOrEmpty(n) && !string.IsNullOrEmpty(k))
            {
                if (Convert.ToInt32(n) < 3 || Convert.ToInt32(n) > 20)
                {
                    Console.WriteLine("The value of [N] must be between 3 and 20. Re-enter!");
                    Console.ReadLine();
                    goto enterN;
                }
                if (Convert.ToInt32(k) < 2 || Convert.ToInt32(k) > 100)
                {
                    Console.WriteLine("The value of [K] must be between 2 and 100. Re-enter!");
                    Console.ReadLine();
                    goto enterK;
                }
                if ((Convert.ToInt32(n) < 3 || Convert.ToInt32(n) > 20) && (Convert.ToInt32(k) < 2 || Convert.ToInt32(k) > 100))
                {
                    Console.WriteLine("The value of [K] must be between 2 and 100 and the value of [N] must be between 3 and 20. Re-enter! ");
                    goto enterK;
                }

                for (int i = 0; i <= Convert.ToInt32(tempN); i++)
                {
                    if (i == Convert.ToInt32(tempN))
                    {
                    enterAnswer:
                        Console.Write("Do you want to continue? [Y]-[N]: ");
                        answer = Console.ReadLine();
                        if (!string.IsNullOrEmpty(answer))
                        {
                            if (answer == "Y" || answer == "y")
                            {
                                n = "0";
                                k = "0";
                                nn = 0;
                                kk = 0;
                                goto enterN;
                            }
                            else if (answer == "N" || answer == "n")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the correct letter. Re-enter!");
                                answer = "";
                                goto enterAnswer;

                            }
                        }
                    }
                    var fonk = Math.Round((decimal.Divide(kk, nn) + (decimal)(0.49)), 0, MidpointRounding.AwayFromZero);
                    Console.Write($"{i + 1}. Boxes Value : {fonk}");
                    kk = kk - (int)fonk;
                    nn--;
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please fill in all fields!");
                Console.ReadLine();
            }
        }
    }
}
