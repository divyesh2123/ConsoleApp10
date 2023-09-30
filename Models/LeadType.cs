using System;
using System.Collections.Generic;

namespace ConsoleApp10.Models;

public partial class LeadType
{
    public int LeadTypeId { get; set; }

    public string? Type { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
