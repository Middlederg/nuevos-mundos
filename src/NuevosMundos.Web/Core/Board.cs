namespace NuevosMundos.Core
{

    public class Board
    {
        public List<IPile> Piles { get; }

        private DiscardPile DiscardPile => Piles.First(pile => pile is DiscardPile) as DiscardPile;
        public DrawPile DrawPile => Piles.First(pile => pile is DrawPile) as DrawPile;

        private IEnumerable<IPile> PilesWithBiomaStrategy => Piles.Where(pile => pile.CanBeTakenWithBiomaStrategy);

        public IPile GetPileByLocation(int location) 
        {
            if (location < 0 || location > Piles.Count)
            {
                return null;
            }

            return Piles.ElementAt(location);
        } 

        public Board()
        {
            Piles = new List<IPile>
            {
                new DiscardPile(),
                new DrawPile()
            };

            foreach (var _ in Enumerable.Range(2, 5))
            {
                Piles.Add(new CardPile());
            }

            foreach (var location in Enumerable.Range(2, 5))
            {
                DrawCardFor(location);
            }
        }

        public IEnumerable<Card> PlayCard(Card card, PlayStrategy strategy)
        {
            if (strategy == PlayStrategy.Bioma)
            {
                foreach (var pile in PilesWithBiomaStrategy)
                {
                    if (pile.HasCard && pile.Top.Biome == card.Biome)
                    {
                        var takenCard = pile.Take();
                        yield return takenCard;
                    }
                }
            }

            if (strategy == PlayStrategy.Bioma)
            {
                foreach (var number in new int[] {  card.FirstNumber, card.SecondNumber })
                {
                    var pile = GetPileByLocation(card.FirstNumber);
                    if (pile is not null && pile.HasCard)
                    {
                        var takenCard = pile.Take();
                        yield return takenCard;
                    }
                }
            }

            if (strategy == PlayStrategy.None)
            {
                yield return card;
            }
            else
            {
                DiscardPile.Add(card);
            }
        }


        private void DrawCardFor(int location)
        {
            var pile = GetPileByLocation(location);
            if (pile is not null && pile is CardPile cardPile)
            {
                var card = DrawPile.Take();
                cardPile.Set(card);
            }    
        }
    }
}
