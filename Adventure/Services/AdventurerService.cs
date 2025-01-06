using Adventure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Adventure.Services
{
    public interface IAdventurerService
    {
        public List<Adventurer> ReadAdventurers();
    }
    public class AdventurerService : IAdventurerService
    {
        private IAdventurerRepository _repository;

        public AdventurerService(IAdventurerRepository repository)
        {
            _repository = repository;
        }

        public List<Adventurer> ReadAdventurers()
        {
            return _repository.ReadAdventurers();
        }
    }
}
