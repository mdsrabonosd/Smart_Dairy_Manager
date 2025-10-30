using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.ViewModel
{
    public class VaccineViewModel
    {
    
        public int VaccineId { get; set; }
        public string? VaccineName { get; set; }
        public int? VaccinePrice { get; set; }
        public int VaccineAgeMonth { get; set; }
        public int VaccineAgeDay { get; set; }
        public string? VaccineNotes { get; set; }
    }
}
