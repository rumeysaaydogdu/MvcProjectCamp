using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class // T değeri bir class olmalı. biz zaten T değerini entity olarak gönderiyoruz
    {
        Context c = new Context();
        DbSet<T> _object;  // objeye henüz bir değer ataması gerçekleşmedi. T hangi sınıfa karşılık geliyor bilmiyoruz

        public GenericRepository() //ctor + tab + tab yaptım kendisi getirdi. Constructor oluşturduk
        {
            _object = c.Set<T>();  // dışarıdan gönderilen entity neyse, object isimli file da o olacak burası sayesinde
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}

//delete --> Remove()
//update --> SaveChanges();
//insert --> Add();
//list --> ToList();