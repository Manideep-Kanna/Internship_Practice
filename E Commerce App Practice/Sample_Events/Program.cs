namespace Program
{
    public delegate void MyDelegate(int x);
    public class Program
    {
       
        public static void Main(String[] args)
        {
            MyDelegate myDelegate;
            myDelegate = square(10);
        }
        public static void square(int n)
        {
            Console.WriteLine(n*n);
        }
        public static void cube(int n)
        {
            Console.WriteLine(n*n*n);
        }
    }
}