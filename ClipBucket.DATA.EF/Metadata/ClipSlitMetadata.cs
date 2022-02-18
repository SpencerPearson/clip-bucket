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

        [Required(ErrorMessage = "* Required")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        
        [Display(Name = "Transcript")]
        public string TranscriptFile { get; set; }
        
        [Required(ErrorMessage = "* Required")]
        [Display(Name = "Submitted by: ")]
        public string SubmitterId { get; set; }

        [Display(Name = "Source")]
        public int SourceId { get; set; }

        [Display(Name = "Duration")]
        public int ClipLength { get; set; }
    }
    [MetadataType(typeof(ClipMetadata))]
    public partial class Clip
    {

    }

    #endregion

    #region Medium Metadata
    
    public class MeduimMetadata
    {
        [Display(Name = "Medium")]
        public string MediumName { get; set; }
    }

    [MetadataType(typeof(MeduimMetadata))]
    public partial class Medium { }
    #endregion

    #region Source Metadata

    public class SourceMetadata
    {
        [Display(Name = "Source")]
        [StringLength(50, ErrorMessage = "* Name must be 50 characters or less.")]
        public string SourceName { get; set; }

        [StringLength(80, ErrorMessage = "* Website must be 80 characters or less.")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Website { get; set; }
    }

    [MetadataType(typeof(SourceMetadata))]
    public partial class Source { }
    #endregion

    #region Speaker Metadata

    public class SpeakerMetadata
    {

        [Required(ErrorMessage = "* Required")]
        [StringLength(20, ErrorMessage = "* First Name must be 20 characters or less.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Required")]
        [StringLength(25, ErrorMessage = "* First Name must be 25 characters or less.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "* Company name must be 50 characters or less.")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Company { get; set; }

        [StringLength(80, ErrorMessage = "* Website must be 80 characters or less.")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Website { get; set; }

    }
    [MetadataType(typeof(SpeakerMetadata))]
    public partial class Speaker { }
    #endregion

    #region Submitter Detail Metadata
    public class SubmitterDetailMetadata
    {

        [Required(ErrorMessage = "* Required")]
        [StringLength(20, ErrorMessage = "* First name must be 20 characters or less.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Required")]
        [StringLength(30, ErrorMessage = "* First name must be 30 characters or less.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string ProfileImage { get; set; }

        [StringLength(80, ErrorMessage = "* Website must be 80 characters or less.")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Website { get; set; }

        [Display(Name = "Bio")]
        [UIHint("MultilineText")]
        [DisplayFormat(NullDisplayText = "No bio provided.")]
        public string SubmitterBio { get; set; }

        [DisplayFormat(NullDisplayText = "No node info provided.")]
        public string Pubkey { get; set; }
    }

    [MetadataType(typeof(SubmitterDetailMetadata))]
    public partial class SubmitterDetail { }
    #endregion

    #region Tag Metadata
    public class TagMetadata
    {

        [Required(ErrorMessage = "* Required")]
        [Display(Name = "Tag")]
        [StringLength(20, ErrorMessage = "* Tags must be 20 characters or less.")]
        public string TagName { get; set; }
    }

    [MetadataType(typeof(TagMetadata))]
    public partial class Tag { } 
    #endregion
}
