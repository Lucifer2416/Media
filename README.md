# Media
Download all the files.
Have the lastest version of visual studio to run this project successfully.
Open the "sln" to access the entire project in Visual Studio.
##Overview 
1)	An abstract Media class that contains the following properties: a string title, a string media type, a unique int serial number, an int for number of times lent, a boolean that indicates whether it is currently borrowed or available, and a string that represents the name of the library member currently borrowing the piece of media
2)	A Book class that inherits from Media and has a page count property.
3)	A Magazine class that inherits from Book and has an issue number property.
4)	A Movie class that inherits from Media and has a run time property.
5)	A LibraryMember class that contains a string name property.
6)	A static Library class that contains a collection of all of its media and a list of all its members.
7)	A DataGrid of all media in the library that shows their title, type, whether they are available or lent out, and who is currently borrowing them.
10)	A DataGrid of all library members in the library that shows their names.
11)	The ability to lend out available media. When media is lent out, a LibraryMember must be selected, and then the media display reflects who is currently borrowing the media.
12)	The ability of returning media back.
13)	A popup that appears whenever media is lent or brought back, which describes the process.
