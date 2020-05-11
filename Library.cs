using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    static class Library
    {
        public static List<Media> media = new List<Media>()
        {
        new Book("Book One","Book",100),
        new Book("Book Two","Book",200),
        new Book("Book Three","Book",300),
        new Book("Book Four","Book",400),
        new Book("Book 5 ","Book",500),
        new Movie(5,"Fantastic One","Movie"),
        new Movie(5,"Fantastic Two","Movie"),
        new Movie(6,"Fantastic Three","Movie"),
        new Movie(7,"Fantastic Four","Movie"),
        new Movie(8,"Fantastic Five","Movie"),
        new Magazine("Time","Magazine",60),
        new Magazine("Time Two","Magazine",60),
        new Magazine("Time Three","Magazine",50),
        new Magazine("Time Four","Magazine",60),
        new Magazine("Time 5","Magazine",30)
        };

        public static  List<LibraryMember> libraryMembers = new List<LibraryMember>()
        {
        new LibraryMember("John"),
        new LibraryMember("James"),
        new LibraryMember("Jane"),
        new LibraryMember("Will"),
        new LibraryMember("Adams")
    };
    }
}
