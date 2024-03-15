namespace Mission10_Fisher.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }
    }
}
