using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCW
{
    public class File
    {
        public  string Name { get; private set; }
        public string Extension { get; private set; }
        public  string Size { get; private set; }


        

        public virtual void TakeString(string input)
        {
            string[] splitInput = input.Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string NameExtStr = splitInput[0];
             Size = splitInput[1];

        }


        
    }
}
