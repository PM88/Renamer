namespace The_Renamer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkFoundItems = new System.Windows.Forms.CheckedListBox();
            this.btnFiles = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFolders = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountAll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountChecked = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkFoundItems
            // 
            this.chkFoundItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFoundItems.CheckOnClick = true;
            this.chkFoundItems.FormattingEnabled = true;
            this.chkFoundItems.HorizontalScrollbar = true;
            this.chkFoundItems.Location = new System.Drawing.Point(12, 166);
            this.chkFoundItems.Name = "chkFoundItems";
            this.chkFoundItems.Size = new System.Drawing.Size(590, 304);
            this.chkFoundItems.TabIndex = 0;
            this.chkFoundItems.SelectedIndexChanged += new System.EventHandler(this.chkFoundItems_SelectedIndexChanged);
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(26, 63);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(75, 23);
            this.btnFiles.TabIndex = 1;
            this.btnFiles.Text = "Files";
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(26, 37);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(167, 20);
            this.txtFind.TabIndex = 2;
            // 
            // btnFolders
            // 
            this.btnFolders.Location = new System.Drawing.Point(118, 63);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(75, 23);
            this.btnFolders.TabIndex = 3;
            this.btnFolders.Text = "Folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(245, 37);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(150, 20);
            this.txtReplace.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Replace with";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(245, 63);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(527, 111);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Where";
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(26, 111);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(495, 20);
            this.txtWhere.TabIndex = 8;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(26, 137);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Check all";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.Location = new System.Drawing.Point(107, 137);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(75, 23);
            this.btnUncheck.TabIndex = 13;
            this.btnUncheck.Text = "Uncheck all";
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "All";
            // 
            // txtCountAll
            // 
            this.txtCountAll.Enabled = false;
            this.txtCountAll.Location = new System.Drawing.Point(527, 139);
            this.txtCountAll.Name = "txtCountAll";
            this.txtCountAll.Size = new System.Drawing.Size(75, 20);
            this.txtCountAll.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Checked";
            // 
            // txtCountChecked
            // 
            this.txtCountChecked.Enabled = false;
            this.txtCountChecked.Location = new System.Drawing.Point(422, 139);
            this.txtCountChecked.Name = "txtCountChecked";
            this.txtCountChecked.Size = new System.Drawing.Size(75, 20);
            this.txtCountChecked.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountChecked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountAll);
            this.Controls.Add(this.btnUncheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.chkFoundItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "The Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkFoundItems;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUncheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountChecked;
    }
}

