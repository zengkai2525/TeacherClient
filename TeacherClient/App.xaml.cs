using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TeacherClient
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        //[STAThread]
        //static void Main(string[] args)
        //{
        //    System.Threading.Mutex mutex = new System.Threading.Mutex(false, "ThisShouldOnlyRunOnce");
        //    bool Running = !mutex.WaitOne(0, false);
        //    if (!Running)
        //    {
        //        TeacherClient.App app = new TeacherClient.App();
        //        app.InitializeComponent();
        //        app.Run();
        //    }
        //}
    }
}
