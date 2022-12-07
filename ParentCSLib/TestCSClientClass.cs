using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentCSLib
{
    internal class TestCSClientClass : EventGenerator
    {
        public void TestRaiseInheritedEvent()
        {
            //This is fine
            SampleMethod();

            //This is not.
            SomethingHappened?.Invoke(this, new EventArgs());
        }
    }
}
