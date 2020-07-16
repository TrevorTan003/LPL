using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LPL.ViewModels
{
    public class CreateRoleViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        [DisplayName("Role")]
        public string RoleName { get; set; }
    }
}
