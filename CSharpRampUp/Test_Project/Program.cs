using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight in pounds : ");
            int weight_in_pounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================================");
            Console.WriteLine("Weight in Pounds = " + weight_in_pounds);
            Console.WriteLine("Weight in Kilograms = " + (weight_in_pounds * 0.45359237));
            Console.WriteLine("==========================================");

            Console.WriteLine("Enter distance in Miles(mi) = ");
            int distance_in_miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Distance in Miles (mi) = " + distance_in_miles);
            Console.WriteLine("Distance in Kilometers (km) = " + (distance_in_miles * 1.6));
            Console.WriteLine("==========================================");

            Console.WriteLine("Enter temperature in Fahrenheit (°F) = ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fahrenheit (°F) = " + fahrenheit);
            Console.WriteLine("Celsius (°C) = " + ((fahrenheit - 32) * 5 / 9));
            Console.WriteLine("==========================================");

            Console.WriteLine("Enter the students ages = ");
            Console.WriteLine("Student 1 = ");
            int age_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 2 = ");
            int age_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 3 = ");
            int age_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 4 = ");
            int age_4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 5 = ");
            int age_5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 6 = ");
            int age_6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 7 = ");
            int age_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 8 = ");
            int age_8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 9 = ");
            int age_9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 10 = ");
            int age_10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==========================================");
            Console.WriteLine("Age of Student 1 = " + age_1);
            Console.WriteLine("Age os Student 2 = " + age_2);
            Console.WriteLine("Age of Student 3 = " + age_3);
            Console.WriteLine("Age os Student 4 = " + age_4);
            Console.WriteLine("Age of Student 5 = " + age_5);
            Console.WriteLine("Age of Student 6 = " + age_6);
            Console.WriteLine("Age of Student 7 = " + age_7);
            Console.WriteLine("Age of Student 8 = " + age_8);
            Console.WriteLine("Age of Student 9 = " + age_9);
            Console.WriteLine("Age of Student 10 = " + age_10);
            Console.WriteLine("==========================================");
            var ages = new int[] { age_1, age_2, age_3, age_4, age_5, age_6, age_7, age_8, age_9, age_10};
            double average = Queryable.Average(ages.AsQueryable());
            Console.WriteLine("The Average Age of the Students is = " + average);
            Console.WriteLine("==========================================");

            
            string heroName = "Ethan";
            string villainName = "Ryza";
            string companionName = "Elysia";
            string mentorName = "Vill";
            string mysteriousStrangerName = "Seraphina";

            string swordName = "Blade of Valor";
            string staffName = "Scepter of Arcane Mastery";
            string bowName = "Shadowhunter's Bow";
            string armorName = "Dragonhide Armor";
            string amuletName = "Amulet of Eternal Wisdom";

            string potionName = "Elixir of Healing";
            string mapName = "Ancient Map of Eldoria";
            string crystalName = "Crystal of Time";

            string heroAbility = "Radiant Strike";
            string villainAbility = "Dark Obliteration";
            string companionAbility = "Nature's Embrace";
            string mentorAbility = "Arcane Wisdom";
            string strangerAbility = "Shadow Manipulation";

            string story = $"Once upon a time in the world of Arathos, there lived a hero name {heroName}.";
            story += $"He weilded the mighty {swordName} and possessed the abily known as '{heroAbility}'.";
            story += $"On the other side, the notorious Villain {villainName} sought to unleash chaos with the sinister power of";
            story += $"{villainAbility}. Little did {heroName} know that a mysterious stranger named {mysteriousStrangerName}";
            story += $"skilled in '{strangerAbility}', would play a crucial role in the impending conflict.";
            story += $"Guiding {heroName} on his quest was the wise mentor {mentorName}, who possessed the ancient {staffName}";
            story += $"and the profound ability of '{mentorAbility}'.Alongside {heroName}, the loyal companion {companionName} armed with";
            story += $"the enchanted {bowName} and the nature-infused ability '{companionAbility}'.";
            story += $"As the journey unfolded, the adventurers discovered magical items like the healing {potionName}, the mystical {mapName},";
            story += $"legendary {crystalName}. {heroName} faced numerous challenges, relying on the strength of {armorName} and the wisdom granted by the {amuletName}.";
            story += $"In the end, the fate of Arathos hung in the balance, and the clash between good and evil reached its climax.";
            story += $"Would {heroName} triumph over {villainName} and save the realm, or would darkness prevail? Only time would tell.";


            Console.WriteLine("=========================================================================");
            Console.WriteLine(story);
            Console.WriteLine("=========================================================================");

            
            
            
            Console.Write("Enter a number : ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                PrintNumberPattern(number);
            }
            else
            {
                Console.WriteLine("Invalid input. That don't work like that.");
            }
        }

        static void PrintNumberPattern(int number)
        {
            for (int entered_number = 1; entered_number <= number; entered_number++)
            {
                for (int output_number = 1; output_number <= entered_number; output_number++)
                {
                    Console.Write(output_number + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==========================================");




            {
                Console.Write("Enter a number : ");
                int the_number;

                if (int.TryParse(Console.ReadLine(), out the_number) && the_number > 0)
                {
                    int what_you_want = CalculateSum(the_number);
                    Console.WriteLine($"Sum of the numbers {the_number} is : {what_you_want}");
                }
                else
                {
                    Console.WriteLine("Invalid input. That don't work like that.");
                }
            }
            int CalculateSum(int the_number)
            {
                int added = 0;

                for (int meh = 1; meh <= the_number; meh++)
                {
                    added += meh;
                }

                return added;
            }

            
            Console.WriteLine("==========================================");

            
            {
                Console.Write("Enter a number : ");
                int number_2;

                if (int.TryParse(Console.ReadLine(), out number_2) && number_2 > 0)
                {
                    PrintNumberPattern(number_2);
                }
                else
                {
                    Console.WriteLine("Invalid input. That don't work like that.");
                }
            }
            void PrintNumberPattern(int number_2)
            {
                for (int entered_number = number_2; entered_number >= 1; entered_number--)
                {
                    for (int output_number = 1; output_number <= entered_number; output_number++)
                    {
                        Console.Write(output_number + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("==========================================");
        }
    }
}
