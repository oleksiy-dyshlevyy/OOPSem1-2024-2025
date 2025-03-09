using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPParametersOperators
{
    public class Sqr
    {
        int side;
        public bool b;
        public int c;
        string description;

        public int Side
        {
            get  
            {
                side++;
                return side; 
            }
            set
            {
                if (value > 0)
                    side = value;
             //   Console.WriteLine("sdfdsf");
            }
        }
        public double Side1 { get; set; }// = 2.5;
        public double Side2 { get; }

       
        int[,] sides = new int[4,4];
        int[] sides1 = new int[4];

        public int this[int i]
        {
            get
            {
                return sides1[i];
            }
            set
            {
                sides1[i] = value;
            }
        }
        public int this[int i, int j]
        {
            get 
            {
                return sides[i,j];
            }
            set 
            {
                sides[i,j] = value;
            }
        }


        // public string Description => description;

        //double side2;
        //public double GetSide2()
        //{
        //    return side2;
        //}

        //public void SetSide2(double newSide)
        //{
        //    side2 = newSide;
        //}

        public Sqr()
        {
            side = 1;
           // Side2 = 10;
        }

        public Sqr(int side)
        {
            this.side = side;
        }


        public Sqr(int parside, Boolean f)
        {
            if (f == true)
                side = parside;
            else
                side = parside * 2;
        }

        public Sqr(Sqr obj)
        {
            side = obj.side;
        }

        public int P()
        {
            return side * 4;

        }

        public int S()
        {
            return side * side;
        }

        public int Get()
        {
            return side;
        }

        public void Set(int parside)
        {
            if (parside > 0)
            {
                side = parside;
            }
        }

      
        public static Sqr operator +(Sqr s1, Sqr s2)
        {
            Sqr s3 = new Sqr();
            s3.side = s1.side + s2.side;
            return s3;
        }

        public static Sqr operator +(Sqr s1, int i2)
        {
            Sqr s3 = new Sqr();
            s3.side = s1.side + i2;
            return s3;
        }

        public static Sqr operator +(int i1, Sqr s2)
        {
            Sqr s3 = new Sqr();
            s3.side = i1 + s2.side;
            return s3;
        }

        public static bool operator >(Sqr s1, Sqr s2)
        {
            if (s1.side > s2.side)
                return true;
            else
                return false;
        }

        public static bool operator <(Sqr s1, Sqr s2)
        {
            if (s1.side < s2.side)
                return true;
            else
                return false;
        }

        public static bool operator !(Sqr s2)
        {
            if (0 < s2.side)
                return true;
            else
                return false;
        }

        public static bool operator true(Sqr s2)
        {
            if (0 == s2.side)
                return true;
            else
                return false;
        }

        public static bool operator false(Sqr s2)
        {
            if (0 != s2.side)
                return true;
            else
                return false;
        }

        public static Sqr operator ++(Sqr s)
        {
            s.side++;
            return s;
        }
    }
}
