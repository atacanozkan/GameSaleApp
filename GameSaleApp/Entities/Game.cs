namespace GameSale.Entitites
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}