using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public enum Sex
    {
        [Display(Name ="男")]
        male,
        [Display(Name ="女")]
        female
    }
    public class CommonVar
    {
    }
}
