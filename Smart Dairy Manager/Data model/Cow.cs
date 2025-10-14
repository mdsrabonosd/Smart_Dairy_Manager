using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class Cow
    {
        [Key]
        public int CowId { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
   
        public  string? Breed { get; set; }
        public double? Price { get; set; } = 100;
        public double Weight { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
