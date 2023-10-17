using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_12._3 {
    internal class Program {
        static void Main(string[] args) {
            MyDerivedClass derivedObject = new MyDerivedClass("phrase");

            Console.WriteLine(derivedObject.GetString());
        }

        public class MyClass {
            private String myString;

            public MyClass(String str) {
                myString = str;
            }

            public virtual String GetString() {
                return myString;
            }

            public String MyString {
                get { 
                    return myString; 
                }
                
            }
        }

        public class MyDerivedClass : MyClass {

            public MyDerivedClass(String str) : base(str) { }

            public override String GetString() {
                return base.GetString() + " (output from the derived class)";
            }

        }
    }
}
