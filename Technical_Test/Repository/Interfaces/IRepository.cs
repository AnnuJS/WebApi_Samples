using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{

    public interface IRepository<TEntity> where TEntity : class
    {

        //Implementing only get operation at the moment
        IEnumerable<TEntity> GetAll(TEntity entity);
        TEntity Find(object Id);

        //void Add(TEntity entity);
        //void Update(TEntity entity);
        //void DeleteByID(object Id);


    }
}
