using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Message { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public int Likes { get; set; }

    }
}
