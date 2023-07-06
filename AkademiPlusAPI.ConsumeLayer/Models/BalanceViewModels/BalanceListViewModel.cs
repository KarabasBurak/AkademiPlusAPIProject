namespace AkademiPlusAPI.ConsumeLayer.Models.BalanceViewModels
{
    public class BalanceListViewModel
    {
        public int BalanceID { get; set; }
        public string AccountNumber { get; set; }
        public decimal CustomerBalance { get; set; }
        public string Currency { get; set; }
    }
}
