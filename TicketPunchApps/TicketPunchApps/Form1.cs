using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPunchApps
{
    public partial class CounterUI : Form
    {
        public CounterUI()
        {
            InitializeComponent();
        }

        int numberofticket = 0;
        double unitprice = 20;
        string name = "";
        double totalprice = 0;

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {
            numberofticket = Convert.ToInt32(txtTicket.Text);
            name = txtName.Text;

            totalprice = unitprice*numberofticket;
            txtName.Text = "";
            txtTicket.Text = "";

            MessageBox.Show(name + ",Please" + totalprice + "Taka, Pay");
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customar:" + name + "\nUnit Price" + unitprice + "\nTotal" +totalprice);
        }
    }
}
