using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.Laps1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Laps1 : Page
    {
        public Laps1()
        {
            this.InitializeComponent();
        }

   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mail = inputMail.Text;
            string title = inputTitle.Text;
            string content = inputContent.Text;

            List<string> Box;
            Box = new List<string>();
            Box.Add(mail);
            Box.Add(title);
            Box.Add(content);
            if (txtData.Text == "Nothings here")
                txtData.Text = "";
            foreach (var per in Box)
            txtData.Text +=per+",";
        }
    }
}
