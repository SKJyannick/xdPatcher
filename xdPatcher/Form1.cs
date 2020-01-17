using System;
using System.IO;
using System.Windows.Forms;

namespace xdPatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Info inf = new Info();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Nintendo DS ROMs|*.nds|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "xdelta Patch Files|*.xdelta|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "Nintendo DS ROMs|*.nds|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = open.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Nintendo DS ROMs|*.nds|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = open.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Nintendo DS ROMs|*.nds|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = open.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "xdelta Patch Files|*.xdelta|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = open.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "xdelta3.exe";
            proc.StartInfo.Arguments = " -d -s " + '"' + textBox1.Text + '"' + " " + '"' + textBox2.Text + '"' + " " + '"' + textBox3.Text + '"';
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            try
            {
                var RP = @textBox3.Text;
                StreamReader sr = new StreamReader(RP);
                var IP = sr.ReadToEnd();
                sr.Close();
                label7.Text = IP;
                MessageBox.Show("Apply patch complete!",label7.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Apply patch failed.",ex.HelpLink);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "xdelta3.exe";
            proc.StartInfo.Arguments = " -e -s " + '"' + textBox4.Text + '"' + " " + '"' + textBox5.Text + '"' + " " + '"' + textBox6.Text + '"';
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            try
            {
                var RP = @textBox5.Text;
                StreamReader sr = new StreamReader(RP);
                var IP = sr.ReadToEnd();
                sr.Close();
                label7.Text = IP;
                MessageBox.Show("Make patch complete!", label7.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Make patch failed.", ex.HelpLink);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 536;
            this.Height = 209;
            textBox1.Select();
            label7.Visible = false ;
            if(WindowState == FormWindowState.Maximized)
            {
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e){}

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "+")
            {
                Width = 536;
                Height = 345;
                button10.Text = "-";
                toolStripStatusLabel3.Text = "Hide more options";
            }
            else if (button10.Text == "-")
            {
                Width = 536;
                Height = 209;
                button10.Text = "+";
                toolStripStatusLabel3.Text = "Show more options";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Browse for an original ROM";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Browse for a xdelta patch file";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Choose the output file";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Browse for an original ROM";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Browse for a modified ROM";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Choose the output file";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Apply patch";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Make patch";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Shows the info";
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            if (button10.Text == "+")
            {
                toolStripStatusLabel3.Text = "Show more options";
            }
            else if (button10.Text == "-")
            {
                toolStripStatusLabel3.Text = "Hide more options";
            }
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        { 
        }
    }
}
