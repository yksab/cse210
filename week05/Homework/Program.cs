using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Basky", "maths");

        newAssignment.GetSummary();

        MathAssignment newMathAssignment = new MathAssignment("Jeff", "maths", "section 8", "problems 1 to 4");

        newMathAssignment.GetHomeworkList();
    }
}