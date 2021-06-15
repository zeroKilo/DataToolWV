using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace DataToolWV
{
    public partial class Form1 : Form
    {
        public string lastInput = "";
        public Form1()
        {
            InitializeComponent();
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private byte[] GetDataA()
        {
            return StringToByteArray(rtba.Text.Replace(" ", ""));
        }
        private byte[] GetDataB()
        {
            return StringToByteArray(rtbb.Text.Replace(" ", ""));
        }

        private void xORAWithBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] B = GetDataB();
                int posB = 0;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < A.Length; i++)
                    sb.Append((A[i] ^ B[posB++ % B.Length]).ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void xORAWithBPlusOffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Offset in hex", "XOR with offset", lastInput);
            if(input != "")
            {
                try
                {
                    rtbr.Text = "";
                    lastInput = input;
                    int off = Convert.ToInt32(input.Trim(), 16);
                    byte[] A = GetDataA();
                    byte[] B = GetDataB();
                    int posB = 0;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < A.Length; i++)
                        sb.Append((A[i] ^ B[(off + posB++) % B.Length]).ToString("X2") + " ");
                    rtbr.Text = sb.ToString();
                }
                catch (Exception ex)
                {
                    rtbr.Text = "Error:\n" + ex.Message;
                }
            }
        }

        private void aESDecryptAWithBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] B = GetDataB();
                byte[] R;
                int t = B.Length;
                if (t != 16 && t != 24 && t != 32)
                    return;
                using (RijndaelManaged rDel = new RijndaelManaged())
                {
                    rDel.KeySize = B.Length * 8;
                    rDel.Mode = CipherMode.ECB;
                    rDel.Padding = PaddingMode.None;
                    using (var decryptor = rDel.CreateDecryptor(B, new byte[16]))
                        R = decryptor.TransformFinalBlock(A, 0, A.Length);
                }
                StringBuilder sb = new StringBuilder();
                foreach(byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void aESEncryptAWithBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] B = GetDataB();
                byte[] R;
                int t = B.Length;
                if (t != 16 && t != 24 && t != 32)
                    return;
                using (RijndaelManaged rDel = new RijndaelManaged())
                {
                    rDel.KeySize = B.Length * 8;
                    rDel.Mode = CipherMode.ECB;
                    rDel.Padding = PaddingMode.None;
                    using (var decryptor = rDel.CreateEncryptor(B, new byte[16]))
                        R = decryptor.TransformFinalBlock(A, 0, A.Length);
                }
                StringBuilder sb = new StringBuilder();
                foreach (byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void base64EncodeAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] R = Encoding.ASCII.GetBytes(Convert.ToBase64String(A));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void base64DecodeAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] R = Convert.FromBase64String(Encoding.ASCII.GetString(A));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void zLIBCompressAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] R;
                MemoryStream m = new MemoryStream();
                using (DeflaterOutputStream exf = new DeflaterOutputStream(m))
                {
                    exf.Write(A, 0, A.Length);
                    exf.Flush();
                }
                R = m.ToArray();
                StringBuilder sb = new StringBuilder();
                foreach (byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }

        private void zLIBDecompressAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbr.Text = "";
                byte[] A = GetDataA();
                byte[] R;
                using (InflaterInputStream inf = new InflaterInputStream(new MemoryStream(A)))
                {
                    MemoryStream m = new MemoryStream();
                    inf.CopyTo(m);
                    R = m.ToArray();
                }
                StringBuilder sb = new StringBuilder();
                foreach (byte b in R)
                    sb.Append(b.ToString("X2") + " ");
                rtbr.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                rtbr.Text = "Error:\n" + ex.Message;
            }
        }
    }
}
