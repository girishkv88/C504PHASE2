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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.IndianRed;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleTurquoise;
            staColor.Text = txtEditor.BackColor.ToString();

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleGreen;
            staColor.Text = txtEditor.BackColor.ToString();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var result = digColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = digColor.Color;
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            var result = digColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = digColor.Color;
                staForeColor.Text = txtEditor.ForeColor.ToString();
            }
        }

        private void mnuRedBg_Click(object sender, EventArgs e)
        {
            btnRed_Click(null, null);
        }

        private void mnuBlueBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleTurquoise;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuGreenBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleGreen;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuOtherBg_Click(object sender, EventArgs e)
        {
            var result = digColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = digColor.Color;
            }
        }

        private void mnuFg_Click(object sender, EventArgs e)
        {
            
            var result = digColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = digColor.Color;
                staForeColor.Text = txtEditor.ForeColor.ToString();
            }
        }

        private void mnuRed2_Click(object sender, EventArgs e)
        {
            btnRed_Click(null, null);
        }

        private void mnuGreen2_Click(object sender, EventArgs e)
        {
            btnGreen_Click(null, null);
        }

        private void mnuBlue2_Click(object sender, EventArgs e)
        {
            btnBlue_Click(null, null);
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = txtEditor.Font;
            var result = dlgFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.Font = dlgFont.Font;
            }

        }

        private void mnuLeft_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Left;
        }

        private void mnuCenter_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign= HorizontalAlignment.Center;
        }

        private void mnuRight_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Right;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            var result = dlgOpen.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgOpen.FileName;

                //logic to save
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Create);
                    sr = new StreamReader(fs);
                    txtEditor.Text = sr.ReadToEnd();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();

                }
            }
        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            var result = dlgSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgSave.FileName;

                //logic to save
                FileStream fs = null;
                StreamWriter sw = null; 
                try
                {
                    fs = new FileStream(fileName, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(txtEditor.Text);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                    if (fs != null)
                        fs.Close();
                 
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mnuLeft_Click(null , null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mnuCenter_Click(null , null);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
          mnuRight_Click(null , null);  
        }
    }
}
