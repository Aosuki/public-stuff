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
    public partial class testcon3 : UserControl
    {
        public static testcon3 _instance;
        public static testcon3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new testcon3();
                }
                return _instance;
            }
        }
        public testcon3()
        {
            InitializeComponent();
        }
    }
}
