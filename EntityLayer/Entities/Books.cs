using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        [StringLength(50)]
        public string BookName { get; set; }
        public int BookPage { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }  
    }
}
