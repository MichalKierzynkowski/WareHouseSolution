using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseApplication.Forms
{
    public partial class ReturnForm : Form
    {
        public string ConnectionString { get; set; }
      
        public ReturnForm(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
          
        }



    }
}
