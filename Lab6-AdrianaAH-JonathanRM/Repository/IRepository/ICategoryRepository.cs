using Lab6_AdrianaAH_JonathanRM.Models;

namespace Lab6_AdrianaAH_JonathanRM.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
