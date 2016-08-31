using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try//rtf olarak açmaya çalış
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);
                }
                catch
                {
                    try
                    {   //düz metin olarak açmayı dene
                        richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                    }
                    catch
                    {
                        MessageBox.Show(openFileDialog1.FileName+"Bu dosya açılamaz, desteklemiyor");
                    }
                }
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName!="")
            {//bir dosya açılmışsa aynı isimle kaydedilmesi gerekiyor
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)//Hiç dosya açılmamışsa istenilen isimde tekrar kayıt oluştur
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void üToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Not Defteri--Yeni";
            richTextBox1.Text = "";
        }

        private void yazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bu kısım yeni form oluşturularak yapılacak
        /*    label1.Visible = true;
            textBox1.Visible = true;


            yer = richTextBox1.Text.ToUpper().IndexOf(textBox1.Text.ToUpper());
            if (yer < 0)
                MessageBox.Show("üzgünüm bulunamadı");
            else
            {
                richTextBox1.SelectionStart = yer;
                richTextBox1.SelectionLength = textBox1.Text.Length;
                MessageBox.Show((yer + 1).ToString() + " . harfte buldum ve seçtim");
            }*/
        }

        private void sonrakiniBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             label1.Visible = true;
            textBox1.Visible = true;

            yer =richTextBox1.Text.ToUpper().IndexOf(textBox1.Text.ToUpper(), yer + 1);
            if (yer < 0)
                MessageBox.Show("üzgünüm başka bulunamadı");
            else
            {
               richTextBox1.SelectionStart = yer;
                richTextBox1.SelectionLength = textBox1.Text.Length;
                MessageBox.Show((yer + 1).ToString() + " . harfte bir tane daha buldum ve seçtim");
            }
             */
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saatTarihAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = string.Format(" {0}", DateTime.Now);
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Enabled = true;
        }
    }
}
