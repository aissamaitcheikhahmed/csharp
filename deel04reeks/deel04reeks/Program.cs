namespace deel04reeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal 1?: ");
            int invoergetal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Getal 2?: ");
            int invoergetal2 = int.Parse(Console.ReadLine());
            int getal1 = Math.Min(invoergetal1, invoergetal2);
            int getal2 = Math.Max(invoergetal2, invoergetal1);
            do
            {
                Console.Write(getal1++ + " ");

            } while (getal1 <= getal2);
        }
    }
}