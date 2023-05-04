namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise1
            DateTime dt = new DateTime(2023, 05, 03, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            // Exercise2
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}