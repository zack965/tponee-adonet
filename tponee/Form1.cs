using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tponee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void DisplayName_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            d.connecter();
            d.cmd.CommandText = "select nom from stagaire";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            while (d.dr.Read())
            {
                listBox1.Items.Add(d.dr[0].ToString());
            }
            d.dr.Close();
            d.cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.connecter();
        }

        private void DisplayNameAge_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            d.connecter();
            d.cmd.CommandText = "select nom,age from stagaire";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            while (d.dr.Read())
            {
                listBox1.Items.Add(d.dr[0].ToString() + "/"+d.dr[1].ToString());
            }
            d.dr.Close();
            d.cnx.Close();
        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            d.connecter();
            d.cmd.CommandText = "select * from stagaire";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            while (d.dr.Read())
            {
                listBox1.Items.Add(d.dr[0].ToString() + "/" + d.dr[1].ToString()+"/"+d.dr[2].ToString()+"/"+d.dr[3].ToString()+"/"+d.dr[4].ToString());
            }
            d.dr.Close();
            d.cnx.Close();
        }
    }
}
