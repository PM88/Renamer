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
        enum SearchItems { Files, Folders}
        public MainForm()
        { InitializeComponent(); }
        private void UpdateCounterAll()
        { this.txtCountAll.Text = this.chkFoundItems.Items.Count.ToString(); UpdateCounterChecked(); }
        private void UpdateCounterChecked()
        { this.txtCountChecked.Text = this.chkFoundItems.CheckedIndices.Count.ToString(); }
        private void btnFiles_Click(object sender, EventArgs e) { Search(SearchItems.Files); }
        private void btnFolders_Click(object sender, EventArgs e) { Search(SearchItems.Folders); }
        private void Search(SearchItems sItem)
        {
            if (this.txtWhere.Text == "") { MessageBox.Show("Please choose where to search"); return; }
            this.chkFoundItems.Items.Clear();
            string[] foundItems;
            if (sItem == SearchItems.Files)
            { foundItems = Directory.GetFiles(this.txtWhere.Text, "*" + this.txtFind.Text + "*", SearchOption.AllDirectories); }
            else
            { foundItems = Directory.GetDirectories(this.txtWhere.Text, "*" + this.txtFind.Text + "*", SearchOption.AllDirectories); }
            if (foundItems.Count() == 0) { MessageBox.Show("No Items found"); }
            else { this.chkFoundItems.Items.AddRange(foundItems); }
            UpdateCounterAll();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            { this.txtWhere.Text = folderBrowserDialog.SelectedPath; }
        }
        private void chkFoundItems_SelectedIndexChanged(object sender, EventArgs e)
        { UpdateCounterChecked(); }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.chkFoundItems.Items.Count; i++)
            { this.chkFoundItems.SetItemChecked(i, true); }
            UpdateCounterChecked();
        }
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            foreach (int i in this.chkFoundItems.CheckedIndices)
            { this.chkFoundItems.SetItemCheckState(i, CheckState.Unchecked); }
            UpdateCounterChecked();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            string oldName = string.Empty;
            if (this.chkFoundItems.CheckedItems.Count == 0) { MessageBox.Show("No items selected!"); return; }
            try
            { 
                foreach (string itemToRename in this.chkFoundItems.CheckedItems)
                { 
                    DirectoryInfo dirInfo = new DirectoryInfo(itemToRename);
                    oldName = dirInfo.Name;
                    string newName = oldName.Replace(this.txtFind.Text, this.txtReplace.Text);
                    RenameTo(dirInfo, newName); 
                }
                this.chkFoundItems.Items.Clear();
                UpdateCounterAll();
                MessageBox.Show("Finished");
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + Environment.NewLine + @"Problematic file/folder: " + oldName); }
        }
        //private DirectoryInfo DirectoryInfo(string s)
        //{
        //    throw new NotImplementedException();
        //}
        public static void RenameTo(DirectoryInfo dirInfo, string newName)//this direct
        {
            if (dirInfo == null)
            { throw new ArgumentNullException("di", "Directory info to rename cannot be null"); }

            if (string.IsNullOrWhiteSpace(newName))
            { throw new ArgumentException("Old string cannot be null or blank", "Chars"); }

            string oldName = dirInfo.Name;
            if (oldName == newName) { return; }

            string oldFolder = dirInfo.Parent.FullName;
            string newFullName = Path.Combine(oldFolder, newName);

            dirInfo.MoveTo(newFullName);

            //return; //done
        }
    }
}
