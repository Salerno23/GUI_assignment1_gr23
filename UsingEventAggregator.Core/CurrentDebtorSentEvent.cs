using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBusinessLayer;
using Prism.Events;

namespace UsingEventAggregator.Core
{
    public class CurrentDebtorSentEvent : PubSubEvent<Debtor>
    {
    }
}
