using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDay
{
    class Greeting
    {
        public void Method()
        {
            int hourThis = DateTime.Now.Hour;
            if(hourThis >= 9 && hourThis < 12)
            {
                Console.WriteLine(DateTime.Now + " Good morning guys!");
            }
            else if(hourThis >= 12 && hourThis < 15)
            {
                Console.WriteLine(DateTime.Now + " Good day guys!");
            }
            else if (hourThis >= 15 && hourThis < 22)
            {
                Console.WriteLine(DateTime.Now + " Good evening guys!");
            }
            else if (hourThis >= 22)
            {
                Console.WriteLine(DateTime.Now + " Good nigth guys!");
            }
        }
       
        
        
         
    }
}
