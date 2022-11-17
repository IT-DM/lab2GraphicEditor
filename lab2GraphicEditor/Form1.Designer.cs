namespace lab2GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDrawingSurface = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarPen = new System.Windows.Forms.TrackBar();
            this.labelXY = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openImgButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.penToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.undoToolStripMenuItem.Text = "Шаг назад";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.redoToolStripMenuItem.Text = "Шаг вперед";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.renoToolStripMenuItem_Click);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("penToolStripMenuItem.Image")));
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.penToolStripMenuItem.Text = "Ручка";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.dotToolStripMenuItem1,
            this.dashDotDotToolStripMenuItem1});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.styleToolStripMenuItem.Text = "Стиль";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.solidToolStripMenuItem1.Checked = true;
            this.solidToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(422, 26);
            this.solidToolStripMenuItem1.Text = "Сплошная";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
            // 
            // dotToolStripMenuItem1
            // 
            this.dotToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dotToolStripMenuItem1.Name = "dotToolStripMenuItem1";
            this.dotToolStripMenuItem1.Size = new System.Drawing.Size(422, 26);
            this.dotToolStripMenuItem1.Text = "Пунктирная";
            this.dotToolStripMenuItem1.Click += new System.EventHandler(this.dotToolStripMenuItem1_Click);
            // 
            // dashDotDotToolStripMenuItem1
            // 
            this.dashDotDotToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dashDotDotToolStripMenuItem1.Name = "dashDotDotToolStripMenuItem1";
            this.dashDotDotToolStripMenuItem1.Size = new System.Drawing.Size(422, 26);
            this.dashDotDotToolStripMenuItem1.Text = "Штрих-пунктирная линия с двойными точками";
            this.dashDotDotToolStripMenuItem1.Click += new System.EventHandler(this.dashDotDotToolStripMenuItem1_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.colorToolStripMenuItem.Text = "Цвет";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // picDrawingSurface
            // 
            this.picDrawingSurface.BackColor = System.Drawing.Color.White;
            this.picDrawingSurface.Location = new System.Drawing.Point(0, 5);
            this.picDrawingSurface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDrawingSurface.Name = "picDrawingSurface";
            this.picDrawingSurface.Size = new System.Drawing.Size(878, 551);
            this.picDrawingSurface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDrawingSurface.TabIndex = 1;
            this.picDrawingSurface.TabStop = false;
            this.picDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDown);
            this.picDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseMove);
            this.picDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBarPen);
            this.panel1.Controls.Add(this.labelXY);
            this.panel1.Location = new System.Drawing.Point(63, 572);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 88);
            this.panel1.TabIndex = 2;
            // 
            // trackBarPen
            // 
            this.trackBarPen.Location = new System.Drawing.Point(301, 22);
            this.trackBarPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarPen.Maximum = 20;
            this.trackBarPen.Minimum = 1;
            this.trackBarPen.Name = "trackBarPen";
            this.trackBarPen.Size = new System.Drawing.Size(552, 56);
            this.trackBarPen.TabIndex = 1;
            this.trackBarPen.Value = 5;
            this.trackBarPen.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXY.Location = new System.Drawing.Point(85, 32);
            this.labelXY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(79, 29);
            this.labelXY.TabIndex = 0;
            this.labelXY.Text = "label1";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.newButton,
            this.toolStripSeparator5,
            this.saveButton,
            this.toolStripSeparator4,
            this.openImgButton,
            this.toolStripSeparator2,
            this.colorButton,
            this.toolStripSeparator3,
            this.exitButton,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(67, 630);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(64, 6);
            // 
            // newButton
            // 
            this.newButton.AutoSize = false;
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Margin = new System.Windows.Forms.Padding(0);
            this.newButton.Name = "newButton";
            this.newButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newButton.Size = new System.Drawing.Size(66, 60);
            this.newButton.Text = "Новый";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(64, 6);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = false;
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(66, 60);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(64, 6);
            // 
            // openImgButton
            // 
            this.openImgButton.AutoSize = false;
            this.openImgButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openImgButton.Image = ((System.Drawing.Image)(resources.GetObject("openImgButton.Image")));
            this.openImgButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openImgButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImgButton.Margin = new System.Windows.Forms.Padding(0);
            this.openImgButton.Name = "openImgButton";
            this.openImgButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openImgButton.Size = new System.Drawing.Size(66, 60);
            this.openImgButton.Text = "Открыть изображение";
            this.openImgButton.Click += new System.EventHandler(this.openImgButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(64, 6);
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = false;
            this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorButton.Image = ((System.Drawing.Image)(resources.GetObject("colorButton.Image")));
            this.colorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorButton.Name = "colorButton";
            this.colorButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorButton.Size = new System.Drawing.Size(66, 68);
            this.colorButton.Text = "Выбрать цвет";
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(64, 6);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(66, 60);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(64, 6);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.picDrawingSurface);
            this.panel2.Location = new System.Drawing.Point(63, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 558);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(943, 658);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Лабораторная 2 графический редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDrawingSurface;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarPen;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openImgButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton colorButton;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel2;
    }
}

