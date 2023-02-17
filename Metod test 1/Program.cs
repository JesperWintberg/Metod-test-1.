namespace namn
{
    class Program
    {
        static void Main(string[] args)
        {
            area();
        }

        static void area()
        {
            Console.Write("Skriv in rektanglens bredd: ");
            string bredd = Console.ReadLine();
            Console.Write("Skriv in rektanglens höjd: ");
            string höjd = Console.ReadLine();

            int bredd2 = int.Parse(bredd);
            int höjd2 = int.Parse(höjd);

            Console.WriteLine($"Din rektangel med bredd {bredd2} och höjd {höjd2} har arean {bredd2 * höjd2}");
        }
    }
}
