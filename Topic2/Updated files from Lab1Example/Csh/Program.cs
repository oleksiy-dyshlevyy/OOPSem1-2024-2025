namespace Lab1Example
{
    
    internal class Program
    {
        static int Func()
            { return 0; }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.a = 1;
            myClass.Method();

            int x = Func();


            int[] arr;// = new int[x]; 
            arr = new int[10];

            string str = "Hello";
            Console.WriteLine(str);

            Console.WriteLine("Hello, World!");
        }
    }
}
