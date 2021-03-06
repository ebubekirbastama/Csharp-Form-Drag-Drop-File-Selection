using System;
using System.Windows.Forms;
using System.Text;

namespace DosyaSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                foreach (string file in files)
                {
                    textBox1.Text = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EBS Securty");
            }
        }
   }
}
