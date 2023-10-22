using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_14 {
    internal class Program {
        static void Main(string[] args) {       

            IInterface myClass = new MyClass();
            IInterface myOtherClass = new MyOtherClass();

            myClass.myMethod();
            myOtherClass.myMethod();
        }


        public interface IInterface {
            void myMethod();
        }
        public class MyClass : IInterface {
            private string name = "Sarah";

            public void myMethod() {  
                Console.WriteLine(name); 
            }
        }

        public class MyOtherClass : IInterface {
            private string name = "Heather";

            public void myMethod() { 
                Console.WriteLine(name);  
            }
        }
    }
}
