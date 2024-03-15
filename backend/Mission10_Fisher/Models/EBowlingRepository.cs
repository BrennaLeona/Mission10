using Microsoft.EntityFrameworkCore;

namespace Mission10_Fisher.Models
{
    public class EBowlingRepository : IBowlingRepository
    {
        private BowlingContext _context;
        public EBowlingRepository(BowlingContext temp) {
            _context = temp;
        }
        public IEnumerable<Bowlers> Bowlers => _context.Bowlers;
        public IEnumerable<Teams> Teams => _context.Teams;
    }
}
