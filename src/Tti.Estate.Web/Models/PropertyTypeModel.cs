using System.ComponentModel.DataAnnotations;

namespace Tti.Estate.Web.Models
{
    public enum PropertyTypeModel
    {
        [Display(Name = "Flat")]
        Flat = 0,

        [Display(Name = "House")]
        House,

        [Display(Name = "Land")]
        Land,

        [Display(Name = "Commercial")]
        Commercial
    }
}
