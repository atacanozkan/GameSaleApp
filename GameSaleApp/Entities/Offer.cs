namespace GameSale.Entities
{
    public class Offer: IOffer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Discount { get; set; }
    }
}