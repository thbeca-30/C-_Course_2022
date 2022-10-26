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

        // TODO: Add an indexer to enable access to individual bits in the control register.
    }
}
