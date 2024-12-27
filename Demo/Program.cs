namespace Demo
{
    enum Gender
    {
        Male = 1,
        Female
    }
    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuseday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Grades
    {
        A, B, C, D, E, F
    }
    enum Roles
    {
        Admin = 10, Editor = 20, Viewer = 30
    }
    enum Branches : byte
    {
        NasrCity, Alex = 251, Maadi, Dokki, Enhaas, SmartVallige
    }
    [Flags]
    enum Permissions : byte
    {
        Delete = 1, Excute = 2, Read = 4, Write = 8
    }
    class Employee
    {
        public string Name;
        public int Age;
        public Gender Gender;// Female - Male
        public Roles Role;
        public Permissions Permissions;
    }
    internal class Program
    {
        public static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DoProtectiveCode()
        {

            //int X, Y, Z;
            //bool Flag;
            //int X = int.Parse(Console.ReadLine()); // Format Exception
            //do
            //{
            //    Console.WriteLine("Enter First Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out X);
            //}
            //while (!Flag);
            ////Y = int.Parse(Console.ReadLine()); // Divided By Zero Exception
            //do
            //{
            //    Console.WriteLine("Enter Second Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out Y);
            //}
            //while (!Flag || Y == 0);
            //Z = X / Y;
            //int[] Numbers = { 1, 2, 3 };
            //if (Numbers?.Length > 10)
            //    Numbers[10] = 100;
        }

        static void Main(string[] args)
        {
            #region Exception Handling
            //DoSomeCode(); 
            try
            {
                DoProtectiveCode();
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }
            finally
            {
                //delete - Close - free- dealocate un managed resources
                //open file
                //open DB
                //Console.WriteLine("Finally");
            }
            //DoProtectiveCode();
            //throw new Exception();
            //Console.WriteLine("After Try Catch");
            #endregion

            #region Access Modifier
            //TypeA typeA = new TypeA();

            //TypeB//
            //typeA.X = 10;
            //typeA.Y = 10;
            //typeA.Z = 10;
            #endregion

            #region Enums
            #region EX01
            //string day = " Hamada";
            //Days day = Days.Friday;
            //Grades grade = Grades.A;
            //if(grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //} 
            #endregion

            #region EX02
            //Grades grade = (Grades)2; // Explicit Casting
            //Console.WriteLine(grade);// C 
            //Grades grade = (Grades)10; // Explicit Casting
            //Console.WriteLine(grade); // 10
            #endregion

            #region EX03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(grade);
            #endregion

            #region EX04
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object Result);
            //Console.WriteLine(Result);

            //Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender result);
            //Console.WriteLine(result);
            #endregion
            //Gender gender = new Gender();
            //Console.WriteLine(gender);
            #endregion

            #region Permissions
            Employee employee = new Employee();
            //employee.Name = "Ali";
            //employee.Age = 20;
            //employee.Permissions = (Permissions)3;
            //Console.WriteLine(employee.Permissions);
            //// ^
            //employee.Permissions ^= Permissions.Read;
            //Console.WriteLine(employee.Permissions);
            //employee.Permissions ^= Permissions.Read;
            //Console.WriteLine(employee.Permissions);

            //// &
            //if((employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read is Exist");
            //    Console.WriteLine(employee.Permissions);
            //}
            //else
            //{
            //    Console.WriteLine(employee.Permissions ^= Permissions.Read);
            //}

            //// |
            //employee.Permissions |= Permissions.Write;
            //Console.WriteLine(employee.Permissions);
            #endregion

            #region Struct
            //Point P01 = new Point();
            //P01.X = 10;
            //P01.Y = 20;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01);
            //Console.WriteLine(P01.ToString());
            //Point P02 = new();
            #endregion
        }
    }
}
