using System;
using System.Collections.Generic;
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

namespace Visual_Novel_Manager.View
{
    /// <summary>
    /// Interaction logic for UserVnList.xaml
    /// </summary>
    public partial class UserVnList : UserControl
    {
        public UserVnList()
        {
            InitializeComponent();
            DataContext = StaticClass.UserVnListViewModelStatic;
        }


        private void LoginBtn_OnClick(object sender, RoutedEventArgs e)
        {
            StaticClass.UserVnListViewModelStatic.SetEncPassCommand.Execute(passwordTxt.SecurePassword);
            StaticClass.UserVnListViewModelStatic.GetUserVnListCommand.Execute(null);
        }

        private void VnListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StaticClass.UserVnListViewModelStatic.BindUserVnCommand.Execute(null);
        }
    }
}
