using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _3._1.Models;

namespace _3._1.Data
{
    public class _3_1Context : DbContext
    {
        public _3_1Context(DbContextOptions<_3_1Context> options)
            : base(options)
        {
        }

        public DbSet<_3._1.Models.Operation> Operation { get; set; }

        public DbSet<_3._1.Models.Deal> Deal { get; set; }

        public DbSet<_3._1.Models.SubAccount> SubAccount { get; set; }

        public DbSet<_3._1.Models.AccountPlan> AccountPlan { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>().HasData(
                new Operation[]
                {
                new Operation
                {
                    ID = 1,
                    DealID = 1,
                    SubAccountID = 1,
                    Number = 2,
                    Data = new DateTime(2020, 06, 12),
                    Type = "3",
                    Sum = 2 ,
                    SaldoInput = 1,
                    SaldoOutput = 2
                },
                new Operation
                {
                    ID = 2,
                    DealID =2,
                    SubAccountID = 2,
                    Number = 1,
                    Data = new DateTime(2020, 12, 12),
                    Type = "1",
                    Sum = 1 ,
                    SaldoInput = 3,
                    SaldoOutput = 1
                },
                new Operation
                {
                    ID = 11,
                    DealID = 3,
                    SubAccountID = 3,
                    Number = 22,
                    Data = new DateTime(2020, 09, 12),
                    Type = "30",
                    Sum = 20 ,
                    SaldoInput = 11,
                    SaldoOutput = 22
                },
                new Operation
                {
                    ID = 22,
                    DealID = 4,
                    SubAccountID = 4,
                    Number = 15,
                    Data = new DateTime(2020, 12, 11),
                    Type = "154",
                    Sum = 10 ,
                    SaldoInput = 32,
                    SaldoOutput = 11
                },
                new Operation
                {
                    ID = 13,
                    DealID = 5,
                    SubAccountID = 5,
                    Number = 5,
                    Data = new DateTime(2020, 01, 12),
                    Type = "1643",
                    Sum = 16 ,
                    SaldoInput = 17,
                    SaldoOutput = 18
                },
                new Operation
                {
                    ID = 200,
                    DealID = 6,
                    SubAccountID = 6,
                    Number = 112,
                    Data = new DateTime(2020, 03, 22),
                    Type = "1112",
                    Sum = 167,
                    SaldoInput = 321,
                    SaldoOutput = 143
                },
                new Operation
                {
                    ID = 666,
                    DealID = 7,
                    SubAccountID = 7,
                    Number = 777,
                    Data = new DateTime(2020, 03, 13),
                    Type = "666",
                    Sum = 777 ,
                    SaldoInput = 666,
                    SaldoOutput = 777
                },
                });
            modelBuilder.Entity<Deal>().HasData(
            new Deal[]
            {
                new Deal
                {
                    ID = 1,
                    Agreement = 2,
                    Tiker = "1",
                    Order = 2,
                    Number = 2,
                    Date = new DateTime(2020, 07, 12),
                    Quantity = 3,
                    Price = 2 ,
                    TotalCost = 1,
                    Trader = 2,
                    Commission = 1
                },
                new Deal
                {
                    ID = 2,
                    Agreement = 1,
                    Tiker = "3",
                    Order = 1,
                    Number = 1,
                    Date = new DateTime(2020, 05, 12),
                    Quantity = 1,
                    Price = 1 ,
                    TotalCost = 2,
                    Trader = 1,
                    Commission = 2
                },
                new Deal
                {
                    ID = 3,
                    Agreement = 22,
                    Tiker = "111",
                    Order = 23,
                    Number = 24,
                    Date = new DateTime(2020, 06, 22),
                    Quantity = 30,
                    Price = 25,
                    TotalCost = 17,
                    Trader = 26,
                    Commission = 14
                },
                new Deal
                {
                    ID = 4,
                    Agreement = 22,
                    Tiker = "13",
                    Order = 24,
                    Number = 25,
                    Date = new DateTime(2020, 07, 16),
                    Quantity = 7,
                    Price = 28 ,
                    TotalCost = 19,
                    Trader = 200,
                    Commission = 101
                },
                new Deal
                {
                    ID = 5,
                    Agreement = 202,
                    Tiker = "103",
                    Order = 204,
                    Number = 205,
                    Date = new DateTime(2020, 07, 06),
                    Quantity = 307,
                    Price = 208,
                    TotalCost = 109,
                    Trader = 200,
                    Commission = 111
                },
                new Deal
                {
                    ID = 6,
                    Agreement = 63,
                    Tiker = "163",
                    Order = 262,
                    Number = 231,
                    Date = new DateTime(2020, 05, 29),
                    Quantity = 27,
                    Price = 267 ,
                    TotalCost = 2222,
                    Trader = 666,
                    Commission = 777
                },
                new Deal
                {
                    ID =7,
                    Agreement = 777,
                    Tiker = "7676",
                    Order = 666,
                    Number = 777,
                    Date = new DateTime(2020, 02, 23),
                    Quantity = 666,
                    Price = 777 ,
                    TotalCost = 666,
                    Trader = 777,
                    Commission = 666
                },
            });
            modelBuilder.Entity<SubAccount>().HasData(
            new SubAccount[]
            {
                new SubAccount
                {
                    ID = 1,
                    AccountPlanID =1 ,
                    Name = "1",
                    Number = 2,
                   
                },
                new SubAccount
                {
                    ID = 2,
                    AccountPlanID = 2,
                    Name = "2",
                    Number = 1,

                },
                new SubAccount
                {
                    ID = 3,
                    AccountPlanID = 3,
                    Name = "3",
                    Number = 3,

                },
                new SubAccount
                {
                    ID = 4,
                    AccountPlanID =4,
                    Name = "4",
                    Number = 4,

                },
                new SubAccount
                {
                    ID = 5,
                    AccountPlanID = 5,
                    Name = "5",
                    Number = 5,

                },
                new SubAccount
                {
                    ID = 6,
                    AccountPlanID = 6,
                    Name = "6",
                    Number = 6,

                },
                new SubAccount
                {
                    ID = 7,
                    AccountPlanID = 7,
                    Name = "7",
                    Number = 7,

                },
            });
            modelBuilder.Entity<AccountPlan>().HasData(
            new AccountPlan[]
            {
                new AccountPlan
                {
                    ID = 1,
                    Name = "2",
                    Type = "3",
                    Number = 3
                },
                new AccountPlan
                {
                    ID = 2,
                    Name = "3",
                    Type = "4",
                    Number = 2
                },
                new AccountPlan
                {
                    ID = 3,
                    Name = "4",
                    Type = "5",
                    Number = 4
                },
                new AccountPlan
                {
                    ID = 4,
                    Name = "5",
                    Type = "6",
                    Number = 5
                },
                new AccountPlan
                {
                    ID = 5,
                    Name = "6",
                    Type = "7",
                    Number = 6
                },
                new AccountPlan
                {
                    ID = 6,
                    Name = "7",
                    Type = "8",
                    Number = 7
                },
                new AccountPlan
                {
                    ID = 7,
                    Name = "8",
                    Type = "9",
                    Number = 8
                },
            });
        }
    }
}
