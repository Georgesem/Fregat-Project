using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fregatDataSet.oblast". При необходимости она может быть перемещена или удалена.
            this.oblastTableAdapter.Fill(this.fregatDataSet.oblast);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fregatDataSet.nalog". При необходимости она может быть перемещена или удалена.
            this.nalogTableAdapter.Fill(this.fregatDataSet.nalog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fregatDataSet.partner". При необходимости она может быть перемещена или удалена.
            this.partnerTableAdapter.Fill(this.fregatDataSet.partner);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.partnerTableAdapter.Update(this.fregatDataSet);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = "partner.oblast_id= '" + comboBox1.SelectedValue +"'" ;
            dataGridView1.Refresh();
        }
    }
}
