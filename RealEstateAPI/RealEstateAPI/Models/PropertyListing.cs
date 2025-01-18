using System;
using System.Collections.Generic;

namespace RealEstateAPI.Models;

public partial class PropertyListing
{
    public int Id { get; set; }

    public string? PropertyType { get; set; }

    public int? PropertyValue { get; set; }

    public string? PropertyInfo { get; set; }
}
