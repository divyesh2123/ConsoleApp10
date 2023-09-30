using System;
using System.Collections.Generic;

namespace ConsoleApp10.Models;

public partial class LeadSource
{
    public string? Source { get; set; }

    public int Id { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
