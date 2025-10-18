using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "y";

        Console.Clear();
        Console.WriteLine("Foudation 3 Activity");

        while (answer == "y")
        {
            Console.Write("\nHow many activity objects do you want to create? ");
            int numObjects = int.Parse(Console.ReadLine());
            string date = "18 Oct 2025";

            //Fixed variables
            List<Activity> newActivity1 = new List<Activity>();
            Cycling newCycling1 = new Cycling(date, 60, 20);
            Running newRunning1 = new Running(date, 10, 5);
            Swimming newSwimming1 = new Swimming(date, 45, 3);
            newActivity1.Add(newCycling1);
            newActivity1.Add(newRunning1);
            newActivity1.Add(newSwimming1);
            
            // Create random variable objects
            List<Activity> newActivity2 = new List<Activity>();
            Random ranNumber = new Random();
            
            for(int i = 1; i <= numObjects; i ++)
            {
            int createOject = ranNumber.Next(1, 4);

            if (createOject == 1)
            {
                int distance = ranNumber.Next(5, 16);
                Cycling newCycling2 = new Cycling(date, ranNumber.Next(60, 120), distance);
                newActivity2.Add(newCycling2);
            }
            else if (createOject == 2)
            {
                int speed = ranNumber.Next(5, 16);
                Running newRunning2 = new Running(date, ranNumber.Next(30, 120), speed);
                newActivity2.Add(newRunning2);
            }
            else if (createOject == 3)
            {
                int laps = ranNumber.Next(1, 6);
                Swimming newSwimming2 = new Swimming(date, ranNumber.Next(3,8), laps);
                newActivity2.Add(newSwimming2);
            }

            }

            Console.WriteLine($"\nSummary of Activities.\n");

            Console.WriteLine("Fixed Variables List");

            int count = 1;

            foreach (Activity activity1 in newActivity1)
            {
                Console.WriteLine($"{count}. {activity1.GetSummary()}");
                count ++;
            }

            Console.WriteLine("\nRadom Variable List");

            count =1;

            foreach (Activity activity2 in newActivity2)
            {
                Console.WriteLine($"{count}. {activity2.GetSummary()}");
                count ++;
            }

            Console.WriteLine("\nWould you like to try again? (y or n)");
            answer = Console.ReadLine();
        }
        
    }
}