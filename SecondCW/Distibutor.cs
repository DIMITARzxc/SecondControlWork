using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCW
{
     public class Distibutor
    {
        public string _takestr { get; set; }
        private string _name { get; set; }
        private string _size { get; set; }

        
        

        public  virtual void TakeString()
        {
            _takestr = "Text:file.txt(6B);Some string content";
            string[] substr = _takestr.Split(':');
            Console.WriteLine(substr[0]);
            if (substr[0] == "Text")
            {
                string[] namestr = _takestr.Split('(');
                Console.WriteLine(namestr[0]);
            }
            Console.ReadLine();

        }
       
    }
}
