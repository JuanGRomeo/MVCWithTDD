using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithTDD.Model
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPost { get; protected set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}