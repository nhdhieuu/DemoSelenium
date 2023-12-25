using System.Collections.Generic;

namespace SeleniumWPF
{
    public class Order 
    {
        public string Invoice {get;set;}
        public Customer Customer {get;set;}
        public string Date {get;set;}
        public List<ItemTransaction> ItemTransactions {get;set;}
        public List<DealTransaction> DealTransactions {get;set;}
        public decimal Total {get;set;}
        public Cash Cash {get;set;}
        public decimal GrossTotal {get;set;}
    }

    public class Customer 
    {
        public string Address {get;set;}
        public string Phone {get;set;}
    }

    public class ItemTransaction
    {
        public Item Item {get;set;}
        public int Quantity {get;set;}
        public decimal Total {get;set;}
    }

    public class DealTransaction
    {
        public Deal Deal {get;set;}
        public int Quantity {get;set;}
        public decimal Total {get;set;}
    }

    public class Deal
    {
        public string Name {get;set;}
        public List<DealItem> DealItems {get;set;}
    }

    public class DealItem 
    {
        public Item Item {get;set;}
        public int Quantity {get;set;}
    }

    public class Item
    {
        public string Name {get;set;}
    }

    public class Cash
    {
        public decimal Discount {get;set;}
    }


    public class Shop
    {
        public string Address {get;set;}
        public string Phone1 {get;set;}
        public string Phone2 {get;set;}
    }
}