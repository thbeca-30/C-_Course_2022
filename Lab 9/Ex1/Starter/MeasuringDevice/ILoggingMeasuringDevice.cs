using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    // TODO: Implement the ILoggingMeasuringDevice interface.
    public interface ILoggingMeasuringDevice : IMeasuringDevice {
        string GetLoggingFile();

    }
}
