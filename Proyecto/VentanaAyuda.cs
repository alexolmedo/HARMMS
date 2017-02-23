using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class VentanaAyuda : Form
    {
        public VentanaAyuda()
        {
            InitializeComponent();
            this.CenterToScreen();
            webBrowser1.Navigate(@"https://drive.google.com/open?id=0B0AFXrGqV1jAdnI5eHlXd0JPTGs");
        }
    }
}
