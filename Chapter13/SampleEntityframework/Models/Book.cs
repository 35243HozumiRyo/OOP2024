using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityframework.Models {
    public class Book {
        public int id {  get; set; }
        public int Id { get; internal set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(16)]
        public string publisher { get; set; }

        public int? PublishedYear { get; set; }
        public virtual Author Author { get; set; }
        public object Birthday { get; internal set; }
    }
}
