using System;
using System.Collections.Generic;

namespace CarLibrary.Entities;

public partial class InventoryWithMake
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public string Make { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string PetName { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
