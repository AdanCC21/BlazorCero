using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class E_Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? Alias { get; set; }

    }
}
