using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListGroup : ContentPage
    {
        private List<UserList> _listOfUsers;
        public List<UserList> ListOfUsers { get { return _listOfUsers; } set { _listOfUsers = value; base.OnPropertyChanged(); } }


        public ListGroup()
        {
            InitializeComponent();
            var dList = new UserList()
            {
                new User() { FirstName = "Marcelo", LastName = "Cuellar" },
                new User() { FirstName = "Juan", LastName = "Saladino" },
                new User() { FirstName = "Cloy", LastName = "Clotilde" }
            };
            dList.Heading = "D";

            var bList = new UserList()
            {
                new User() { FirstName = "Diego", LastName = "Torres" }
            };
            bList.Heading = "B";

            var lList = new UserList()
            {
                new User() { FirstName = "Bob", LastName = "Patiño" }
            };
            lList.Heading = "L";

            var list = new List<UserList>()
            {
                dList,
                bList,
                lList
            };
            Console.WriteLine(list);
            ListOfUsers = list;
        }
    }
}
