using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Adapter_Pattern
{
    public interface Turkey
    {
        public void gobble(); // 칠면조는 꽥꽥 안거리고 골골 거리는 소리
        public void fly();
    }
}
