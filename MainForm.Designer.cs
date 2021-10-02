
namespace ISS_LB1
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsgButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMsgAs = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openKey = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKey = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyAs = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCipherAs = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsgButton,
            this.KeyButton,
            this.результатToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsgButton
            // 
            this.MsgButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMsg,
            this.saveMsg,
            this.saveMsgAs});
            this.MsgButton.Name = "MsgButton";
            this.MsgButton.Size = new System.Drawing.Size(105, 24);
            this.MsgButton.Text = "Сообщение";
            this.MsgButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openMsg
            // 
            this.openMsg.Name = "openMsg";
            this.openMsg.Size = new System.Drawing.Size(192, 26);
            this.openMsg.Text = "Открыть";
            this.openMsg.Click += new System.EventHandler(this.openMsg_Click);
            // 
            // saveMsg
            // 
            this.saveMsg.Enabled = false;
            this.saveMsg.Name = "saveMsg";
            this.saveMsg.Size = new System.Drawing.Size(192, 26);
            this.saveMsg.Text = "Сохранить";
            this.saveMsg.Click += new System.EventHandler(this.saveMsg_Click);
            // 
            // saveMsgAs
            // 
            this.saveMsgAs.Name = "saveMsgAs";
            this.saveMsgAs.Size = new System.Drawing.Size(192, 26);
            this.saveMsgAs.Text = "Сохранить как";
            this.saveMsgAs.Click += new System.EventHandler(this.saveMsgAs_Click);
            // 
            // KeyButton
            // 
            this.KeyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openKey,
            this.saveKey,
            this.saveKeyAs,
            this.сгенерироватьЗановоToolStripMenuItem});
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(60, 24);
            this.KeyButton.Text = "Ключ";
            this.KeyButton.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // openKey
            // 
            this.openKey.Name = "openKey";
            this.openKey.Size = new System.Drawing.Size(252, 26);
            this.openKey.Text = "Открыть";
            this.openKey.Click += new System.EventHandler(this.openKey_Click);
            // 
            // saveKey
            // 
            this.saveKey.Enabled = false;
            this.saveKey.Name = "saveKey";
            this.saveKey.Size = new System.Drawing.Size(252, 26);
            this.saveKey.Text = "Сохранить";
            this.saveKey.Click += new System.EventHandler(this.saveKey_Click);
            // 
            // saveKeyAs
            // 
            this.saveKeyAs.Name = "saveKeyAs";
            this.saveKeyAs.Size = new System.Drawing.Size(252, 26);
            this.saveKeyAs.Text = "Сохранить как";
            this.saveKeyAs.Click += new System.EventHandler(this.saveKeyAs_Click);
            // 
            // сгенерироватьЗановоToolStripMenuItem
            // 
            this.сгенерироватьЗановоToolStripMenuItem.Name = "сгенерироватьЗановоToolStripMenuItem";
            this.сгенерироватьЗановоToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.сгенерироватьЗановоToolStripMenuItem.Text = "Сгенерировать заново";
            this.сгенерироватьЗановоToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьЗановоToolStripMenuItem_Click);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCipher,
            this.saveCipher,
            this.saveCipherAs});
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.результатToolStripMenuItem.Text = "Зашифрованное сообщение";
            // 
            // openCipher
            // 
            this.openCipher.Name = "openCipher";
            this.openCipher.Size = new System.Drawing.Size(192, 26);
            this.openCipher.Text = "Открыть";
            this.openCipher.Click += new System.EventHandler(this.openCipher_Click);
            // 
            // saveCipher
            // 
            this.saveCipher.Enabled = false;
            this.saveCipher.Name = "saveCipher";
            this.saveCipher.Size = new System.Drawing.Size(192, 26);
            this.saveCipher.Text = "Сохранить";
            this.saveCipher.Click += new System.EventHandler(this.saveCipher_Click);
            // 
            // saveCipherAs
            // 
            this.saveCipherAs.Name = "saveCipherAs";
            this.saveCipherAs.Size = new System.Drawing.Size(192, 26);
            this.saveCipherAs.Text = "Сохранить как";
            this.saveCipherAs.Click += new System.EventHandler(this.saveCipherAs_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(452, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Зашифрованное сообщение";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Двоичная запись";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(214, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Шестнадцатеричная запись";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(158, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Символьная запись";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(408, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 132);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Шифратор ЛБ1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsgButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem KeyButton;
        private System.Windows.Forms.ToolStripMenuItem openMsg;
        private System.Windows.Forms.ToolStripMenuItem saveMsg;
        private System.Windows.Forms.ToolStripMenuItem saveMsgAs;
        private System.Windows.Forms.ToolStripMenuItem openKey;
        private System.Windows.Forms.ToolStripMenuItem saveKey;
        private System.Windows.Forms.ToolStripMenuItem saveKeyAs;
        private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCipher;
        private System.Windows.Forms.ToolStripMenuItem saveCipher;
        private System.Windows.Forms.ToolStripMenuItem saveCipherAs;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

