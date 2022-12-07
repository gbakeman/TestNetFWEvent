using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentCSLib
{
    public class EventGenerator
    {
        public event EventHandler SomethingHappened;

        public void SampleMethod()
        {
            SomethingHappened?.Invoke(this, new EventArgs());
        }

        //public void OverriddenMethod()
        //{
        //    return;
        //}
    }
}
