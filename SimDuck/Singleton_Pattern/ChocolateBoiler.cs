using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.Singleton_Pattern
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler uniqueInstance;

        // Java의 synchronized 와 같다고 함.
        //[MethodImpl(MethodImplOptions.Synchronized)]    // get instance의 속도가 중요하지 않으면 그냥 둔다.
        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void fill()
        {
            if (isEmpty())  // 보일러가 비어 있을 때만 재료를 넣는다.
            {
                empty = false;
                boiled = false;
            }
            // 보일러에 우유 / 초콜릿을 혼합한 재료를 집어넣음
        }
        // 보일러가 가득 차있으면 재료를 다음 단계로 넘기고 비움상태를 true로 돌려 놓는다.
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                // 끓인 재료를 다음 단계로 넘김
                empty = true; 
            }
        }

        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                // 재료를 끓임
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}
