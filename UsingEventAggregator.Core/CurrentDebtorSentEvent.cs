using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using DataBusinessLayer;

namespace UsingEventAggregator.Core
{
    public class CurrentDebtorSentEvent : PubSubEvent<Debtor>
    {
    }
}
