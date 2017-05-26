using System.Windows;

namespace FakeVisualStudioWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
                this.Title = UpdateTitle.Text;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
           this.Title = title;
        }
    }
}
