namespace Challenge2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Employees employees1 = new Employees("Henrique Rodrigues de Almeida", "Herique", 3000);
            Console.WriteLine(employees1.ToString());
            Boss daBoss = new Boss("Godofredo Ramon Almond", "Godofredo", 7900, "Hilux");
            Console.WriteLine(daBoss.ToString());
            Trainees poorIntern = new Trainees("Enzo Figueiro", "Enzo", 900, 6, 5);
            Console.WriteLine(poorIntern.ToString());

            daBoss.Lead();
            poorIntern.Work();

        }
    }
}