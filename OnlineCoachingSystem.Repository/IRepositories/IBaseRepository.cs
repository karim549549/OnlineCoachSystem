using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.IRepositories
{
    public interface   IBaseRepository<Entity,Dto> 
        where Entity : class
        where Dto: class
    {
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<Entity> FindEntityAsync(Entity entity);
        Task<IEnumerable<Entity>> FindAllAsync(Expression<Func<Entity, bool>> criteria, int? skip, int? take,
            Expression<Func<Entity, object>> orderBy = null, string orderByDirection = MagicStrings.Ascending);
        Task<IEnumerable<Entity>> AsyncAddRange(IEnumerable<Entity> entities);
        IEnumerable<Entity> AsyncUpdateRange(IEnumerable<Entity> entities);
        void DeleteRange(IEnumerable<Entity> entities);
        void RangeAttack(IEnumerable<Entity> entities);
        Task<int> AsyncCount(Expression<Func<Entity, bool>> criteria);
    }
}
