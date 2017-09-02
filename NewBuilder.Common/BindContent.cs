﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    class BindContent : Base<BindContent>
    {
        string Content { get; set; }
        int Index { get; }
        Guid BindId { get; }
        TimeSpan Delay { get; set; }
    }
}
