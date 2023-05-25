using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.UI.Xaml.Navigation;

namespace get_path
{
    public class getPath
    {
        private static string _path = @"";
        public static string path {  
            get { return _path; }
            set { _path = value; }
        }
        // Get current directory 
        public static string get_act_path()
        {          
            return path = Directory.GetCurrentDirectory();
        } 
        // Get current directory and enter in a folder
        public static string get_act_path(in string folder_name) {
            return path = $@"{Directory.GetCurrentDirectory()}\{folder_name}\";
        }
        //Get production repositorie 
        public static string get_production_path(string nameApp)
        {
            string[] splitPath = Directory.GetCurrentDirectory().Split(@"\");
            foreach (var item in splitPath)
            {
                path += $@"{item}\";
                if ( item == nameApp)
                {
                    path += $@"{item}";
                    break;
                }
            }
            return path;
        }
        // Get raiz disk repositorie 
        public static string get_rep_disk()
        {
            string[] splitPath = Directory.GetCurrentDirectory().Split(@"\");
            return path = splitPath[0];
        }

    }
}
