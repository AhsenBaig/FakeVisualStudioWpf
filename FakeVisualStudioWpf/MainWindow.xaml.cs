using System.Windows;

namespace FakeVisualStudioWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //This is the original title of the application
        //TODO: might save this somewhere external to keep the users preference.
        string title = "Visual Studio Enterprise 2017";
        public MainWindow()
        {
            InitializeComponent();
            //Initial TItle
            this.Title = title;
        }        

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateTitle.Text))
            {
                //Update the title to whatever is in the textbox UpdateTitle.
                this.Title = UpdateTitle.Text;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            //This resets the title back to the original value.
           this.Title = title;
        }
    }
}
