using System;
using System.Collections.Generic;

namespace MVC_dotNET_CORE.Models.DB;

public partial class JasonPlaceholder
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;
}
