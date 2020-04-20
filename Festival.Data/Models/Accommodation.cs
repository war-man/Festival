﻿namespace Festival.Data.Models
{
    public class Accommodation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public float Distance { get; set; }
        public Image Image { get; set; }
        public int? ImageID { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Address { get; set; }
    }
}
