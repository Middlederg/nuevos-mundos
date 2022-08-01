namespace NuevosMundos.Core
{
    public interface IPile
    {
        bool CanBeTakenWithBiomaStrategy { get; }
        Card Top { get; }
        bool HasCard => Top != null;
        Card Take();

        string ToString() => Top?.ToString();
    }
}
