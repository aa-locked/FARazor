using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RazorApplicationFA.Model.Doamin
{
    public class TFAMtrlGrp
    {
        [Key]
        public int FAMtrlGrpId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "No Of Char Cannot Be More Than 20")]
        [DisplayName("Short Description ")]
        public string GrpShortDesc { get; set; }
        [Required]
        [StringLength(200)]
        [DisplayName("Description(200 Char)")]
        public string GrpDesc { get; set; }
        public bool ActStatus { get; set; } = true;
        public int AddedBy { get; set; } = 123;
        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
