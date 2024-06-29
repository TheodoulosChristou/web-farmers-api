using Microsoft.EntityFrameworkCore;
using web_farmers_api.Application.Interface.Repositories;
using web_farmers_api.Infrastructure.Data;


    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ProjectDbContext _dbContext;

        public GenericRepository(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<T> Add(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }

