﻿using Flatmate.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flatmate.Models.EntityModels
{
    public class RecurringBill
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        [CurrencyValidation(ErrorMessage = "Value must be floating value with none decimal places or one or two decimal places preceded by a comma")]
        public double Value { get; set; }
        public Frequency Frequency { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? LastOccurenceDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ICollection<RecurringBillPerTeamMember> RecipientsCollection { get; set; }
    }
}
