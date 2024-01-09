namespace Ex30_15_wakayama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(2005,1,9), 80, "デジタル太郎",75 ,0.5f, 160f, 50f);
            person.Introduction(person);
            Console.WriteLine("Hello World!こんにちは！さようなら");
        }
    }
}