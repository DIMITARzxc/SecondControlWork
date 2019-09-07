using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCW
{
     public class File
    {
        public string _takestr { get; set; }
        private string _name { get; set; }
        private string _size { get; set; }

       
        

        public  virtual void TakeString()
        {
           string  text = "Text:file.txt(6B);Some string content";
            MyList res = new MyList();
            string[] files = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for(int i=0; i<files.Length; i++)
            {
                string fileType = files[i].Split(':')[0].ToLower();
                switch (fileType)
                {
                    case "text":
                        
                        break;
                    case "movie":
                        break;
                    case "image":
                        break;
                    default:
                        break;
                }
            }

        }
       
    }
}
