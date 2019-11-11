using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonexample
{
    public class MySingleton
    {
        private static int instanceCounter = 0;
        private int instanceNo;

        public MySingleton()
        {
            instanceCounter++;
            instanceNo = instanceCounter;
        }

        public int getInstanceNo()
        {
            return instanceNo;
        }

        public static int getInstanceCount()
        {
            return instanceCounter;
        }
    }
}
