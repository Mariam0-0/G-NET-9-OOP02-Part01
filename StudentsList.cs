using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP02_Part01
{
    internal class StudentsList
    {
        private string[] students;

        public string this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }

        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == name)
                        return i;
                }
                return -1;
            }
        }
    }
}
