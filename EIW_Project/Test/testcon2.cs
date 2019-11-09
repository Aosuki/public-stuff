using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class testcon2 : UserControl
    {
        public static testcon2 _instance;
        public static testcon2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new testcon2();
                }
                return _instance;
            }
        }
        public testcon2()
        {
            InitializeComponent();
        }

        private void Testcon2_Load(object sender, EventArgs e)
        {

        }
    }
}
