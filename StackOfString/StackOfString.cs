using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfString
{
    class StackOfString
    {
        private List<string> data = new List<string>();
        public void Push(string item)
        {
            data.Add(item);
        }
        public string Pop()
        {
            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }
        public string peek()
        {
            return data[data.Count - 1];
        }
        public bool IsEmpty()
        {
            return data.Count == 0;
        }

               
        
            


    }
}
