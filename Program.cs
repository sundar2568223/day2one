using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("name :\t"+name +"\n Age: "+age +"\n Grade: \t"
                +grade +"\n salary: \t "+salary +"\n Date ofJoining: \t "+doj);
            Console.ReadKey();


        }
    }
}