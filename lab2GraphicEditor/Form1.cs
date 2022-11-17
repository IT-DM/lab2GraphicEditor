using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2GraphicEditor
{
    public partial class Form1 : Form
    {

        bool drawing;
        int historyCounter = 0;      //Счетчик истории

        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;

        Color historyColor;

        Color Scroll_Red;

        List<Image> History;    //Список для истории



        public Form1()
        {
            InitializeComponent();
            drawing = false;                     //Переменная, ответственная за рисование
            currentPen = new Pen(Color.Black);   //Инициализация пера с черным цветом
            currentPen.Width = trackBarPen.Value;   //Инициализация толщины пера
            History = new List<Image>();            //Инициализация списка для истории


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(878, 551);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));

        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }


            drawing = true;
            oldLocation = e.Location;
            currentPath = new GraphicsPath();





            if (e.Button == MouseButtons.Right)
            {
                currentPen.Color = Color.White;




            }
            else {
                historyColor = currentPen.Color;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;    //По умолчанию будет выбрано последнее расширение *.png

            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")     //Если введено не пустое имя
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:

                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;

                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }

                fs.Close();
            }

            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg
            
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);

            picDrawingSurface.AutoSize = true;

        }

        private void newButton_Click(object sender, EventArgs e)
        {


            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(878, 551);
            picDrawingSurface.Image = pic;

            Graphics g = Graphics.FromImage(picDrawingSurface.Image);

            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 878, 551);
            History.Add(new Bitmap(picDrawingSurface.Image));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;    //По умолчанию будет выбрано последнее расширение *.png

            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")     //Если введено не пустое имя
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;

                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }

                fs.Close();
            }

            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

        }

        private void openImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);

            picDrawingSurface.AutoSize = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout AddRec = new FormAbout();

            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {

            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;


            if (historyCounter == 9)
            {
                //Очистка ненужной истории
                History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);

                if (History.Count - 1 == 10) History.RemoveAt(0);
            }

            drawing = false;
            try
            {
                currentPath.Dispose();

            }
            catch { };

            currentPen.Color = historyColor;

        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);



                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
            labelXY.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void renoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;

            solidToolStripMenuItem1.Checked = true;
            dotToolStripMenuItem1.Checked = false;
            dashDotDotToolStripMenuItem1.Checked = false;

        }

        private void dotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;

            solidToolStripMenuItem1.Checked = false;
            dotToolStripMenuItem1.Checked = true;
            dashDotDotToolStripMenuItem1.Checked = false;
        }

        private void dashDotDotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dash;

            solidToolStripMenuItem1.Checked = false;
            dotToolStripMenuItem1.Checked = false;
            dashDotDotToolStripMenuItem1.Checked = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                currentPen.Color = colorDialog.Color;

            }

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                currentPen.Color = colorDialog.Color;

            }
        }
    }
}
