namespace KalkulatorDelegacji
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
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxSniadanie = new System.Windows.Forms.CheckBox();
            this.checkBoxObiad = new System.Windows.Forms.CheckBox();
            this.checkBoxKolacja = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lithuanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.monthCalendarStart.Location = new System.Drawing.Point(64, 21);
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 0;
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.monthCalendarEnd.Location = new System.Drawing.Point(59, 29);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.ShowTodayCircle = false;
            this.monthCalendarEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Godzina rozpoczęcia delegacji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godzina zakończenia delegacji:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStart.Location = new System.Drawing.Point(232, 196);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(101, 20);
            this.textBoxStart.TabIndex = 4;
            this.textBoxStart.Text = "8:00";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnd.Location = new System.Drawing.Point(228, 200);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 5;
            this.textBoxEnd.Text = "16:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(361, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zapewnione wyżywienie:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(39, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(778, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxSniadanie
            // 
            this.checkBoxSniadanie.AutoSize = true;
            this.checkBoxSniadanie.Checked = true;
            this.checkBoxSniadanie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSniadanie.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxSniadanie.Location = new System.Drawing.Point(364, 117);
            this.checkBoxSniadanie.Name = "checkBoxSniadanie";
            this.checkBoxSniadanie.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSniadanie.TabIndex = 9;
            this.checkBoxSniadanie.Text = "Śniadanie";
            this.checkBoxSniadanie.UseVisualStyleBackColor = true;
            // 
            // checkBoxObiad
            // 
            this.checkBoxObiad.AutoSize = true;
            this.checkBoxObiad.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxObiad.Location = new System.Drawing.Point(364, 154);
            this.checkBoxObiad.Name = "checkBoxObiad";
            this.checkBoxObiad.Size = new System.Drawing.Size(58, 17);
            this.checkBoxObiad.TabIndex = 10;
            this.checkBoxObiad.Text = "Obiad";
            this.checkBoxObiad.UseVisualStyleBackColor = true;
            // 
            // checkBoxKolacja
            // 
            this.checkBoxKolacja.AutoSize = true;
            this.checkBoxKolacja.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxKolacja.Location = new System.Drawing.Point(364, 190);
            this.checkBoxKolacja.Name = "checkBoxKolacja";
            this.checkBoxKolacja.Size = new System.Drawing.Size(65, 17);
            this.checkBoxKolacja.TabIndex = 11;
            this.checkBoxKolacja.Text = "Kolacja";
            this.checkBoxKolacja.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(35, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Za delegację należy się :";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.days.Location = new System.Drawing.Point(36, 429);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(28, 17);
            this.days.TabIndex = 15;
            this.days.Text = "dni";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hours.Location = new System.Drawing.Point(79, 429);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(50, 17);
            this.hours.TabIndex = 16;
            this.hours.Text = "godzin";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amount.Location = new System.Drawing.Point(212, 521);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(31, 19);
            this.amount.TabIndex = 17;
            this.amount.Text = "0 zł";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Czas w delegacji :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mENUToolStripMenuItem.Text = "Menu";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polandToolStripMenuItem,
            this.italyToolStripMenuItem,
            this.lithuanaToolStripMenuItem});
            this.countryToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.countryToolStripMenuItem.Text = "Kraj";
            // 
            // polandToolStripMenuItem
            // 
            this.polandToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polandToolStripMenuItem.Name = "polandToolStripMenuItem";
            this.polandToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polandToolStripMenuItem.Text = "Polska";
            this.polandToolStripMenuItem.Click += new System.EventHandler(this.polandToolStripMenuItem_Click);
            // 
            // italyToolStripMenuItem
            // 
            this.italyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.italyToolStripMenuItem.Name = "italyToolStripMenuItem";
            this.italyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.italyToolStripMenuItem.Text = "Włochy";
            this.italyToolStripMenuItem.Click += new System.EventHandler(this.italyToolStripMenuItem_Click);
            // 
            // lithuanaToolStripMenuItem
            // 
            this.lithuanaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lithuanaToolStripMenuItem.Name = "lithuanaToolStripMenuItem";
            this.lithuanaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.lithuanaToolStripMenuItem.Text = "Litwa";
            this.lithuanaToolStripMenuItem.Click += new System.EventHandler(this.lithuanaToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.eXITToolStripMenuItem.Text = "Wyjście";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aBOUTToolStripMenuItem.Text = "O programie";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendarStart);
            this.groupBox1.Controls.Add(this.textBoxStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 230);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozpoczęcie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendarEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxEnd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(524, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 230);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakończenie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(876, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.days);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxKolacja);
            this.Controls.Add(this.checkBoxObiad);
            this.Controls.Add(this.checkBoxSniadanie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator delegacji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxSniadanie;
        private System.Windows.Forms.CheckBox checkBoxObiad;
        private System.Windows.Forms.CheckBox checkBoxKolacja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lithuanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

