using System;
using System.Collections.Generic;

namespace CarLibrary.Entities;

public partial class CreditRisk
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
