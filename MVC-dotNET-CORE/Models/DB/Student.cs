using System;
using System.Collections.Generic;

namespace MVC_dotNET_CORE.Models.DB;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;
}
