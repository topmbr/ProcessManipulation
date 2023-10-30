using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAvailableAssemblies();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (StartedAssembliesListBox.SelectedItem != null)
            {
                string selectedAssembly = StartedAssembliesListBox.SelectedItem.ToString();
                StartChildProcess(selectedAssembly);
                RefreshStartedAssemblies();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (StartedAssembliesListBox.SelectedItem != null)
            {
                string selectedAssembly = StartedAssembliesListBox.SelectedItem.ToString();
                StopChildProcess(selectedAssembly);
                RefreshStartedAssemblies();
            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            if (StartedAssembliesListBox.SelectedItem != null)
            {
                string selectedAssembly = StartedAssembliesListBox.SelectedItem.ToString();
                CloseChildProcessWindow(selectedAssembly);
                RefreshStartedAssemblies();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshStartedAssemblies();
        }

        private void RunCalc_Click(object sender, EventArgs e)
        {
            StartCalc();
        }
        private void RefreshAvailableAssemblies()
        {
            StartedAssembliesListBox.Items.Clear();

            // Здесь вы можете заполнить ListBox "AvailableAssemblies" списком доступных приложений
            // Пример:
            StartedAssembliesListBox.Items.Add("ChildProcess");
            StartedAssembliesListBox.Items.Add("ChildProcess2");
        }

        private void StartChildProcess(string assemblyName)
        {
            Process.Start(assemblyName + ".exe");
        }

        private void StopChildProcess(string assemblyName)
        {
            Process[] processes = Process.GetProcessesByName(assemblyName);
            foreach (var process in processes)
            {
                process.Kill();
            }
        }

        private void CloseChildProcessWindow(string assemblyName)
        {
            Process[] processes = Process.GetProcessesByName(assemblyName);
            foreach (var process in processes)
            {
                IntPtr mainWindowHandle = process.MainWindowHandle;
                if (mainWindowHandle != IntPtr.Zero)
                {
                    PostMessage(mainWindowHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                }
            }
        }

        private const int WM_CLOSE = 0x0010;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private void StartCalc()
        {
            Process.Start("calc.exe");
        }

        private void RefreshStartedAssemblies()
        {
            StartedAssembliesListBox.Items.Clear();

            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    StartedAssembliesListBox.Items.Add(process.ProcessName);
                }
            }
        }
    }
}
