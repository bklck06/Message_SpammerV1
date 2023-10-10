using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpammerV1
{
    public partial class TextSpammerV1 : Form
    {
        public TextSpammerV1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void copy_button_Click(object sender, EventArgs e)
        {
            // TextBox'taki metni al
            string metin = textBoxMetin.Text;

            // RichTextBox'e metni yapıştır
            richTextBoxKopyalananMetin.AppendText(metin + Environment.NewLine);
        }

        private void txt_button_Click(object sender, EventArgs e)
        {
            // Kaydetmek istediğiniz dosyanın adını ve yolu seçin.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // RichTextBox içeriğini seçilen dosyaya kaydet.
                File.WriteAllText(saveFileDialog.FileName, richTextBoxKopyalananMetin.Text);

                // Başarılı kaydetme mesajı
                MessageBox.Show("Metin başarıyla kaydedildi.");
            }
        }
        private void LaunchWebsite(string url)
        {
            try
            {
                // Standart web tarayıcısını kullanarak belirtilen URL'yi aç.
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Web sitesi açılırken bir hata oluştu: " + ex.Message);
            }
        }
        private void twitterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LaunchWebsite("https://twitter.com/login");
        }

        private void instagramLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LaunchWebsite("https://www.instagram.com/accounts/login/");
        }

        private void whatsappLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LaunchWebsite("https://web.whatsapp.com/");
        }

        private void textBoxClearButton_Click(object sender, EventArgs e)
        {
            textBoxMetin.Clear();
        }

        private void richTextBoxClearButton_Click(object sender, EventArgs e)
        {
            while (richTextBoxKopyalananMetin.Lines.Length > 0)
            {
                richTextBoxKopyalananMetin.Select(0, richTextBoxKopyalananMetin.Lines[0].Length + 1);
                richTextBoxKopyalananMetin.Cut();
            }
        }
    }
}
