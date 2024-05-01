using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DREAMS
{
    public partial class Form1 : Form
    {

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            InitializeComponent();
            GraphicsManager.AddSprite(new Sprite("1.png"), e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
