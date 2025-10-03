using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string name = "Samuel Bennett";
        string topic = "Multiplication";
        Assignment a = new Assignment(name, topic);
        a.GetSummary();
    }
}