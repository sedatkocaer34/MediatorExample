using System;

namespace MediatorExample.Domain.Domain
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(Guid ıd, string name, double price, int quantity)
        {
            Id = ıd;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
