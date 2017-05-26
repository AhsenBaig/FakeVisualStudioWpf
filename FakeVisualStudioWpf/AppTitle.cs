using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeVisualStudioWpf
{
    public static class AppTitle
    {
        //This is the original title of the application
        public static readonly string title = "Visual Studio Enterprise 2017";
        public static string GetSetTitle()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSaveTitleValue))
            {
                return Properties.Settings.Default.LastSaveTitleValue;
            }
            else
            {
                return title;
            }            
        }

        public static string GetPreviousValue()
        {
            //If the previous title is saved we will return that.
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastTitleValue))
            {
                return Properties.Settings.Default.LastTitleValue;
            }
            //Else use the currently saved title.
            else if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSaveTitleValue))
            {
                return Properties.Settings.Default.LastSaveTitleValue;
            }
            else
            {
                //All else failed return the default
                return title;
            }

        }
    }
}
