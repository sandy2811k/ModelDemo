﻿namespace ModelDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }//To allow null us ?
        public int Price { get; set; }
    }
}
