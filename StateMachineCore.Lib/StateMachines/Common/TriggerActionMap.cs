using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineCore.Lib
{
    public class TriggerActionMap : Dictionary<string, Action<TriggerActionArgs>>
    {
    }
}
