using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonsGame
{
    public partial class baslatMenu : Form
    {
        public baslatMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Başlangıç formunu gizle
            Level1 form1 = new Level1();
            form1.Show(); // Form2'yi göster
        }
    }
}
