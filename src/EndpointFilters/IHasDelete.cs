﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public interface IHasDelete
    {
        long? ID { get; set; }

        void CatchDeleteExceptions();
    }
}