using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepositoryDal<T>
    {
        //CRUD
        //Type Name();

        List<T> List();

        void Insert(T p);
        void Delete(T p);
        void Update(T P);

        List<T> List(Expression<Func<T, bool>> filter);

    }
}
