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

namespace WinForms_MD5_and_SHA_256__SHA2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static String ByteArrayToHexString(byte[] str)
        {
            StringBuilder hex = new StringBuilder(str.Length * 2);
            foreach (byte b in str)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
        public static byte[] HexStringByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i++)
            {
                bytes[1 / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        // Setup button and textbox
        //MD5 hash
        private void MD5_ButtonClick_(object sender, EventArgs e)
        {
            using (System.Security.Cryptography.MD5 md5hash = System.Security.Cryptography.MD5.Create())
            {
                string hash = GetMd5hash(md5hash, m_UserInput_TextBox.Text);
                m_MD5_textbox.Text = hash;
            }
            static string GetMd5hash(System.Security.Cryptography.MD5 md5hash, string input)
            {
                byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
        //SHA256 hash
        private void SHA256_Button_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.SHA256Managed Sha256hash = new System.Security.Cryptography.SHA256Managed(); // goi cac ham va khoi tao
            byte[] bytes = Encoding.UTF8.GetBytes(m_UserInput_TextBox.Text);

            byte[] hash = Sha256hash.ComputeHash(bytes);
            string hashstring = string.Empty;
            foreach(byte x in hash)
            {
                hashstring += String.Format("{0:x2}", x);
            }
            SHA256_TextBox.Text = hashstring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt|All Files (*.*)|*.*";
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                m_UserInput_TextBox.Text = ofd.FileName;
                richTextBoxInput.Text = File.ReadAllText(ofd.FileName);
            }
        }

     
    }
}
