﻿using System;
using System.Collections.Generic;

namespace ConsoleApp10.Models;

public partial class PackageMasterDetailsInfo
{
    public int PackageMaterDetailsId { get; set; }

    public int? PackageMasterId { get; set; }

    public int? FessCopy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
