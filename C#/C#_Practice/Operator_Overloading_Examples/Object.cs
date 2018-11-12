using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class TestObject
    {
        private int id;

        public TestObject()
        {
            this.id = 0;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public TestObject(int id)
        {
            this.id = id;
        }


        public void Display()
        {
            Console.WriteLine("ID: " + id);
        }

        public static TestObject operator +(TestObject lhs, TestObject rhs)
        {
            TestObject newObject = new TestObject(lhs.id + rhs.id);
            return newObject;
        }

        public static bool operator >(TestObject lhs, TestObject rhs)
        {
            if(lhs.id > rhs.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(TestObject lhs, TestObject rhs)
        {
            if (lhs.id < rhs.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
