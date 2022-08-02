namespace NuevosMundos.Core
{
    public class Card
    {
        public int Number { get; }
        public Biome Biome { get; }

        public Card(int number, Biome biome)
        {
            Number = number;
            Biome = biome;
        }

        public int FirstNumber => Number < 10 ? -1 : int.Parse(Number.ToString()[..1]);

        public int SecondNumber => Number < 10 ? 
            int.Parse(Number.ToString()[..1]) :
            int.Parse(Number.ToString().Substring(1, 1));

        public override string ToString() => $"{Number} {Biome}";
    }
}
