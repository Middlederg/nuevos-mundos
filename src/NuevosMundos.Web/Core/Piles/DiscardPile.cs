namespace NuevosMundos.Core
{
    public class DiscardPile : CardCollection, IPile
    {

        public bool CanBeTakenWithBiomaStrategy => Top != null;

        public void Add(Card card) => cards.Add(card);
    }
}
