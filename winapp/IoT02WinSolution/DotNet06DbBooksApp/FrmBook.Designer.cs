namespace DotNet06DbBooksApp
{
    partial class FrmBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            fileSystemWatcher1 = new FileSystemWatcher();
            DgvBooks = new DataGridView();
            BtnLoad = new MaterialSkin.Controls.MaterialButton();
            BtnNew = new MaterialSkin.Controls.MaterialButton();
            BtnEdit = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvBooks).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DgvBooks
            // 
            DgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBooks.Location = new Point(15, 79);
            DgvBooks.Name = "DgvBooks";
            DgvBooks.Size = new Size(735, 275);
            DgvBooks.TabIndex = 0;
            // 
            // BtnLoad
            // 
            BtnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnLoad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnLoad.Depth = 0;
            BtnLoad.HighEmphasis = true;
            BtnLoad.Icon = null;
            BtnLoad.Location = new Point(472, 368);
            BtnLoad.Margin = new Padding(4, 6, 4, 6);
            BtnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            BtnLoad.Name = "BtnLoad";
            BtnLoad.NoAccentTextColor = Color.Empty;
            BtnLoad.Size = new Size(64, 36);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Load";
            BtnLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnLoad.UseAccentColor = false;
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNew.Depth = 0;
            BtnNew.HighEmphasis = true;
            BtnNew.Icon = null;
            BtnNew.Location = new Point(544, 368);
            BtnNew.Margin = new Padding(4, 6, 4, 6);
            BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            BtnNew.Name = "BtnNew";
            BtnNew.NoAccentTextColor = Color.Empty;
            BtnNew.Size = new Size(64, 36);
            BtnNew.TabIndex = 2;
            BtnNew.Text = "New";
            BtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNew.UseAccentColor = false;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEdit.Depth = 0;
            BtnEdit.HighEmphasis = true;
            BtnEdit.Icon = null;
            BtnEdit.Location = new Point(616, 368);
            BtnEdit.Margin = new Padding(4, 6, 4, 6);
            BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.NoAccentTextColor = Color.Empty;
            BtnEdit.Size = new Size(64, 36);
            BtnEdit.TabIndex = 3;
            BtnEdit.Text = "Edit";
            BtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEdit.UseAccentColor = false;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(688, 368);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(73, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Delete";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 413);
            Controls.Add(materialButton2);
            Controls.Add(BtnEdit);
            Controls.Add(BtnNew);
            Controls.Add(BtnLoad);
            Controls.Add(DgvBooks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(490, 350);
            Name = "FrmBook";
            Text = "MySQL Books";
            Load += FrmBook_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private MaterialSkin.Controls.MaterialButton BtnLoad;
        private DataGridView DgvBooks;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnNew;
    }
}
