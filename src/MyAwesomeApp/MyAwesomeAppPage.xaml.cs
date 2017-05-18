using MyAwesomeLib;
using Xamarin.Forms;

namespace MyAwesomeApp
{
    public partial class MyAwesomeAppPage : ContentPage
    {
        public MyAwesomeAppPage()
        {
            InitializeComponent();

            var myAwesomeClass = new AwesomeClass();
            MyAwesomeLabel.Text = myAwesomeClass.WhatsMyPlatform().ToString();
        }
    }
}
