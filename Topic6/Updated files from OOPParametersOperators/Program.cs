using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPParametersOperators
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        public static int Add (params int[]values)
        {
            int tmp = 0;
            for (int i = 0; i < values.Length; i++)
                tmp += values[i];

            return tmp;
        }

        public static void Method(ref Sqr p, ref int a)
        {
          a = 100;
            Sqr o = new Sqr();
                  o.Side1 = 10000;
            p = o;
             p.Side1 = 10;
        }

        public static Sqr Method1(int a, int b = 0, params int[] c)
        {
            Sqr s = new Sqr();
            //          s.side = b;
            a = 100;
            return s;
        }

        public static void Method2(int a, int b = 0, params int[] c)
        {

            a = 1000;
            //  b = 500;
            
            c[0] = 4;
            c[1] = 7;
            c[10] = 8;
        }
       
        public static void Method3(Sqr sqr)
        {
            sqr.Side1 = 1000;
            sqr = new Sqr();
            sqr.Side1 = 500;

            Sqr sqr5 = new Sqr();
            sqr5.Side1 = 1500;
            sqr = sqr5;

        }

        public static void Method4(int a)
        {
            a = 10;
        }
        static void Main(string[] args)
        {
           // object o = new object();    

            int tmp = Add(1,2);
            string tmpStr = Add("Hello ", "World!");

            int[] arr = {1,2,3,4,5};
            tmp = Add(arr);
            tmp = Add(1, 2, 3);
            tmp = Add(1, 5, 18, 45);
            
            int result = 5;

            Method4(result);
            Sqr sqr1 = new Sqr();
            sqr1.Side1 = 1000;
           // sqr1.Side2 = 500;
            Sqr sqr2 = new Sqr(5);

        //    sqr1.b = true;

            sqr1.Side1 = 3;
            double r = sqr1.Side1;

            r = sqr1.Side;
            sqr1.Side = -5;

            int side1 = sqr1[0, 0];
            sqr1[1, 0] = 5;

           // Sqr sqr5 = new Sqr { b = true, c = 10 };

            Method3(sqr1);

           // int t;
            Method(ref sqr1, ref result);
            Method2(1,2,result);

            sqr2 = Method1(a: result, b: result * 2, c: new int[] { result * 3, result * 4 });
           
            Method2(result, result * 2, result * 3, result * 4);

            Sqr sqr3 = sqr1 + sqr2;
            sqr3 = sqr1 + 5;
            if ((sqr3 <  sqr2) && !sqr1)
                sqr2 = 4 + sqr3;
            sqr2++;

            bool b = true;

      
      

            ++sqr1;

            bool bb = !sqr2;

            sqr1.Side = 5;
            Console.WriteLine(sqr1.Side);

            // System.Object o = sqr3 as object;

            if (sqr1 != sqr2)
            { }

            Hour hour = new Hour(4);
            int h = hour;
            h++;
            hour = (Hour)h;

            Employee employee1 = new Employee();
            Employee employee2 = new Employee()
            {
                firstName = "Ivan",
                lastName = "Ivanov",
                birthDate = new Date(),
                hireDate = new Date(20, 10, 2017)
                //{
                //    day = 20,
                //    month = 10,
                //    year = 2017
                //},
            };
        }
    }
}
