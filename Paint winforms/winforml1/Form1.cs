using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Reflection;

namespace winforml1
{
    public partial class Form1 : Form
    {
        private Bitmap drawArea;
        private static Pen pen_;
        public bool change_;
        public bool changeEllipse_;
        public bool changeRect_;
        public bool draw;
        public bool drawSquare;
        public bool drawEllipse;
        public const int r = 2;
        public int x, y, sX, sY, cX, cY;
        public int index;
        Pen p = new Pen(Color.Black, 1);

        //public Form1(CultureInfo culture)
        //{
        //    InitializeComponent();

        //    Thread.CurrentThread.CurrentCulture = culture;
        //    Thread.CurrentThread.CurrentUICulture = culture;

        //    ResourceManager rm = new ResourceManager("winforml1.Form1", System.Reflection.Assembly.GetExecutingAssembly());

        //    this.Text = this.Text + " " + DateTime.Now.ToLongDateString();
            
        //    toolStripLabelFile.Text = rm.GetString("toolStripLabelFile");
        //    toolStripLabelTools.Text = rm.GetString("toolStripLabelTools");
        //    toolStripLabelThick.Text = rm.GetString("toolStripLabelThick");
        //    toolStripLabelChosenColor.Text = rm.GetString("toolStripLabelChosenColor");
        //    toolStripLabelLanguage.Text = rm.GetString("toolStripLabelLanguage");
        //    groupBox1.Text = rm.GetString("groupBox1");
        //}

        public Form1()
        {
            InitializeComponent();        
            drawArea = new Bitmap(Pbox.Size.Width, Pbox.Size.Height);
            Pbox.Image = drawArea;
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }

            pen_ = new Pen(Brushes.Black, 3);
            toolStripButtonChosenColor.BackColor = Color.Black;

            toolStripComboBoxThick.Items.Add("1");
            toolStripComboBoxThick.Items.Add("2");
            toolStripComboBoxThick.Items.Add("3");
            toolStripComboBoxThick.Text = "1";

            //int up_ , left_ = 0;
            //int Count = 20;
            //PictureBox[] pbs = new PictureBox[Count];
            //for (int i = 0; i < Count; i++)
            //{
            //    pbs[i] = new PictureBox();
            //    pbs[i].Top = up_;
            //    pbs[i].Left = left_;
            //    pbs[i].Size = new Size(25, 25);
            //    pbs[i].BackColor = 
            //    pbs[i].Click += new EventHandler(DrawArea);
            //}


            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                Button button = new Button();
                button.BackColor = Color.FromKnownColor(color);
                button.Size = new Size(25, 25);
                button.Name = color.ToString();
                button.Click += new EventHandler(btnC_Event);
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "png";
            save.Filter = "Png Image| *.png | Bitmap Image | *.bmp | Jpeg Image | *.jpg"; ;  //"Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (save.ShowDialog() == DialogResult.OK)
            { 
                drawArea.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Loads(object sender, EventArgs e)
        {
            //    OpenFileDialog fileDialog = new OpenFileDialog();
            //    fileDialog.DefaultExt = "jpg";
            //    fileDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF";
            //    if (fileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        tableLayoutPanel1.GetControlFromPosition(0, 0).BackgroundImage =
            //        new Bitmap(fileDialog.FileName);
            //        tableLayoutPanel1.GetControlFromPosition(0, 0).BackgroundImageLayout =
            //        ImageLayout.Stretch;
            //    }
            String imageLocation = "";
    
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    Pbox.ImageLocation = imageLocation;
                }  
        }

        private void Trash_C(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
                Pbox.Refresh();

            }
        }

        public void DrawPoint(int x, int y, Color color)
        {
            Graphics g = this.Pbox.CreateGraphics();
            Pen pen = new Pen(color);
            g.DrawRectangle(pen, x, y, 3, 3);
        }

     

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            change_ = !change_;
            toolStripButton1.Checked = change_;
            index = 1;
        }



       
        private void Pbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                draw = true;

            cX = e.X;
            cY = e.Y;

        }
        private void Pbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw && change_ && index == 1)
            {         
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.FillEllipse(Brushes.Black, e.X - r, e.Y - r, r * 3, r * 3);

                }
                Pbox.Refresh();
            }
            Pbox.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
            
        }
        private void Pbox_MouseUp_1(object sender, MouseEventArgs e)
        {
            draw = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 2 )
            {
                
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
               
            }
            if(index == 3)
            {
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    Pen blackPen = new Pen(Color.Black, 5);
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            index = 2;

            changeEllipse_ = !changeEllipse_;
            toolStripButtonEllipse.Checked = changeEllipse_;
           

        }

        private void toolStripButtonRect_Click(object sender, EventArgs e)
        {
            index = 3;
            changeRect_ = !changeRect_;
            toolStripButtonRect.Checked = changeRect_;
         
        }

        private void toolStripButtonPL_Click(object sender, EventArgs e)
        {

            //Form1 f = new Form1(new CultureInfo("pl-PL"));
            //f.ShowDialog();
            //Thread.CurrentThread.CurrentCulture = new(("pl-PL"));
            //Thread.CurrentThread.CurrentUICulture = new(("pl-PL"));

            ResourceManager rm = new ResourceManager("winforml1.Properties.Resources", Assembly.GetExecutingAssembly());
            FileToolStripLabel.Text = rm.GetString("Files");
            ToolStripLabel.Text = rm.GetString("Tools");
            ThicknessToolStripLabel.Text = rm.GetString("Thickness");
            ChosenColorToolStripLabel.Text = rm.GetString("Chosen Color");
            LangaugeToolStripLabel.Text = rm.GetString("Langauge");
            ColorsGroupBox.Text = rm.GetString("Colors");
        }

        private void toolStripButtonEN_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1(new CultureInfo("en-US"));
            //f.ShowDialog();
            //Thread.CurrentThread.CurrentCulture = new(("en-EN"));
            //Thread.CurrentThread.CurrentUICulture = new(("en-EN"));

            ResourceManager rm = new ResourceManager("winforml1.Properties.en_local", Assembly.GetExecutingAssembly());
            FileToolStripLabel.Text = rm.GetString("Akta");
            ToolStripLabel.Text = rm.GetString("Narzędzia");
            ThicknessToolStripLabel.Text = rm.GetString("grubość");
            ChosenColorToolStripLabel.Text = rm.GetString("Wybrany kolor");
            LangaugeToolStripLabel.Text = rm.GetString("Język");
            ColorsGroupBox.Text = rm.GetString("Zabarwienie");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void toolStripLabelTools_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pbox_Click(object sender, EventArgs e)
        {

        }
        private void btnC_Event(object sender, EventArgs e)
        {
            toolStripButtonChosenColor.BackColor = pen_.Color = ((Button)sender).BackColor;
        }
    }
}
