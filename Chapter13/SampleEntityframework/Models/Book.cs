using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityframework.Models {
    public class Book {
        public int id {  get; set; }
        public string title { get; set; }
        public int publisheaYear { get; set; }
        public virtual Author Authoe { get; set; }
    }
}
