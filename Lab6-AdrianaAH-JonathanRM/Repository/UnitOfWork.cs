using Lab6_AdrianaAH_JonathanRM.Data;
using Lab6_AdrianaAH_JonathanRM.Repository.IRepository;

namespace Lab6_AdrianaAH_JonathanRM.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
