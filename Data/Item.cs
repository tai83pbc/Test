using System;
using System.Collections.Generic;

namespace LearnWeb.Data;

public partial class Item
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Desciption { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }
}
