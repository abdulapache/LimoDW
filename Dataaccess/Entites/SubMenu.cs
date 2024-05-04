using System;
using System.Collections.Generic;

namespace Dataaccess.Entites;

public partial class SubMenu
{
    public int Id { get; set; }

    public string? SubMenuName { get; set; }

    public string? SubMenuDescription { get; set; }

    public int? MenuId { get; set; }
}
