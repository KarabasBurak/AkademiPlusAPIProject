﻿namespace AkademiPlusAPI.ConsumeLayer.Models.CustomerViewModels
{
    public class CustomerUpdateViewModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public string AccountNumber { get; set; }
    }
}
