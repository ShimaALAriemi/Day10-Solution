
namespace Day10
{
    internal class Proudect
    {
        public static int con;
        public int id;
        public string Pname;
        public string discription;
        public decimal price;

        public Proudect(string Pname, string discription, int price)
        {
            id = con++;
            this.Pname = Pname;
            this.discription = discription;
            this.price = price;
        }

        public Proudect()
        {

        }

        public void PrintDetails()
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine($"|Prudect ID: {id}\n" +
                $"|Prudect Name: {Pname}\n" +
                $"|Prudect Discription: {discription}\n" +
                $"|Prudect Price: {price}\n");
        }
        

    }
}
