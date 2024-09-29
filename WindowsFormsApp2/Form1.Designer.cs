namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.digColor = new System.Windows.Forms.ColorDialog();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPick = new System.Windows.Forms.Button();
            this.staForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreenBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOtherBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.mnuEditorMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.White;
            this.txtEditor.ContextMenuStrip = this.mnuEditorMenu;
            this.txtEditor.Location = new System.Drawing.Point(92, 88);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(573, 283);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "I am Girish K V , Intern at Quest Global";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPick);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.staPage);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnBlue);
            this.panel1.Controls.Add(this.btnGreen);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 187);
            this.panel1.TabIndex = 2;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(8, 81);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(84, 36);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(208, 81);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(84, 36);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBlue.Location = new System.Drawing.Point(108, 81);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(84, 36);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnColor.Location = new System.Drawing.Point(320, 81);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(84, 36);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColor,
            this.staForeColor});
            this.staPage.Location = new System.Drawing.Point(0, 161);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(791, 26);
            this.staPage.TabIndex = 4;
            this.staPage.Text = "statusStrip1";
            // 
            // staColor
            // 
            this.staColor.Name = "staColor";
            this.staColor.Size = new System.Drawing.Size(80, 20);
            this.staColor.Text = "Indian Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Background";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ForeGround";
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPick.Location = new System.Drawing.Point(428, 81);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(136, 36);
            this.btnPick.TabIndex = 7;
            this.btnPick.Text = "Pick Color";
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // staForeColor
            // 
            this.staForeColor.Name = "staForeColor";
            this.staForeColor.Size = new System.Drawing.Size(151, 20);
            this.staForeColor.Text = "toolStripStatusLabel1";
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnuFormat});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(791, 28);
            this.mnuBar.TabIndex = 4;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator3,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.mnuBlueBg,
            this.mnuGreenBg,
            this.mnuOtherBg,
            this.toolStripSeparator1,
            this.mnuFg});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(59, 24);
            this.mnuColor.Text = "Color";
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(254, 26);
            this.mnuBlueBg.Text = "Blue Background Color";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // mnuGreenBg
            // 
            this.mnuGreenBg.Name = "mnuGreenBg";
            this.mnuGreenBg.Size = new System.Drawing.Size(254, 26);
            this.mnuGreenBg.Text = "Green Background Color";
            this.mnuGreenBg.Click += new System.EventHandler(this.mnuGreenBg_Click);
            // 
            // mnuOtherBg
            // 
            this.mnuOtherBg.Name = "mnuOtherBg";
            this.mnuOtherBg.Size = new System.Drawing.Size(254, 26);
            this.mnuOtherBg.Text = "Other Background Color";
            this.mnuOtherBg.Click += new System.EventHandler(this.mnuOtherBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(254, 26);
            this.mnuFg.Text = "Foreground Color...";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(254, 26);
            this.mnuRedBg.Text = "Red BackGround Color";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuEditorMenu
            // 
            this.mnuEditorMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuGreen2,
            this.mnuBlue2});
            this.mnuEditorMenu.Name = "mnuEditorMenu";
            this.mnuEditorMenu.Size = new System.Drawing.Size(241, 76);
            // 
            // mnuRed2
            // 
            this.mnuRed2.Name = "mnuRed2";
            this.mnuRed2.Size = new System.Drawing.Size(240, 24);
            this.mnuRed2.Text = "Red Background Color";
            this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
            // 
            // mnuGreen2
            // 
            this.mnuGreen2.Name = "mnuGreen2";
            this.mnuGreen2.Size = new System.Drawing.Size(240, 24);
            this.mnuGreen2.Text = "Green Background Color";
            this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
            // 
            // mnuBlue2
            // 
            this.mnuBlue2.Name = "mnuBlue2";
            this.mnuBlue2.Size = new System.Drawing.Size(240, 24);
            this.mnuBlue2.Text = "Blue Background Color";
            this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.toolStripSeparator2,
            this.mnuLeft,
            this.mnuCenter,
            this.mnuRight});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(70, 24);
            this.mnuFormat.Text = "Format";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFont
            // 
            this.mnuFont.Image = global::WindowsFormsApp2.Properties.Resources._8542035_font_text_icon;
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(224, 26);
            this.mnuFont.Text = "Font...";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuLeft
            // 
            this.mnuLeft.Image = global::WindowsFormsApp2.Properties.Resources._8666712_align_left_icon;
            this.mnuLeft.Name = "mnuLeft";
            this.mnuLeft.Size = new System.Drawing.Size(224, 26);
            this.mnuLeft.Text = "AlignLeft";
            this.mnuLeft.Click += new System.EventHandler(this.mnuLeft_Click);
            // 
            // mnuCenter
            // 
            this.mnuCenter.Image = global::WindowsFormsApp2.Properties.Resources._9023962_text_align_center_fill_icon;
            this.mnuCenter.Name = "mnuCenter";
            this.mnuCenter.Size = new System.Drawing.Size(224, 26);
            this.mnuCenter.Text = "Align Center";
            this.mnuCenter.Click += new System.EventHandler(this.mnuCenter_Click);
            // 
            // mnuRight
            // 
            this.mnuRight.Image = global::WindowsFormsApp2.Properties.Resources._9110890_text_align_right_icon;
            this.mnuRight.Name = "mnuRight";
            this.mnuRight.Size = new System.Drawing.Size(224, 26);
            this.mnuRight.Text = "Align Right";
            this.mnuRight.Click += new System.EventHandler(this.mnuRight_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(224, 26);
            this.mnuSave.Text = "Save...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "mytext.txt";
            this.dlgOpen.Filter = "Text File (*.txt) | JSON File (*.json)";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "mytext.txt";
            this.dlgSave.Filter = "Text File (*.txt) | JSON File (*.json)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp2.Properties.Resources._8666712_align_left_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources._9023962_text_align_center_fill_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources._9110890_text_align_right_icon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 591);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Editor App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.mnuEditorMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog digColor;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel staForeColor;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenBg;
        private System.Windows.Forms.ToolStripMenuItem mnuOtherBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip mnuEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRed2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

