using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    [ComVisible(true)] // Class must be ComVisible
    public class Demo
    {
        public void SayHello(string name) => MessageBox.Show($"Hello {name} !!!");
    }
}
