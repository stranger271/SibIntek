
namespace WindowsFormsApp1
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
            this.Run = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LoremIpsum = new System.Windows.Forms.Label();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.ClearFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(334, 200);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(260, 57);
            this.Run.TabIndex = 0;
            this.Run.Text = "Выполнить";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Location = new System.Drawing.Point(23, 147);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(305, 110);
            this.Result.TabIndex = 1;
            this.Result.Text = "Результат";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(26, 35);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(302, 93);
            this.InputText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(334, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбирите задание";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 136);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(110, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "6";
            this.radioButton6.Text = "Работа с датами";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(197, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "Созранить в TXT на рабочий стол";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(209, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "Список слов в алфавитном порядке";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(251, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Первая и последняя буква слова рокировка";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Первая буква слов заглавная";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(177, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Удалить пробелы и переносы";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // LoremIpsum
            // 
            this.LoremIpsum.AutoSize = true;
            this.LoremIpsum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoremIpsum.Location = new System.Drawing.Point(23, 19);
            this.LoremIpsum.Name = "LoremIpsum";
            this.LoremIpsum.Size = new System.Drawing.Size(237, 13);
            this.LoremIpsum.TabIndex = 4;
            this.LoremIpsum.Text = "Нажмите сюда, чтобы вставить текст \"рыбу\"";
            this.LoremIpsum.Click += new System.EventHandler(this.LoremIpsum_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(23, 279);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(111, 33);
            this.SelectFolder.TabIndex = 5;
            this.SelectFolder.Text = "Выбрать папку";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // ClearFolder
            // 
            this.ClearFolder.Location = new System.Drawing.Point(149, 279);
            this.ClearFolder.Name = "ClearFolder";
            this.ClearFolder.Size = new System.Drawing.Size(111, 33);
            this.ClearFolder.TabIndex = 6;
            this.ClearFolder.Text = "Очистить";
            this.ClearFolder.UseVisualStyleBackColor = true;
            this.ClearFolder.Click += new System.EventHandler(this.ClearFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.ClearFolder);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.LoremIpsum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание по С#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label LoremIpsum;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button ClearFolder;
             
    }
}

