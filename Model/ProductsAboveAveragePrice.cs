using System;
using System.Collections.Generic;

namespace ConsoleApp1.Model;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
