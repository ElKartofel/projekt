using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przeglądarka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Hide();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Nawigacja()
        {
            toolStripStatusLabel1.Text = "Wczytywanie";
            webBrowser1.Navigate(textBox1.Text);
            webBrowser1.Show();
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {

                button1_Click(null, null);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {

                button11_Click(null, null);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            button11.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            toolStripStatusLabel1.Text = "Wczytano";
            toolStripProgressBar1.ProgressBar.Value = 100;
        }
        
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                int percentage = (int)(e.CurrentProgress * 100 / e.MaximumProgress);

                if (percentage <= 100)
                {
                    toolStripProgressBar1.ProgressBar.Value = percentage;
                }
            }
            else
            {
                toolStripProgressBar1.ProgressBar.Value = 0;
            }
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Nawigacja();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.google.com";
            Nawigacja();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.wemif.net";
            Nawigacja();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.onet.pl";
            Nawigacja();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.wroclaw.pl/rozklady-jazdy";
            Nawigacja();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.pl/#q=" + textBox2.Text);
            webBrowser1.Show();
            textBox2.Text = null;
        }
    }
}
