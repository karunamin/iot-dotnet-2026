namespace DotNet04ControlsApp
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            BtnDialog = new Button();
            BtnMsgbox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgStatus = new ProgressBar();
            TrkStatus = new TrackBar();
            groupBox3 = new GroupBox();
            BtnAddRoot = new Button();
            BtnAddNode = new Button();
            LvwDummy = new ListView();
            ImgDummy = new ImageList(components);
            TvwDummy = new TreeView();
            groupBox4 = new GroupBox();
            BtnLoadImg = new Button();
            PicImage = new PictureBox();
            groupBox5 = new GroupBox();
            TxtLog = new TextBox();
            BtnStop = new Button();
            BtnThread = new Button();
            BtnNoThread = new Button();
            PrgProcess = new ProgressBar();
            groupBox6 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            RtbEditor = new RichTextBox();
            DlgOpenFile = new OpenFileDialog();
            WrkProcess = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(BtnDialog);
            groupBox1.Controls.Add(BtnMsgbox);
            groupBox1.Controls.Add(BtnModaless);
            groupBox1.Controls.Add(BtnModal);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(297, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "기본 컨트롤";
            // 
            // BtnDialog
            // 
            BtnDialog.Location = new Point(251, 73);
            BtnDialog.Margin = new Padding(2);
            BtnDialog.Name = "BtnDialog";
            BtnDialog.Size = new Size(41, 22);
            BtnDialog.TabIndex = 9;
            BtnDialog.Text = "...";
            BtnDialog.UseVisualStyleBackColor = true;
            BtnDialog.Click += BtnDialog_Click;
            // 
            // BtnMsgbox
            // 
            BtnMsgbox.Location = new Point(166, 73);
            BtnMsgbox.Margin = new Padding(2);
            BtnMsgbox.Name = "BtnMsgbox";
            BtnMsgbox.Size = new Size(81, 22);
            BtnMsgbox.TabIndex = 8;
            BtnMsgbox.Text = "메시지창";
            BtnMsgbox.UseVisualStyleBackColor = true;
            BtnMsgbox.Click += BtnMsgbox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(79, 73);
            BtnModaless.Margin = new Padding(2);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(82, 22);
            BtnModaless.TabIndex = 7;
            BtnModaless.Text = "모달리스";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(14, 73);
            BtnModal.Margin = new Padding(2);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(60, 22);
            BtnModal.TabIndex = 6;
            BtnModal.Text = "모달";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(14, 48);
            TxtResult.Margin = new Padding(2);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(279, 23);
            TxtResult.TabIndex = 5;
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Location = new Point(230, 24);
            ChkItalic.Margin = new Padding(2);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(62, 19);
            ChkItalic.TabIndex = 4;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Location = new Point(178, 24);
            ChkBold.Margin = new Padding(2);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 3;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(49, 22);
            CboFonts.Margin = new Padding(2);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(125, 23);
            CboFonts.TabIndex = 2;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(PrgStatus);
            groupBox2.Controls.Add(TrkStatus);
            groupBox2.Location = new Point(9, 115);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(297, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 진행바";
            // 
            // PrgStatus
            // 
            PrgStatus.Location = new Point(14, 66);
            PrgStatus.Margin = new Padding(2);
            PrgStatus.Name = "PrgStatus";
            PrgStatus.Size = new Size(278, 22);
            PrgStatus.TabIndex = 11;
            PrgStatus.Value = 10;
            // 
            // TrkStatus
            // 
            TrkStatus.Location = new Point(14, 20);
            TrkStatus.Margin = new Padding(2);
            TrkStatus.Maximum = 100;
            TrkStatus.Name = "TrkStatus";
            TrkStatus.Size = new Size(278, 45);
            TrkStatus.TabIndex = 10;
            TrkStatus.TickFrequency = 5;
            TrkStatus.Scroll += TrkStatus_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(BtnAddRoot);
            groupBox3.Controls.Add(BtnAddNode);
            groupBox3.Controls.Add(LvwDummy);
            groupBox3.Controls.Add(TvwDummy);
            groupBox3.Location = new Point(9, 218);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(297, 188);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "트리, 리스트뷰";
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(142, 161);
            BtnAddRoot.Margin = new Padding(2);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(73, 22);
            BtnAddRoot.TabIndex = 14;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // BtnAddNode
            // 
            BtnAddNode.Location = new Point(219, 161);
            BtnAddNode.Margin = new Padding(2);
            BtnAddNode.Name = "BtnAddNode";
            BtnAddNode.Size = new Size(73, 22);
            BtnAddNode.TabIndex = 15;
            BtnAddNode.Text = "노드추가";
            BtnAddNode.UseVisualStyleBackColor = true;
            BtnAddNode.Click += BtnAddNode_Click;
            // 
            // LvwDummy
            // 
            LvwDummy.LargeImageList = ImgDummy;
            LvwDummy.Location = new Point(152, 20);
            LvwDummy.Margin = new Padding(2);
            LvwDummy.Name = "LvwDummy";
            LvwDummy.Size = new Size(141, 138);
            LvwDummy.SmallImageList = ImgDummy;
            LvwDummy.TabIndex = 13;
            LvwDummy.UseCompatibleStateImageBehavior = false;
            // 
            // ImgDummy
            // 
            ImgDummy.ColorDepth = ColorDepth.Depth32Bit;
            ImgDummy.ImageStream = (ImageListStreamer)resources.GetObject("ImgDummy.ImageStream");
            ImgDummy.TransparentColor = Color.Transparent;
            ImgDummy.Images.SetKeyName(0, "folder.png");
            ImgDummy.Images.SetKeyName(1, "file.png");
            // 
            // TvwDummy
            // 
            TvwDummy.ImageIndex = 0;
            TvwDummy.ImageList = ImgDummy;
            TvwDummy.Location = new Point(5, 20);
            TvwDummy.Margin = new Padding(2);
            TvwDummy.Name = "TvwDummy";
            TvwDummy.SelectedImageIndex = 0;
            TvwDummy.Size = new Size(144, 138);
            TvwDummy.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(BtnLoadImg);
            groupBox4.Controls.Add(PicImage);
            groupBox4.Location = new Point(311, 9);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(297, 225);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "픽쳐박스";
            // 
            // BtnLoadImg
            // 
            BtnLoadImg.Location = new Point(219, 199);
            BtnLoadImg.Margin = new Padding(2);
            BtnLoadImg.Name = "BtnLoadImg";
            BtnLoadImg.Size = new Size(73, 22);
            BtnLoadImg.TabIndex = 1;
            BtnLoadImg.Text = "이미지";
            BtnLoadImg.UseVisualStyleBackColor = true;
            BtnLoadImg.Click += BtnLoadImg_Click;
            // 
            // PicImage
            // 
            PicImage.Location = new Point(5, 20);
            PicImage.Margin = new Padding(2);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(288, 175);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            PicImage.Click += PicImage_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(TxtLog);
            groupBox5.Controls.Add(BtnStop);
            groupBox5.Controls.Add(BtnThread);
            groupBox5.Controls.Add(BtnNoThread);
            groupBox5.Controls.Add(PrgProcess);
            groupBox5.Location = new Point(311, 238);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(297, 167);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "스레드";
            // 
            // TxtLog
            // 
            TxtLog.BorderStyle = BorderStyle.FixedSingle;
            TxtLog.Location = new Point(0, 21);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(293, 88);
            TxtLog.TabIndex = 4;
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(217, 139);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 3;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(136, 140);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(75, 23);
            BtnThread.TabIndex = 2;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnNoThread
            // 
            BtnNoThread.Location = new Point(55, 139);
            BtnNoThread.Name = "BtnNoThread";
            BtnNoThread.Size = new Size(75, 23);
            BtnNoThread.TabIndex = 1;
            BtnNoThread.Text = "노스레드";
            BtnNoThread.UseVisualStyleBackColor = true;
            BtnNoThread.Click += BtnNoThread_Click;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(0, 115);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(292, 23);
            PrgProcess.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(RtbEditor);
            groupBox6.Location = new Point(613, 9);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(297, 397);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "텍스트에디터";
            // 
            // button2
            // 
            button2.Location = new Point(217, 371);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "파일세이브";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(136, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "파일로드";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RtbEditor
            // 
            RtbEditor.BorderStyle = BorderStyle.None;
            RtbEditor.Location = new Point(5, 20);
            RtbEditor.Name = "RtbEditor";
            RtbEditor.Size = new Size(287, 345);
            RtbEditor.TabIndex = 0;
            RtbEditor.Text = "";
            // 
            // DlgOpenFile
            // 
            DlgOpenFile.FileName = "텍스트 파일을 선택하세요";
            DlgOpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DlgOpenFile.InitialDirectory = "C:\\SourceBank";
            DlgOpenFile.Title = "텍스트 파일 열기";
            // 
            // WrkProcess
            // 
            WrkProcess.DoWork += WrkProcess_DoWork;
            WrkProcess.ProgressChanged += WrkProcess_ProgressChanged;
            WrkProcess.RunWorkerCompleted += WrkProcess_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 415);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }







        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox TxtResult;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private Label label1;
        private Button BtnDialog;
        private Button BtnMsgbox;
        private Button BtnModaless;
        private Button BtnModal;
        private OpenFileDialog DlgOpenFile;
        private ProgressBar PrgStatus;
        private TrackBar TrkStatus;
        private ListView LvwDummy;
        private TreeView TvwDummy;
        private Button BtnAddRoot;
        private Button BtnAddNode;
        private ImageList ImgDummy;
        private Button BtnLoadImg;
        private PictureBox PicImage;
        private TextBox TxtLog;
        private Button BtnStop;
        private Button BtnThread;
        private Button BtnNoThread;
        private ProgressBar PrgProcess;
        private System.ComponentModel.BackgroundWorker WrkProcess;
        private RichTextBox RtbEditor;
        private Button button2;
        private Button button1;
    }
}
