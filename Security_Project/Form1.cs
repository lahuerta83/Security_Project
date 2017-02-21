using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;
using System.IO;

namespace Security_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desobj = Rijndael.Create();
        }

        string cipherstring;
        byte[] cipherbyte;
        byte[] textbyte;
        byte[] bytetext;
        byte[] pkey;

        SymmetricAlgorithm desobj;

        private void encryptbutton_Click(object sender, EventArgs e)
        {
            cipherstring = Message.Text;
            textbyte = Encoding.ASCII.GetBytes(cipherstring);
            pkey = Encoding.ASCII.GetBytes("0123456789abcdef");
            desobj.Key = pkey;
            desobj.Mode = CipherMode.CBC;
            desobj.Padding = PaddingMode.PKCS7;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            CryptoStream cs = new CryptoStream(ms, desobj.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(textbyte, 0, textbyte.Length);
            cs.Close();
            cipherbyte = ms.ToArray();
            ms.Close();
            Encryptmessage.Text = Encoding.ASCII.GetString(cipherbyte);

            
              
        }

        private void decryptbutton_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
            CryptoStream cs1 = new CryptoStream(ms1, desobj.CreateDecryptor(), CryptoStreamMode.Write);

            cs1.Write(cipherbyte, 0, cipherbyte.Length);
            cs1.Close();
            bytetext = ms1.ToArray();
            ms1.Close();

            Decryptmessage.Text = Encoding.ASCII.GetString(bytetext);

        }
    }
}
