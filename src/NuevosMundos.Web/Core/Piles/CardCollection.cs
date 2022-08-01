namespace NuevosMundos.Core
{
    public class CardCollection
    {
        protected List<Card> cards;
        public bool HasCards => cards.Any();

        public CardCollection()
        {
            cards = new List<Card>();
        }

        public Card Top => cards.Any() ? cards.Last() : null;

        public Card Take()
        {
            if (!HasCards)
            {
                return null;
            }

            var card = Top;
            cards.RemoveAt(cards.Count - 1);
            return card;
        }


        public void Set(Card card) => cards.Add(card);
    }
}
