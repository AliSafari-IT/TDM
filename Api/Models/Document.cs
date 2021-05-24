using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Document
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
