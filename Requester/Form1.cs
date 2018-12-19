using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static HttpClient client = new HttpClient();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("テキストボックスの中身が空です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string url = "https://" + textBox1.Text + ".ngrok.io/";

            async Task WaitResponse()
            {
                var response = await client.GetAsync(url);
                var contents = await response.Content.ReadAsStringAsync();
                richTextBox1.Text = contents;
            }

            WaitResponse();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control==true)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("テキストボックスの中身が空です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string url = "https://" + textBox1.Text + ".ngrok.io/";

                async Task WaitResponse()
                {
                    var response = await client.GetAsync(url);
                    var contents = await response.Content.ReadAsStringAsync();
                    richTextBox1.Text = contents;
                }

                WaitResponse();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control == true)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("テキストボックスの中身が空です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string url = "https://" + textBox1.Text + ".ngrok.io/";

                async Task WaitResponse()
                {
                    var response = await client.GetAsync(url);
                    var contents = await response.Content.ReadAsStringAsync();
                    richTextBox1.Text = contents;
                }

                WaitResponse();
            }
        }
    }
}
