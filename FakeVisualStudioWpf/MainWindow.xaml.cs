using System.Windows;

namespace FakeVisualStudioWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Initial TItle

            //Check to see if user has set a title before else use default.
            this.Title = AppTitle.GetSetTitle();

            //Set the current textbox to be the initial title
            this.UpdateTitle.Text = this.Title;

            //Update the current title as a backup.
            UpdateLastTitleUserSettings(this.Title);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //Validate there is value in the text box
            if (!string.IsNullOrEmpty(UpdateTitle.Text))
            {
                //Update the title to whatever is in the textbox UpdateTitle.
                this.Title = UpdateTitle.Text;

                //Save the title settings
                UpdateTitleUserSettings();
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            //This resets the title back to the users original value or use current else use the default.
            this.Title = AppTitle.GetPreviousValue();

            //Save title settings
            UpdateTitleUserSettings();

            //Update the main textbox to be the title text.
            UpdateTitle.Text = this.Title;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Update and save the title when closing the application.
            UpdateTitleUserSettings();
        }

        private void UpdateTitleUserSettings()
        {
            //When the window is closing we set the current UpdateTitle to the settings properties.
            Properties.Settings.Default.LastSaveTitleValue = UpdateTitle.Text;

            //Save the settings
            Properties.Settings.Default.Save();
        }


        private void UpdateLastTitleUserSettings(string title)
        {
            //When the window is closing we set the current UpdateTitle to the settings properties.
            Properties.Settings.Default.LastTitleValue = title;

            //Save the settings
            Properties.Settings.Default.Save();            
        }
    }
}
