namespace NuevosMundos.Core
{
    public class Player
    {
        public Player(IEnumerable<Card> cards)
        {
            Hand = cards.ToList();
            Planet = new List<Card>();
        }

        public List<Card> Hand { get; }

        public List<Card> Planet { get; }
    }
}
