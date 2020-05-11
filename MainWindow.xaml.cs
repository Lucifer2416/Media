using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            libraryMembers.ItemsSource = Library.libraryMembers;

            libraryContents.ItemsSource = Library.media;
        }
        private void LentMedia_Click(object sender, RoutedEventArgs e)
        {


            if (libraryContents.SelectedItem != null && libraryMembers.SelectedItem != null)
            {
                LibraryMember libraryMember = (LibraryMember)libraryMembers.SelectedItem;
                Media media = (Media)libraryContents.SelectedItem;
                if (((Media)libraryContents.SelectedItem).available == true)
                {
                    LibraryMember.borrowHist.Add(media);
                    LibraryMember.currBorrow.Add(media);
                    Library.media.Remove(((Media)libraryContents.SelectedItem));
                    Library.media.Add(((Media)libraryContents.SelectedItem));
                    ((Media)libraryContents.SelectedItem).available = false;
                    ((Media)libraryContents.SelectedItem).libraryMember = libraryMember.name;
                    MessageBox.Show(libraryMember.name + " has lend the " + media.mediaType + " : " + media.title);
                    UpdateGrid();

                }
                else
                {
                    DisplayInfo("The Media Is currently unavailable");
                }
            }
            else
            {
                DisplayInfo("Select Name and Media");
            }
        }
        private void returnMedia_Click(object sender, RoutedEventArgs e)
        {

            Media media = (Media)libraryContents.SelectedItem;
            LibraryMember libraryMember = (LibraryMember)libraryMembers.SelectedItem;
            LibraryMember.currBorrow.Remove(media);
            if (libraryContents.SelectedItem != null && libraryMembers.SelectedItem != null)
            {
                if (((Media)libraryContents.SelectedItem).available == false && media.libraryMember == libraryMember.name)
                {
                    Library.media.Remove(((Media)libraryContents.SelectedItem));
                    ((Media)libraryContents.SelectedItem).available = true;
                    ((Media)libraryContents.SelectedItem).libraryMember = "";
                    Library.media.Remove(((Media)libraryContents.SelectedItem));
                    Library.media.Insert(0, (((Media)libraryContents.SelectedItem)));
                    UpdateGrid();
                }
                else
                {
                    DisplayInfo("The Media Is available");
                }
            }
            else
            {
                DisplayInfo("Select Name of the member to return");
            }

        }

        private void UpdateGrid()
        {
            libraryContents.UnselectAllCells();
            libraryMembers.UnselectAllCells();
            libraryContents.ItemsSource = null;
            libraryContents.ItemsSource = Library.media;

        }

        private void memberInfo_Click(object sender, RoutedEventArgs e)
        {
            string name = "";

            string title = "";
            string type = "";

            foreach (Media m in LibraryMember.borrowHist)
            {
                name = m.libraryMember;
                title = m.title;
                type = m.mediaType;
                DisplayInfo(Environment.NewLine + "Name :" + name + Environment.NewLine + " Title : " + title + Environment.NewLine + "Type : " + type + Environment.NewLine);
            }

            foreach (Media m in LibraryMember.currBorrow)
            {
                name = m.libraryMember;
                title = m.title;
                type = m.mediaType;
                DisplayInfo(Environment.NewLine + "Name :" + name + Environment.NewLine + " Title : " + title + Environment.NewLine + "Type : " + type + Environment.NewLine);
            }
        }

        private void mediaInfo_Click(object sender, RoutedEventArgs e)
        {
            if (libraryContents.SelectedCells.Count() > 0)
            {
                Media media = (Media)libraryContents.SelectedItem;


                foreach (Media m in LibraryMember.currBorrow)
                {


                }
            }
            else
            {
                DisplayInfo("Select A Media");
            }

        }
        private void DisplayInfo(string message)
        {
            MessageBox.Show(message);
        }

    }
}

