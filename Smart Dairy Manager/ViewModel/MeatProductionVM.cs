namespace Smart_Dairy_Manager.ViewModel
{
    public class MeatProductionVM
    {
        public int MeatProductionId { get; set; }
        public int CowId { get; set; }
        public DateTime Date { get; set; }
        public double? CowWeight { get; set; }
    }
}
