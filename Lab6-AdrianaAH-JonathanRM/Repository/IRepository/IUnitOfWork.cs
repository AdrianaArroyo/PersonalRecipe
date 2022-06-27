namespace Lab6_AdrianaAH_JonathanRM.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        void Save();

    }
}
