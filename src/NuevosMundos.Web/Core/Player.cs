namespace NuevosMundos.Core
{
    public class Player
    {
        public Player(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();
        }

        public List<Card> Cards { get; }
    }
}
