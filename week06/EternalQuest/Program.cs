using System;

public class Program
{
    static void Main(string[] args)
    {
        // show creativity:


        Console.Clear();

        GoalManager newGoalManager = new GoalManager();

        int menuChoice = 1;

        while(menuChoice != 6)
        {
            newGoalManager.DisplayPlayerInfo();

            newGoalManager.Start();

            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                newGoalManager.CreateGoal();
            }
            else if (menuChoice == 2)
            {
                newGoalManager.ListGoalDetails();
            }
             else if (menuChoice == 3)
            {
                newGoalManager.SaveGoals();
            }
            else if (menuChoice == 4)
            {
                newGoalManager.LoadGoals();
            }
            else if (menuChoice == 5)
            {
                newGoalManager.RecordEvent();
            }
            else if (menuChoice == 6)
            {
                continue;
            }
        }
    }
}