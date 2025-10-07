using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class MeatProduction
    {
        [Key]
        public int MeatProductionId { get; set; }
        public int CowId { get; set; }
        public DateTime Date { get; set; }
        public double? CowWeight { get; set; }
      

    }
}
