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

        public int FirstNumber => int.Parse(Number.ToString().Substring(0, 1));

        public int SecondNumber => int.Parse(Number.ToString().Substring(1, 1));

        public override string ToString() => $"{Number} {Biome}";
    }
}
