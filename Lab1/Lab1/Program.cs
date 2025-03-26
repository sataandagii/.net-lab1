namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            DataFiller dataFiller = new DataFiller(data);
            dataFiller.FillData();

            DataQueries query = new DataQueries(data);
            query.DonatedTo3Organisations();
        }

    }
}