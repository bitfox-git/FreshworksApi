using System;
using System.Collections.Generic;
using System.Text;

namespace Freshworks.CRM.Client.Selectors
{
    public interface ISelector<ReturnType>
    {
        List<ReturnType> Items { get; }
    }
}
