using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>  //T bizim türümüz (type). SEn entity den neyi gönderirsen category, writers falan o olur. her biri için ayrı bir interface yazmamak için
    {
        List<T> List();
        void Delete(T p);
        void Insert(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);

    }
}
