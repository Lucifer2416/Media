using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Movie : Media
    {
      
        //Movie Constructor
        public float runTime { get; private set; }
        
        public Movie(float Runtime,string Title,string type):base(Title,"Movie")
        {
            runTime = Runtime;
           


        }

        //Media info
        public override string MediaInfo()
        {
            return base.MediaInfo()+""+runTime;
        }
    }
}
