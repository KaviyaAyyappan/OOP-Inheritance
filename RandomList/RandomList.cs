using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList:List<string>
    {
        List<string> data = new List<string>();
        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0,Count);
            string data1 = this[index];
            this.RemoveAt(index);
            return data1;
                }
  
    



    }
}
