﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Viewings.Commands
{
    public class RejectViewingRequestCommand
    {
        public int PropertyId { get; set; }
        public int ViewingId { get; set; }
    }
}