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

namespace The_Renamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chkFoundItems.Items.Clear();
            string[] files = Directory.GetFiles(this.txtWhere.Text, "*" + this.txtFind.Text + "*", SearchOption.AllDirectories);
            if (files.Count() == 0)
            {
                MessageBox.Show("No Items found");
            }
            else
            {
                //this.chkFoundItems.Items.Add("*All");
                this.chkFoundItems.Items.AddRange(files);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            { this.txtWhere.Text = folderBrowserDialog.SelectedPath; }
        }

        private void chkFoundItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.chkFoundItems.CheckedItems.Count == 1 && this.chkFoundItems.CheckedItems(0) = )
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.chkFoundItems.Items.Count; i++)
            { this.chkFoundItems.SetItemChecked(i, true); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (int i in this.chkFoundItems.CheckedIndices)
            { this.chkFoundItems.SetItemCheckState(i, CheckState.Unchecked); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chkFoundItems.Items.Clear();
            string[] files = Directory.GetDirectories(this.txtWhere.Text, "*" + this.txtFind.Text + "*", SearchOption.AllDirectories);
            if (files.Count() == 0)
            { MessageBox.Show("No Items found"); }
            else
            {
                //this.chkFoundItems.Items.Add("*All");
                this.chkFoundItems.Items.AddRange(files);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string s in this.chkFoundItems.CheckedItems)
            { 
                DirectoryInfo di = new DirectoryInfo(s);
                string oldName = di.Name;
                string newName = oldName.Replace(this.txtFind.Text, this.txtReplace.Text);
                RenameTo(di, newName); 
            }
            this.chkFoundItems.Items.Clear();
            MessageBox.Show("Finished");
        }
        //private DirectoryInfo DirectoryInfo(string s)
        //{
        //    throw new NotImplementedException();
        //}
        public static void RenameTo(DirectoryInfo di, string newName)//this direct
        {
            if (di == null)
            { throw new ArgumentNullException("di", "Directory info to rename cannot be null"); }

            if (string.IsNullOrWhiteSpace(newName))
            { throw new ArgumentException("Old string cannot be null or blank", "Chars"); }

            string oldPath = di.Parent.FullName;
            di.MoveTo(Path.Combine(oldPath, newName));

            //return; //done
        }
    }
}
