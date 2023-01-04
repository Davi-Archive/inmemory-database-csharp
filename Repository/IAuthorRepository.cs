using InMemory.Entities;

namespace InMemory.Repository
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
    }
}
