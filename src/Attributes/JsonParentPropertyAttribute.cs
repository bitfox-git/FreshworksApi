﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Attributes
{
    [AttributeUsage(AttributeTargets.Property,  AllowMultiple = true)]
    public class JsonParentPropertyAttribute: Attribute
    { }
}
