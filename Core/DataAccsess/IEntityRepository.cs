using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccsess
{
    public interface IEntityRepository<T> where T : class, IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);  // boş dönerse de hepsini getir 
        T Get(Expression<Func<T, bool>> filter); //filtrelemeye göre listele
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
