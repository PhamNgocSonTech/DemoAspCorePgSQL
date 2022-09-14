using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
        [Table("Actor")]
        public class Actor
        {
            public int Id { get; set; }
            [Required]
            public string Fullname { get; set; }
        }
    }
