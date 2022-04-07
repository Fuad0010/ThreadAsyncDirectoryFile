using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Models
{
    internal class Status
    {
        private int _id;
        public string Title;
        public string Content;
        public int Id 
        { 
            get 
            { 
                return _id; 
            }
            set 
            {
                _id = value; 
            }
        }


    }
}
