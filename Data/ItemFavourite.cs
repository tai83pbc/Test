using System;
using System.Collections.Generic;

namespace LearnWeb.Data;

public partial class ItemFavourite
{
    public int Id { get; set; }

    public int? IdItem { get; set; }

    public int? Good { get; set; }
}
