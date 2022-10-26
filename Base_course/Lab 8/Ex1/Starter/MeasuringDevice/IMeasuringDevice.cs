using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    public interface IMeasuringDevice {
        public decimal MetricValue() { return decimal; }
        public decimal ImperialValue() { return decimal;}
        public void StartCollecting() { }
        public void StopCollecting() { }
        public int[] GetRawData() { return int;}
    }
}
