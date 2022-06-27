using Lab6_AdrianaAH_JonathanRM.Data;
using Lab6_AdrianaAH_JonathanRM.Models;
using Lab6_AdrianaAH_JonathanRM.Repository.IRepository;
using System.Linq.Expressions;

namespace Lab6_AdrianaAH_JonathanRM.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);

        }
    }
}
