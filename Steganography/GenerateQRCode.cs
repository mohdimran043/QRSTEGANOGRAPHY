using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing.QrCode;

namespace Steganography
{
    public partial class GenerateQRCode : Form
    {
        public GenerateQRCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ENTER QR TEXT");
            }
            var options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 230,
                Height = 230,
            };
            var qr = new ZXing.BarcodeWriter();
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.QR_CODE;
            var result = new Bitmap(qr.Write(textBox1.Text.Trim()));
            result.Save(@"C:\Users\Mohd\Downloads\sourcecode\Steganography\Sample QR CODE\sampleqr.bmp");
        }
    }
}
