namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Data data = new Data();
            DataFiller dataFiller = new DataFiller(data);
            dataFiller.FillData();

            DataQueries query = new DataQueries(data);
            query.DonatedTo3Organisations();
            query.Last3Months();
        }

    }
}