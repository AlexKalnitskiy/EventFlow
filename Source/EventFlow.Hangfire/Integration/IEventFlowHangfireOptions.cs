﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Hangfire.Integration
{
    public interface IEventFlowHangfireOptions
    {
        IEventFlowHangfireOptions UseQueueName(string queueName);
    }
}
