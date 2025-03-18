using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class E_Major
    {
        public E_Major()
        {
            this.Name = "";
            this.Alias = "";
        }

        public E_Major(string name, string alias)
        {
            this.Name = name;
            this.Alias = alias;
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Alias { get; set; }
    }
}
