using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public bool Status { get; set; }
}
