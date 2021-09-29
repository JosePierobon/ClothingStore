using ClothingStore.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingStore.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var prendasBL = new PrendasBL();
            var listadePrendas = prendasBL.ObtenerPrendas();

            listadePrendasBindingSource.DataSource = listadePrendas;

        }

        private void listadePrendasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
