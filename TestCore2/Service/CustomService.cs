using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCore2.Models;

namespace TestCore2.Service
{
    public class CustomService
    {
        public IDiSample Transient { get; private set; }
        public IDiSample Scoped { get; private set; }
        public IDiSample Singleton { get; private set; }

        public CustomService(IDiSampleTransient transient,
            IDiSampleScoped scoped,
            IDiSampleSingleton singleton)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
        }
    }
}
