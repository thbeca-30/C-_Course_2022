using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlRegisterIndexing
{
    public struct ControlRegister
    {
        private int registerData;

        /// <summary>
        /// Enables direct access to the registerData field.
        /// </summary>
        public int RegisterData
        {
            get
            {
                return registerData;
            }
            set
            {
                registerData = value;
            }
        }

        /// <summary>
        /// Enables access to the binary representation of the data stored in the registerData field.
        /// </summary>
        /// <param name="index">Specifies which bit to set or get.</param>
        /// <returns>The bit from the binary string.</returns>
        public int this[int index]
        {
            get
            {
                bool isSet = (registerData & (1 << index)) != 0;
                return isSet ? 1 : 0;
            }

            set
            {
                if (value == 1) // turn the bit on if value is true; otherwise, turn it off
                    registerData |= (1 << index);
                else
                    registerData &= (0 << index);
            }
        }
    }
}
