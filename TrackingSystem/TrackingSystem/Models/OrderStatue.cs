using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class OrderStatue
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
