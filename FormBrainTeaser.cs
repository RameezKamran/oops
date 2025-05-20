using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EduQuestFinal
{
    public partial class FormBrainTeaserGame : Form
    {
        private string username;
  
        
        public FormBrainTeaserGame(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startgame form = new startgame();
            form.Show(); this.Close();
        }

        private void FormBrainTeaserGame_Load(object sender, EventArgs e)
        {

        }
  
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            startgame form = new startgame();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(username);
            form.Show(); this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
