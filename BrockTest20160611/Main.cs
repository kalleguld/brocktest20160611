using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BrockTest20160611
{
    class Main
    {

        public void main()
        {
            //Not a real main method, can't be bothered to change it now

            object myNormalObject = new object();
            //myNormalObject.a = 5;
            //compile-fejl, object har ikke en a-property

            dynamic myDynamicObject = new object();
            myDynamicObject.a = 5;
            //vi har sagt at vi ved bedre end compileren, så den brokker sig ikke.
            //men vi får stadig runtime-fejl


            MySuperClass mySuperClassObject = new MySuperClass();
            //mySuperClassObject.a = 5;
            //MySuperClass har ikke en a-property

            dynamic myDynamicSuperClassObject = new MySuperClass();
            myDynamicSuperClassObject.a = 5;
            //endelig virker det. 

        }
    }
}
