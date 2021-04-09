using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SMBlueprint;

namespace SM_Image_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtDir.Text) && txtName.Text != "")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images (*.png, *.jpg, *.jpeg, *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(dialog.FileName);
                    Blueprint bp = new Blueprint(txtDir.Text, txtName.Text);

                    float sampleRate = (float)numSampling.Value;

                    for(float y = 0; y < image.Height; y += sampleRate)
                    {
                        for (float x = 0; x < image.Width; x += sampleRate)
                        {
                            Color pixel = image.GetPixel((int)x, (int)y);
                            int posX = (int)(x / sampleRate);
                            int posY = (int)(y / sampleRate) * -1;
                            bp.addBlock((Block)cmbMaterial.SelectedIndex, posX, 0, posY, BlockMethods.ColorToString(pixel));
                        }
                    }

                    bp.closeFile();
                }
            }
        }
    }
}
