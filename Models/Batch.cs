﻿using System;
using System.Collections.Generic;

namespace ConsoleApp10.Models;

public partial class Batch
{
    public int Id { get; set; }

    public string? Batch1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Timing { get; set; }
}
