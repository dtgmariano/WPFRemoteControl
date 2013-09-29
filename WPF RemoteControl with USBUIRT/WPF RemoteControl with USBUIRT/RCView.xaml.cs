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

namespace WPF_RemoteControl_with_USBUIRT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var rc = new RCViewModel(new RCModel());
            DataContext = rc.myRCModel;
            btPower.Click += rc.onPowerBtClick;
            btChannelUp.Click += rc.onChUpBtClick;
            btChannelDown.Click += rc.onChDownBtClick;
            btVolumeUp.Click += rc.onVolUpBtClick;
            btVolumeDown.Click += rc.onVolDownBtClick;
        }

        
    }
}
