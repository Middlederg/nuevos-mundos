namespace NuevosMundos.Core
{
    public class CardPile : IPile
    {
        public Card Top { get; private set; }
        
        public bool CanBeTakenWithBiomaStrategy => Top != null;

        public Card Take()
        {
            var card = Top;
            Top = null;
            return card;
        }

        public void Set(Card card)
        {
            Top = card;
        }
    }
}
