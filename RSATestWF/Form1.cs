using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSATestWF
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider _currentProvider;
        private readonly BinaryFormatter _serializer = new BinaryFormatter();
        
        public Form1()
        {
            InitializeComponent();
            
            _currentProvider = new RSACryptoServiceProvider();
        }

        private void generatePairButton_Click(object sender, EventArgs e)
        {
            _currentProvider = new RSACryptoServiceProvider();
            keyPairInfoLabel.Text = "Used new random keypair";
        }

        private void importPairButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                RSAParametersSerializable rsaParams = (RSAParametersSerializable) _serializer.Deserialize(openDialog.OpenFile());
                _currentProvider.ImportParameters(rsaParams.RSAParameters);
                keyPairInfoLabel.Text = "Key from " + openDialog.SafeFileName;
            }
        }

        private void exportPairButton_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _serializer.Serialize(saveDialog.OpenFile(), new RSAParametersSerializable(_currentProvider.ExportParameters(true)));
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            var encryptedString = _currentProvider.Encrypt(Encoding.UTF8.GetBytes(encryptTextBox.Text), RSAEncryptionPadding.Pkcs1);
            var saveDialog = new SaveFileDialog();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var writer = new BinaryWriter(saveDialog.OpenFile());
                writer.Write(encryptedString);
                writer.Close();
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = openDialog.OpenFile();
                decryptTextBox.Text = Encoding.UTF8.GetString(_currentProvider.Decrypt(ReadFully(stream), RSAEncryptionPadding.Pkcs1));
                stream.Close();
            }
        }
        
        private static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}