using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class Repository<TEntity> : Interfaces.IRepository<TEntity> where TEntity : class
    {
        public TEntity Find(object Id)
        {
            throw new NotImplementedException(); 
        }

        public IEnumerable<TEntity> GetAll(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
