using RESTAPIPersonalBudget.Model.Base;

namespace RESTAPIPersonalBudget.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T FindByID(long id);

        List<T> FindAll();

        T Update(T item);

        T Delete(long id);
    }
}