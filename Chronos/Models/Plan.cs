using System;
using Chronos.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chronos.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime RenewalDate { get; set; }
        public decimal? ExpectedBudget { get; set; }

        public int RecurrencePlanId { get; set; }
        [ForeignKey("RecurrencePlanId")]
        public RecurrencePlan ReccurencePlan { get; set; }

    }
}