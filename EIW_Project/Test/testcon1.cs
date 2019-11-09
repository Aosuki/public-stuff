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
    public partial class testcon1 : UserControl
    {
        public static testcon1 _instance;
        public static testcon1 Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new testcon1();
                }
                return _instance;
            }
        }

        public testcon1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
