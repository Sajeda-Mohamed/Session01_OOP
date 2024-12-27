using System;

namespace Common
{
    public class TypeA
    {
        public TypeA()
        {
            TypeB typeB = new TypeB();
        }
        private int X;//class scope only
        internal int Y;//class scope and its project
        public int Z;
        void Print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
        }
    }
}
