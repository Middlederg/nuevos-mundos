namespace NuevosMundos.Core
{
    public class DrawPile : CardCollection, IPile
    {
        public bool CanBeTakenWithBiomaStrategy => false;

        public DrawPile()
        {
            var numbers = Enumerable.Range(1, 8);

            int cont = 1;
            cards = Biome.All.SelectMany(biome => numbers.Select(number => new Card(cont++, biome))).ToList().RandomizeList().ToList();
        }
    }
}
