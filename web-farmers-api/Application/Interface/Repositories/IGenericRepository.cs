namespace web_farmers_api.Application.Interface.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();

        Task<T> Add(T entity);

        Task Delete(T entity);

        Task Update(T entity);
    }
}
