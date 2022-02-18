using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClipBucket.DATA.EF
{
    #region Category Metadata
    public class CategoryMetadata
    {
        [Required(ErrorMessage = "* Required")]
        [StringLength(10, ErrorMessage = "* Category Name must be 10 characters or less.")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public List<Clip> Clips { get; set; }

    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category { }
    #endregion

    #region Clip Metadata
    public class ClipMetadata
    {

        [Required(ErrorMessage = "* Required")]
        [StringLength(80, ErrorMessage = "* Title must be 80 characters or less.")]
        [Display(Name = "Title")]
        public string ClipTitle { get; set; }

        
    }


    #endregion
}
