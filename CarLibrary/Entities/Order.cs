using System;
using System.Collections.Generic;

namespace CarLibrary.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int CarId { get; set; }

    public virtual Inventory Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
