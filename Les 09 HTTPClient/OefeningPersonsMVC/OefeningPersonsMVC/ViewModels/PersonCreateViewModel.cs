using OefeningPersonsMvc.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OefeningPersonsMVC.ViewModels;

public class PersonCreateViewModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }
}
