using System;

namespace ReizTech2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var branch = new Branch();
            branch.CreateBranches();

            var depth = branch.CalculateDepth(branch);
            Console.WriteLine($"depth = {depth}");
        }
    }
}