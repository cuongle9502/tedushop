using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Moders
{
    public class ApplicationRole 
    {
        public ApplicationRole() : base()
        {

        }
        [StringLength(250)]
        public string Description { set; get; }
    }
}
