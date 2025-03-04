using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        LinkedList blocks = new LinkedList();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

          
        public void GenerateBlocks()
        {
            panelBlocks.Controls.Clear();
            blocks = new LinkedList();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                blocks.Add(color);
                DrawBlock(color, i);
            }
        }

        private void DrawBlock(Color color, int index)
        {
            Label lbl = new Label
            {
                Width = 50,
                Height = 50,
                BackColor = color,
                Location = new Point(50 * index, 10),
                AllowDrop = true
            };

            lbl.MouseDown += Block_MouseDown;
            panelBlocks.DragOver += PanelBlocks_DragOver;
            panelBlocks.DragDrop += PanelBlocks_DragDrop;
            panelBlocks.Controls.Add(lbl);
        }
        private void Block_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.DoDragDrop(lbl, DragDropEffects.Move);
            }
        }

        private void PanelBlocks_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PanelBlocks_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = e.Data.GetData(typeof(Label)) as Label;
            if (lbl != null)
            {
                Point dropPoint = panelBlocks.PointToClient(new Point(e.X, e.Y));
                lbl.Location = new Point(dropPoint.X, 10);  // Adjust position
                panelBlocks.Controls.Add(lbl);
            }
        }


         
        private async void btnSort_Click(object sender, EventArgs e)
        {
            await blocks.BubbleSort(panelBlocks);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateBlocks();
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            GenerateBlocks();
        }

        private async void btnSort_Click_1(object sender, EventArgs e)
        {
            await blocks.BubbleSort(panelBlocks);
        }
    }


}

