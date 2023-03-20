using System;

namespace TeacherProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the teacher page!");
            Console.WriteLine("Please insert grades of students!");
            int result, sum = 0, number;
            int cnt = 0;
            double avg;
            do
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out number);
                if (success)
                    result = number;
                else
                {
                    Console.WriteLine("Please enter the real number");
                    continue;
                }
                if (result != -1) { 
                    sum += result;
                    cnt++;
                };
            } while (number != -1);
            Console.WriteLine(sum);
            avg = (double)sum / (double)cnt;
            Console.WriteLine(avg);
        }
    }
}
