using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Models;
using Microsoft.EntityFrameworkCore;

namespace Calculator
{
    public class HistoryContext : DbContext
    {
        public DbSet<Expression> Expressions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ULEHGHQ\SQLEXPRESS;Database=CalculateHistory;Integrated Security=True;");
        }
    }
}
