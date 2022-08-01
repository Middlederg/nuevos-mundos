namespace NuevosMundos.Core
{
    public record Biome
    {
        public static Biome Ocean => new Biome(1, nameof(Ocean), "5D5F5E");
        public static Biome Coast => new Biome(2, nameof(Coast), "C4AB9D");
        public static Biome Jungle => new Biome(3, nameof(Jungle), "748A55");
        public static Biome Savannah => new Biome(4, nameof(Savannah), "B26536");
        public static Biome Desert => new Biome(5, nameof(Desert), "C1994D");
        public static Biome HighMountain => new Biome(6, nameof(HighMountain), "885369");
        public static Biome Taiga => new Biome(7, nameof(Taiga), "151312");
        public static Biome ArcticTundra => new Biome(8, nameof(ArcticTundra), "7F85A5");

        public static IEnumerable<Biome> All => new[]
        {
            Ocean,
            Coast,
            Jungle,
            Savannah,
            Desert,
            HighMountain,
            Taiga,
            ArcticTundra
        };

        private readonly string name;

        private Biome(int id, string name, string color)
        {
            this.name = name;
            Id = id;
            Color = color;
        }

        public int Id { get; }

        public string Color { get; }

        public override string ToString() => name;
    }
}
