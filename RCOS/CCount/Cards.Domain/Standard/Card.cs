namespace Cards.Domain.Standard
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }
    }
}