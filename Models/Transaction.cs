using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } // "Income" or "Expense"

        [Required]
        public string Category { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Transaction Date")]
        public DateTime Date { get; set; }

        public string? Note { get; set; }
    }
}
