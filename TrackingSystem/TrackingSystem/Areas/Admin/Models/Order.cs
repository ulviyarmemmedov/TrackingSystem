using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class Order
{
    public int Id { get; set; }

    public string CarFullName { get; set; } = null!;

    public int CustomerId { get; set; }

    public int StartCountryId { get; set; }

    public int DestinationCountryId { get; set; }

    public bool Status { get; set; }

    public int StatusId { get; set; }

    public int CompanyId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual User Company { get; set; } = null!;

    public virtual Country DestinationCountry { get; set; } = null!;

    public virtual ICollection<Point> Points { get; set; } = new List<Point>();

    public virtual Country StartCountry { get; set; } = null!;

    public virtual OrderStatue StatusNavigation { get; set; } = null!;
}
