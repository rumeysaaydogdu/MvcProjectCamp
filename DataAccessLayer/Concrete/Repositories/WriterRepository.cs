using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;  //DbSet kullanmak için entitiy dahil etttik
        public void Delete(Writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            c.SaveChanges();
        }
    }
}

//delete --> Remove()
//update --> SaveChanges();
//insert --> Add();
//list --> ToList();