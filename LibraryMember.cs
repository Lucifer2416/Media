using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class LibraryMember
    {
        public string name { get;   set ; }
        public LibraryMember(string libraryMember)
        {
            this.name = libraryMember;

        }
       
        
       public static  List<Media> currBorrow = new List<Media>();
       public  static List<Media> borrowHist = new List<Media>();

        public static string MemberInfo()
        {
            string s = "";
            foreach(Media m in borrowHist)
            {
                s = s + m.libraryMember+ " : "+m.mediaType+" : " +m.title;
            }
            return s ;
        }
    }
}
