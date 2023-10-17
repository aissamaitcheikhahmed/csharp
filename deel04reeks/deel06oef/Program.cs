namespace deel06oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double som = 0;//voor de eind som
            for (int i = 1/*int.Parse(Console.ReadLine())*/; i <= 10;i++) {
                som = som + Math.Pow(i, 2);//hoe meer i komt hoe meer kwadrat wordt hoe meer oud som word gesommed
                }
            Console.WriteLine(som);
        }
    }
}