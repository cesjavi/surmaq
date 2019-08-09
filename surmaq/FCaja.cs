using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surmaq
{
    public partial class FCaja : Form
    {
        public FCaja()
        {
            InitializeComponent();
            mtbSubtotal.Text = "00000000";
            this.WindowState = FormWindowState.Maximized;
            int largoVentana = this.Width;

            dgvCompras.Columns[0].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.10));
            dgvCompras.Columns[1].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.10));
            dgvCompras.Columns[2].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.50));
            dgvCompras.Columns[3].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.10));
            dgvCompras.Columns[4].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.10));
            dgvCompras.Columns[5].Width = Convert.ToInt32(Math.Abs(largoVentana * 0.10));
            

        }
    }
}
