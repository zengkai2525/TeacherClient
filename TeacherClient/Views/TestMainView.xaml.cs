using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeacherClient.Bussiness;
using TeacherClient.ViewModels;

namespace TeacherClient.Views
{
    /// <summary>
    /// TestMainView.xaml 的交互逻辑
    /// </summary>
    public partial class TestMainView : UserControl
    {
        public TestMainView()
        {
            InitializeComponent();
            this.DataContext = InstancePool.GetInstanceT<TestMainVM>();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            UIManager.Instance.ShowUI("TestingView");
        }
    }
}
