using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ERP.Demo;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
            //WebService webService = new WebService();
            // Call the GetData method in the Web Service
            //DataSet ds = controller.getEmployees();
            //DataView source = new DataView(ds.Tables[0]);
            try
            {
                //   dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception f)
            {
                throw f;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            //dataGridView1.DataSource = dt;
            webService.updateEployee(dt);
            MessageBox.Show("Data Updaterad", "Updaterad", MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                updateButton.Visible = true;
            }
            else
            {
                updateButton.Visible = false;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                DataSet ds = controller.getEmployees();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataSet ds = controller.getQualafications();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                DataSet ds = controller.getEmployeeRelatives();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                DataSet ds = controller.getEmployeeAbscence();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                DataSet ds = controller.getEmployeeAbscence2004();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                DataSet ds = controller.getMostSick();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                DataSet ds = controller.getColumns();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                DataSet ds = controller.getKeys();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                DataSet ds = controller.getIndexes();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                DataSet ds = controller.getTableConstraints();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                DataSet ds = controller.getTables();
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
