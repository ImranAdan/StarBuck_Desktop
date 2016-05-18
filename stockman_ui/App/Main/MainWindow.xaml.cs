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
using System.Configuration;

using stockman_ui.app.config;

namespace stockman_ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly float scalingFactor;

        public MainWindow()
        {
            scalingFactor = AppConfigReader.ConfigStringValueAs<long>("mainWindowScaleFactor");
            InitializeComponent();
            InitialiseMainWindowContainer();
        }

        private void InitialiseMainWindowContainer()
        {
            InitialiseWindowMetrics();
            InitialiseWindowComponents();
        }

        private void InitialiseWindowMetrics()
        {
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth / scalingFactor;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight / scalingFactor;
            this.Left = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) - (this.Width / 2);
            this.Top = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - (this.Height / 2);
        }

        private void InitialiseWindowComponents()
        {
            WindowTitleBar();
        }

        private void WindowTitleBar()
        {
            var versionNumber = ", v-" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var loggedInUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var appLaunchDate = DateTime.Now.ToLongDateString();
            this.Title += versionNumber + " - " + loggedInUser + " - " + appLaunchDate;
        }
    }
}
