using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Docs
{
    public partial class DocsAdding : UserControl
    {
        public DocsAdding()
        {
            InitializeComponent();
        }

        private Image _image;

        public Image Image
        {
            get { return _image; }
            set { _image = value; pbAutomated.Image = value; }
        }

        private int _reqId;

        public int ReqId
        {
            get { return _reqId; }
            set { _reqId = value; }
        }


        private string _reqname;

        public string ReqName
        {
            get { return _reqname; }
            set { _reqname = value;label1.Text = value; }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            string filePath = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog.FileName;
                pbAutomated.SizeMode = PictureBoxSizeMode.AutoSize;
                pbAutomated.Image = Image.FromFile(filePath);
                _image = Image.FromFile(filePath);

            }
        }
    }
}
