using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    { 
        [Key]
        public int  ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //Content Yazar
        //Content Başlık     diğer tablolarla bağlantılı
        
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; }  //soru işareti nullable type dan geliyor hem headingID hem de writerID olduğu için iki foreign key sorun oldu
        public virtual Writer Writer { get; set; }
    }
}
