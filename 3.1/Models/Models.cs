using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace _3._1.Models
{
    public class Operation
    {
        public int ID { get; set; }

        [Required]
        public int DealID { get; set; }
        public int SubAccountID { get; set; } 
        public int Number { get; set; }
        public DateTime Data { get; set; }
        public string Type { get; set; }
        public float Sum { get; set; }
        public float SaldoInput { get; set; }
        public float SaldoOutput { get; set; }
    }
    public class Deal
    {
        public int ID { get; set; }
        public float Agreement { get; set; }
        public string Tiker { get; set; }
        public int Order { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int TotalCost { get; set; }
        public int Trader { get; set; }
        public float Commission { get; set; }
    }
    public class SubAccount 
    {
        public int ID { get; set; }
        public int AccountPlanID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
    public class AccountPlan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type{ get; set; }
        public int Number { get; set; }
    }
}

