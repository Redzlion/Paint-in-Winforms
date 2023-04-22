
namespace winforml1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTrash = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ThicknessToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxThick = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ChosenColorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonChosenColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LangaugeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonEN = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPL = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Pbox = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ColorsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripLabel,
            this.toolStripButtonSave,
            this.toolStripButtonLoad,
            this.toolStripSeparator1,
            this.ToolStripLabel,
            this.toolStripButton1,
            this.toolStripButtonRect,
            this.toolStripButtonEllipse,
            this.toolStripButtonTrash,
            this.toolStripSeparator2,
            this.ThicknessToolStripLabel,
            this.toolStripComboBoxThick,
            this.toolStripSeparator3,
            this.ChosenColorToolStripLabel,
            this.toolStripButtonChosenColor,
            this.toolStripSeparator4,
            this.LangaugeToolStripLabel,
            this.toolStripButtonEN,
            this.toolStripButtonPL});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // FileToolStripLabel
            // 
            this.FileToolStripLabel.Name = "FileToolStripLabel";
            resources.ApplyResources(this.FileToolStripLabel, "FileToolStripLabel");
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.Save);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonLoad, "toolStripButtonLoad");
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.Loads);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ToolStripLabel
            // 
            this.ToolStripLabel.Name = "ToolStripLabel";
            resources.ApplyResources(this.ToolStripLabel, "ToolStripLabel");
            this.ToolStripLabel.Click += new System.EventHandler(this.toolStripLabelTools_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonRect
            // 
            this.toolStripButtonRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonRect, "toolStripButtonRect");
            this.toolStripButtonRect.Name = "toolStripButtonRect";
            this.toolStripButtonRect.Click += new System.EventHandler(this.toolStripButtonRect_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonEllipse, "toolStripButtonEllipse");
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonTrash
            // 
            this.toolStripButtonTrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonTrash, "toolStripButtonTrash");
            this.toolStripButtonTrash.Name = "toolStripButtonTrash";
            this.toolStripButtonTrash.Click += new System.EventHandler(this.Trash_C);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ThicknessToolStripLabel
            // 
            this.ThicknessToolStripLabel.Name = "ThicknessToolStripLabel";
            resources.ApplyResources(this.ThicknessToolStripLabel, "ThicknessToolStripLabel");
            // 
            // toolStripComboBoxThick
            // 
            this.toolStripComboBoxThick.Name = "toolStripComboBoxThick";
            resources.ApplyResources(this.toolStripComboBoxThick, "toolStripComboBoxThick");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // ChosenColorToolStripLabel
            // 
            this.ChosenColorToolStripLabel.Name = "ChosenColorToolStripLabel";
            resources.ApplyResources(this.ChosenColorToolStripLabel, "ChosenColorToolStripLabel");
            // 
            // toolStripButtonChosenColor
            // 
            this.toolStripButtonChosenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonChosenColor, "toolStripButtonChosenColor");
            this.toolStripButtonChosenColor.Name = "toolStripButtonChosenColor";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // LangaugeToolStripLabel
            // 
            this.LangaugeToolStripLabel.Name = "LangaugeToolStripLabel";
            resources.ApplyResources(this.LangaugeToolStripLabel, "LangaugeToolStripLabel");
            // 
            // toolStripButtonEN
            // 
            this.toolStripButtonEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonEN, "toolStripButtonEN");
            this.toolStripButtonEN.Name = "toolStripButtonEN";
            this.toolStripButtonEN.Click += new System.EventHandler(this.toolStripButtonEN_Click);
            // 
            // toolStripButtonPL
            // 
            this.toolStripButtonPL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonPL, "toolStripButtonPL");
            this.toolStripButtonPL.Name = "toolStripButtonPL";
            this.toolStripButtonPL.Click += new System.EventHandler(this.toolStripButtonPL_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.ColorsGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pbox, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ColorsGroupBox
            // 
            this.ColorsGroupBox.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.ColorsGroupBox, "ColorsGroupBox");
            this.ColorsGroupBox.Name = "ColorsGroupBox";
            this.ColorsGroupBox.TabStop = false;
            this.ColorsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Pbox
            // 
            resources.ApplyResources(this.Pbox, "Pbox");
            this.Pbox.Name = "Pbox";
            this.Pbox.TabStop = false;
            this.Pbox.Click += new System.EventHandler(this.Pbox_Click);
            this.Pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pbox_MouseDown);
            this.Pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pbox_MouseMove);
            this.Pbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pbox_MouseUp_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ColorsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Pbox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox ColorsGroupBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripLabel FileToolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrush;
        private System.Windows.Forms.ToolStripButton toolStripButtonRect;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonTrash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ThicknessToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxThick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ChosenColorToolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonChosenColor;
        private System.Windows.Forms.ToolStripLabel LangaugeToolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonEN;
        private System.Windows.Forms.ToolStripButton toolStripButtonPL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

