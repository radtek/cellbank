﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class WSSGGroupPolicyException:Exception
    {
        public WSSGGroupPolicyException(string msg)
            : base(msg)
        {
        }
    }
}
