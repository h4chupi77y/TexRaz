
namespace TR
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохрантьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСерединеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(837, 438);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.расположениеТекстаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохрантьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохрантьКакToolStripMenuItem
            // 
            this.сохрантьКакToolStripMenuItem.Name = "сохрантьКакToolStripMenuItem";
            this.сохрантьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохрантьКакToolStripMenuItem.Text = "Сохранть как";
            this.сохрантьКакToolStripMenuItem.Click += new System.EventHandler(this.сохрантьКакToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроитьШрифтToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // настроитьШрифтToolStripMenuItem
            // 
            this.настроитьШрифтToolStripMenuItem.Name = "настроитьШрифтToolStripMenuItem";
            this.настроитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настроитьШрифтToolStripMenuItem.Text = "Настроить шрифт";
            this.настроитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.настроитьШрифтToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.ToolTipText = "CTRL+C";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.ToolTipText = "CTRL+X";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.ToolTipText = "CTRL+V";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLAToolStripMenuItem});
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem.ToolTipText = "CTRL+A";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // cTRLAToolStripMenuItem
            // 
            this.cTRLAToolStripMenuItem.Name = "cTRLAToolStripMenuItem";
            this.cTRLAToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cTRLAToolStripMenuItem.Text = "CTRL+A";
            // 
            // расположениеТекстаToolStripMenuItem
            // 
            this.расположениеТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поСерединеToolStripMenuItem,
            this.слеваToolStripMenuItem,
            this.справоToolStripMenuItem});
            this.расположениеТекстаToolStripMenuItem.Name = "расположениеТекстаToolStripMenuItem";
            this.расположениеТекстаToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.расположениеТекстаToolStripMenuItem.Text = "Расположение текста";
            // 
            // поСерединеToolStripMenuItem
            // 
            this.поСерединеToolStripMenuItem.Name = "поСерединеToolStripMenuItem";
            this.поСерединеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поСерединеToolStripMenuItem.Text = "По середине";
            this.поСерединеToolStripMenuItem.ToolTipText = "CTRL + E";
            this.поСерединеToolStripMenuItem.Click += new System.EventHandler(this.поСерединеToolStripMenuItem_Click);
            // 
            // слеваToolStripMenuItem
            // 
            this.слеваToolStripMenuItem.Name = "слеваToolStripMenuItem";
            this.слеваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.слеваToolStripMenuItem.Text = "Слева";
            this.слеваToolStripMenuItem.ToolTipText = "CTRL+L";
            this.слеваToolStripMenuItem.Click += new System.EventHandler(this.слеваToolStripMenuItem_Click);
            // 
            // справоToolStripMenuItem
            // 
            this.справоToolStripMenuItem.Name = "справоToolStripMenuItem";
            this.справоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.справоToolStripMenuItem.Text = "Справо";
            this.справоToolStripMenuItem.ToolTipText = "CTRL+R";
            this.справоToolStripMenuItem.Click += new System.EventHandler(this.справоToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 462);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохрантьКакToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расположениеТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСерединеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLAToolStripMenuItem;
    }
}

