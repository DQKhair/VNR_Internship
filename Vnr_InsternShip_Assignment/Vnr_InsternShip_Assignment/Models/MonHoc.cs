﻿using System;
using System.Collections.Generic;

namespace Vnr_InsternShip_Assignment.Models;

public partial class MonHoc
{
    public int Id { get; set; }

    public string? TenMonHoc { get; set; }

    public string? MoTa { get; set; }

    public int KhoaHocId { get; set; }

    public virtual KhoaHoc KhoaHoc { get; set; } = null!;
}
