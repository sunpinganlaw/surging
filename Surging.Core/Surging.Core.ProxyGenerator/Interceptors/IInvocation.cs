﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Surging.Core.ProxyGenerator.Interceptors
{
   public  interface IInvocation
    {
        object Proxy { get; }
         
        string ServiceId { get; }

        string[] CacheKey { get;  }

        IDictionary<string, object> Arguments { get; }

        List<Attribute> Attributes { get; }

        Task Proceed();

        object ReturnValue { get; }

        void SetArgumentValue(int index, object value);
    }
}
