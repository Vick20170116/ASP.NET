using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore1
{
    public interface IDiSample
    {
        int Id { get; }
    }

    public class DiSample : IDiSample
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
