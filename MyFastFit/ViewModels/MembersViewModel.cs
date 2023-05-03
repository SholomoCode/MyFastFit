using Microsoft.AspNetCore.Mvc.Rendering;
using MyFastFit.Models;
using System.ComponentModel.DataAnnotations;

namespace MyFastFit.ViewModels
{
    public class MembersViewModel
    {

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Shoe size is required.")]
        [Range(5.0, 14.0)]
        public string ShoeSize { get; set; }

        [Required(ErrorMessage = "Shoe type is required.")]
        public ShoeType ShoeType { get; set; }

        public List<SelectListItem> ShoeTypes { get; set; } = new List<SelectListItem>
        {

            new SelectListItem(ShoeType.Man.ToString(), ((int)ShoeType.Man).ToString()),
            new SelectListItem(ShoeType.Woman.ToString(), ((int)ShoeType.Woman).ToString())
        };

        public MembersViewModel(Members theMember)
        {

            Name = theMember.Name;
            ShoeSize = theMember.ShoeSize;
            ShoeType = theMember.ShoeType;
        }
        public MembersViewModel() { }
    }
}
