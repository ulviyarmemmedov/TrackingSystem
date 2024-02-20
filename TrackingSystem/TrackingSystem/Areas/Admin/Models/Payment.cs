using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public decimal Amount { get; set; }

    public int Type { get; set; }

    public bool Status { get; set; }

    public virtual User User { get; set; } = null!;
}
