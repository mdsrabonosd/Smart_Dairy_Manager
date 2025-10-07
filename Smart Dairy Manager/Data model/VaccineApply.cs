using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class VaccineApply
    {
        [Key]
        public int VaccineApplyId { get; set; }
        public int VaccineId { get; set; }
        public int CowId { get; set; }
        public double ApplyAmmount { get; set; }
        public double VaccineApplyMonth { get; set; }
        public double VaccineApplyDay { get; set; }
        public string? VaccineApplyNote { get; set; }


    }
}
