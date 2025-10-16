using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        GoalManager newGoalManager = new GoalManager();

        newGoalManager.DisplayPlayerInfo();

        newGoalManager.Start();
        int menuChoice = int.parse(Console.Readline());

        if (menuChoice == 1)


        


    }
}