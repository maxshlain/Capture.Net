using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Capture.Net
{
    [StructLayout(LayoutKind.Sequential)]
    struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    static class Program
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);




        //public static string s_url;
        //public static string s_username;
        //public static string s_password;
        //public static string s_domain;
        //public static string s_ifSavePassword;

        public static string s_StorageFolderPath;
        public static int s_MainWindowWidth;
        public static int s_MainWindowHeight;

        public static int s_ProjectId;



        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "MyApplicationName", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    LoadAppSettings();
                    Application.Run(new MainForm());
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }

        private static void LoadAppSettings()
        {
            
            //s_url = ConfigurationManager.AppSettings["url"];
            //s_username = ConfigurationManager.AppSettings["username"];
            //s_password = ConfigurationManager.AppSettings["password"];
            //s_domain = ConfigurationManager.AppSettings["domain"];
            //s_ifSavePassword = ConfigurationManager.AppSettings["save_password"];

            string tmp = ConfigurationManager.AppSettings["main_window_width"];
            if (!String.IsNullOrEmpty(tmp))
                s_MainWindowWidth = Convert.ToInt32(tmp);
            tmp = ConfigurationManager.AppSettings["main_window_height"];
            if (!String.IsNullOrEmpty(tmp))
                s_MainWindowHeight = Convert.ToInt32(tmp);
            tmp = ConfigurationManager.AppSettings["project_id"];
            if (!String.IsNullOrEmpty(tmp))
                s_ProjectId = Convert.ToInt32(tmp);
            else
                s_ProjectId = 0;

            tmp = ConfigurationManager.AppSettings["StorageFolderPath"];
            s_StorageFolderPath = String.IsNullOrEmpty(tmp) ? @"C:\" : tmp;

            return;
        }
    }
}
