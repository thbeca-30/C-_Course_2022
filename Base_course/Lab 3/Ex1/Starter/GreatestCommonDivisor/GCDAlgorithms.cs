using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
    static class GCDAlgorithms
    {
        // TODO Exercise 1, Task 2
        // Add FindGCDEuclid method
        public static int FindGCDEuclid(int a, int b){
            if (a == 0) {
                return b;
            }
            while (b != 0){
                if (a > b){
                    a -= b;
                }else{
                    b -= a;
                }
            }
            return a;
        }

    }
}
