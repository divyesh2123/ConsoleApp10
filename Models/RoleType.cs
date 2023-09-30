using System;
using System.Collections.Generic;

namespace ConsoleApp10.Models;

public partial class RoleType
{
    public int Id { get; set; }

    public string? RoleType1 { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsActive { get; set; }
}
