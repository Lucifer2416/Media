﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    abstract class Media
    {
        public string title { get; private set; }
        public string mediaType { get; private set; }
        public int serialNumber { get; private set; }
        public int timesLent { get; private set; }
        public bool available { get; set; } = true;
        public string libraryMember { get;  set; }
        public Media(string title,string type)
        {
            this.title = title;
            mediaType = type;
        }

//Initialize Variables
       public virtual string   MediaInfo()
        {
            return title + "" + mediaType + "   " + serialNumber + "   " + available + "   " + timesLent;
        }

    }
}
