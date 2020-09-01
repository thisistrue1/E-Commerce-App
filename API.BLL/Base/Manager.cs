using System.Collections.Generic;
using System.Threading.Tasks;
using API.Abstractions.BLL.Base;
using API.Abstractions.Repository.Base;

namespace API.BLL.Base
{
    public class Manager<T> : IManager<T> where T : class
    {
        public IRepository<T> _repo;
        public Manager(IRepository<T> repo)
        {
            _repo = repo;
        }

        public virtual async Task<bool> Add(T entity)
        {
            return await _repo.Add(entity);
        }

        public virtual async Task<IReadOnlyList<T>> GetAll()
        {
            return await _repo.GetAll();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public virtual async Task<bool> Remove(T entity)
        {
            return await _repo.Remove(entity);
        }

        public virtual async Task<bool> Update(T entity)
        {
            return await _repo.Update(entity);
        }
    }
}