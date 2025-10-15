using System;

class Program
{
    static void Main(string[] args)
    {
        string[] name = new string[3] { "Breathing Activity", "Reflection Activity", "Listing Activity" };
        string[] description = new string[3] { "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." };

        int decision = -1;

        while (decision != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit\n");
            Console.Write("\nSelect a numbered choice from the menu: ");
            
            decision = int.Parse(Console.ReadLine()) - 1;

            if (decision == 1)
            {
                BreathingActivity newBreathingActivity = new BreathingActivity(name[decision], description[decision]);
                newBreathingActivity.Run();
            }
            else if (decision == 2)
            {
                ListingActivity newListingAcitivity = new ListingActivity(name[decision], description[decision]);
                newListingAcitivity.Run();
            }
            else if (decision == 3)
            {
                ReflectingActivity newReflectingActivity = new ReflectingActivity(name[decision], description[decision]);
                newReflectingActivity.Run();
            }
            else if (decision == 4)
            {
                //
            }
        }
    }
}