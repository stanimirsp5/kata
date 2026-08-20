using System;
using System.Collections.Generic;

namespace CarLibrary.Entities;

public partial class Make
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
