using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StressTest
{
    // TODO - Implement Material, CrossSection, and TestResult enumerations.
    // Add the Material, CrossSection and TestResult enumerations.
    public enum Material { 
        StainessSteel, Aluminum, ReinforcedConcerte, Composite, Titanium
    }

    public enum CrossSection { 
        IBeam, Box, ZShaped, CShaped
    }

    public enum TestResult { 
        Pass, Fail
    }
    
}
