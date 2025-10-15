using System;

class Program
{
    static void Main(string[] args)
    {

        //Exceed requirements: 1. added 4 other randomly choosen spinners. 2. in reflection questions prompt the questions dont repeat, when all the questions r used a message says theres no more questions and the program carries onto the next step 

        string[] name = new string[3] { "Breathing Activity", "Reflection Activity", "Listing Activity" };
        string[] description = new string[3] { "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." };

        int decision = -1;

        while (decision != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
            Console.Write("\nSelect a numbered choice from the menu: ");
            
            decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                BreathingActivity newBreathingActivity = new BreathingActivity(name[decision-1], description[decision-1]);
                newBreathingActivity.Run(); 
            }
            else if (decision == 2)
            {
                ReflectingActivity newReflectingActivity = new ReflectingActivity(name[decision-1], description[decision-1]);
                newReflectingActivity.Run();
            }
            else if (decision == 3)
            {
                ListingActivity newListingAcitivity = new ListingActivity(name[decision-1], description[decision-1]);
                newListingAcitivity.Run();
            }
            else if (decision == 4)
            {
                continue;
            }
        }
    }
}