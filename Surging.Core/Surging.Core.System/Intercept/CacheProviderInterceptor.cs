﻿using Surging.Core.ProxyGenerator.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Surging.Core.System.Intercept
{
    public class CacheProviderInterceptor : IInterceptor
    {
        public async Task Intercept(IInvocation invocation)
        {
             await invocation.Proceed();
             await Task.Run(()=> { });
        }
    }
}
