using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduQuestFinal
{
    public partial class Form4 : Form
    {
        public string username;
        public Form4(string str)
        {
            InitializeComponent();
            username = str;
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void codingchallenge_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
            codingchallenge.FlatStyle = FlatStyle.Flat;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectlevel form = new selectlevel("");
            form.Show();
            this.Close();
        }

        private void typemonk_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10(username);
            form.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = username;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(430, 282);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void brainteaser_Click(object sender, EventArgs e)
        {
            FormBrainTeaserGame nayaform = new FormBrainTeaserGame(username);
            nayaform.Show();
            this.Close();
        }

    }
}
