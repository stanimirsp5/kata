using System;
using System.Collections.Generic;

namespace CarLibrary.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
