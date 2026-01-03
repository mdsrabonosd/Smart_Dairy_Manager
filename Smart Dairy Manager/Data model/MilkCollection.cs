using System;
using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class MilkCollection
    {
        [Key]
        public int MilkCollectionId { get; set; }

        [Required(ErrorMessage = "Cow is required")]
        public int CowId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Morning milk yield is required")]
        [Range(0, 100, ErrorMessage = "Morning yield must be between 0 and 100 liters")]
        public double MorningYield { get; set; }

        [Required(ErrorMessage = "Evening milk yield is required")]
        [Range(0, 100, ErrorMessage = "Evening yield must be between 0 and 100 liters")]
        public double EveningYield { get; set; }

        [Range(0, 200, ErrorMessage = "Total yield must be between 0 and 200 liters")]
        public double TotalYield { get; set; }
    }
}
