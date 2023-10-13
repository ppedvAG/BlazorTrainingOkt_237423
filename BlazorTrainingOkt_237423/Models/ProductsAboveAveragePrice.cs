using System;
using System.Collections.Generic;

namespace BlazorTrainingOkt_237423.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
