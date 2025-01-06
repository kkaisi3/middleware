using Microsoft.EntityFrameworkCore;

namespace Adventure.Repository
{
    public interface IAdventurerRepository
    {
        public List<Adventurer> ReadAdventurers();
    }
    public class AdventurerRepository : IAdventurerRepository
    {
        private AdventureDbContext _db;
        public AdventurerRepository(AdventureDbContext db)
        {
            _db = db;
        }

        public List<Adventurer> ReadAdventurers()
        {
            List<Adventurer> test = new List<Adventurer>();
            test.Add(new Adventurer("gup", Adventurer.ClassType.Mage));

            return test;
            return _db.Adventurers.ToList();
        }
    }
}
