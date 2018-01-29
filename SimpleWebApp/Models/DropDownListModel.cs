using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public class DropDownListModel
    {
        public DropDownListModel()
        {
            Options = new List<string>();
        }

        [Required]
        public string NewOption { get; set; }
        public List<string> Options { get; set; }
    }
}
