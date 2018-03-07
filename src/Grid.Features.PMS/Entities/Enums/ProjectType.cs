﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid.Features.PMS.Entities.Enums
{
    public enum ProjectType
    {
        [Description("Internal")]
        Internal,
        [Description("Client")]
        Client,
        [Description("Research")]
        Research,
        [Description("Off Hours")]
        OffHours
    }
}
