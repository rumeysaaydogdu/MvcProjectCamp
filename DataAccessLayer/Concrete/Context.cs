using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext  // Context sınıfı buraya yazılmış olan dbset türündeki property leri sql e birer tablo olarak yansıtacak
    {
        public DbSet<About> Abouts { get; set; }  // About sınıfın ismi, Abouts ise veri tabanındaki tablonun ismi
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
