using System.Data;
using System.Reflection;
using System.Security.Cryptography;

namespace Assignment
{
    enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuseday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Season
    {
        Summer, Spring, Winter, Autumn
    }
    [Flags]
    enum Permissions
    {
        Delete = 1, Excute = 2, Read = 4, Write = 8
    }
    enum Colors
    {
        Red, Green, Blue
    }
    class Employee
    {
        public string Name;
        public int Age;
        public Permissions Permissions;
    }
    internal class Program
    {
        public static void MonthRange(Season S)
        {
            switch (S)
            {
                case Season.Summer:
                    Console.WriteLine("june to august");
                    break;
                case Season.Spring:
                    Console.WriteLine("march to may");
                    break;
                case Season.Autumn:
                    Console.WriteLine("September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine(" December to February");
                    break;
            }
        }
        public static void PrimaryColor(Colors C)
        {
            switch (C)
            {
                case Colors.Red:
                    Console.WriteLine("Primary Color ");
                    break;
                case Colors.Green:
                    Console.WriteLine("Not Primary Color ");
                    break;
                case Colors.Blue:
                    Console.WriteLine("Primary Color ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            #region Q01 Enum "WeekDays"
            //Console.WriteLine("Enter Day of The Week : ");
            //Enum.TryParse<WeekDays>(Console.ReadLine(), true, out WeekDays day);
            //Console.WriteLine(day);
            #endregion

            #region Q02 Enum "Season"
            //Console.WriteLine("Enter The Name of Season : ");
            //Enum.TryParse<Season>(Console.ReadLine(), true, out Season season);
            //MonthRange(season);
            #endregion

            #region Q3 Enum Permissions
            Employee employee = new Employee();
            //employee.Permissions |= Permissions.Write;
            //employee.Permissions |= Permissions.Delete;
            //Console.WriteLine(employee.Permissions);
            #endregion

            #region Q4 Enum Colors
            //Console.WriteLine("Enter a Color from these Color\n[Red, Green, Blue]");
            //Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors color);
            //PrimaryColor(color);
            #endregion

            #region Q5 Struct Point
            Console.WriteLine("Enter the coordinates for the first point (X Y):");
            string[] input1 = { Console.ReadLine(), Console.ReadLine() };
            double.TryParse(input1[0], out double x1);
            double.TryParse(input1[1], out double y1);
            Console.WriteLine("Enter the coordinates for the second point (X Y):");
            string[] input2 = {Console.ReadLine(), Console.ReadLine()};
            double.TryParse(input2[0], out double x2);
            double.TryParse(input2[1], out double y2);
            Point P01 = new Point(x1, y1);
            Point P02 = new Point(x2, y2);
            double distance = Point.CalcDistance(P01, P02);
            Console.WriteLine($"The Distance between 2 Point is : {distance}");
            #endregion
        }
    }
}
