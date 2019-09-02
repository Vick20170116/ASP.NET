using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore2.Models
{
    public interface IDiSample
    {
        int Id { get; }
    }

    public interface IDiSampleTransient : IDiSample { }
    public interface IDiSampleScoped : IDiSample { }
    public interface IDiSampleSingleton : IDiSample { }

    public class DiSample : IDiSampleTransient, IDiSampleScoped, IDiSampleSingleton
    {
        private static int _counter;
        private int _id;

        public DiSample()
        {
            _id = ++_counter;
        }

        public int Id => _id;
    }
}
