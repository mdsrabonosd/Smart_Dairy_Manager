using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }
        public string? VaccineName { get; set; }
        public int? VaccinePrice { get; set; }
        public int VaccineAgeMonth  { get; set; }
        public int VaccineAgeDay { get; set; }
        public string? VaccineNotes { get; set; }
    }
}
