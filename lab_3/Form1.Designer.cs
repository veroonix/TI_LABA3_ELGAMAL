namespace lab_3
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
            this.pInput = new System.Windows.Forms.TextBox();
            this.kInput = new System.Windows.Forms.TextBox();
            this.xInput = new System.Windows.Forms.TextBox();
            this.inputlabel1 = new System.Windows.Forms.Label();
            this.inputlabel2 = new System.Windows.Forms.Label();
            this.inputlabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileResult = new System.Windows.Forms.TextBox();
            this.fileChoice = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.cipher_button = new System.Windows.Forms.Button();
            this.decipher_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.gChoice = new System.Windows.Forms.ComboBox();
            this.getPervoobr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pInput
            // 
            this.pInput.Location = new System.Drawing.Point(12, 31);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(160, 22);
            this.pInput.TabIndex = 0;
            // 
            // kInput
            // 
            this.kInput.Location = new System.Drawing.Point(12, 92);
            this.kInput.Name = "kInput";
            this.kInput.Size = new System.Drawing.Size(160, 22);
            this.kInput.TabIndex = 1;
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(12, 152);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(160, 22);
            this.xInput.TabIndex = 2;
            // 
            // inputlabel1
            // 
            this.inputlabel1.AutoSize = true;
            this.inputlabel1.Location = new System.Drawing.Point(12, 9);
            this.inputlabel1.Name = "inputlabel1";
            this.inputlabel1.Size = new System.Drawing.Size(77, 16);
            this.inputlabel1.TabIndex = 3;
            this.inputlabel1.Text = "Введите р:";
            // 
            // inputlabel2
            // 
            this.inputlabel2.AutoSize = true;
            this.inputlabel2.Location = new System.Drawing.Point(12, 73);
            this.inputlabel2.Name = "inputlabel2";
            this.inputlabel2.Size = new System.Drawing.Size(76, 16);
            this.inputlabel2.TabIndex = 4;
            this.inputlabel2.Text = "Введите k:";
            // 
            // inputlabel3
            // 
            this.inputlabel3.AutoSize = true;
            this.inputlabel3.Location = new System.Drawing.Point(13, 133);
            this.inputlabel3.Name = "inputlabel3";
            this.inputlabel3.Size = new System.Drawing.Size(75, 16);
            this.inputlabel3.TabIndex = 5;
            this.inputlabel3.Text = "Введите x:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Значения первообразных:";
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(346, 96);
            this.fileInput.Multiline = true;
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(398, 125);
            this.fileInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            // 
            // fileResult
            // 
            this.fileResult.Location = new System.Drawing.Point(344, 291);
            this.fileResult.Multiline = true;
            this.fileResult.Name = "fileResult";
            this.fileResult.Size = new System.Drawing.Size(399, 125);
            this.fileResult.TabIndex = 10;
            // 
            // fileChoice
            // 
            this.fileChoice.BackColor = System.Drawing.Color.LawnGreen;
            this.fileChoice.Location = new System.Drawing.Point(15, 330);
            this.fileChoice.Name = "fileChoice";
            this.fileChoice.Size = new System.Drawing.Size(138, 34);
            this.fileChoice.TabIndex = 12;
            this.fileChoice.Text = "Открыть файл";
            this.fileChoice.UseVisualStyleBackColor = false;
            this.fileChoice.Click += new System.EventHandler(this.fileChoice_Click);
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.Color.LawnGreen;
            this.saveFile.Location = new System.Drawing.Point(179, 330);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(135, 34);
            this.saveFile.TabIndex = 13;
            this.saveFile.Text = "Сохранить файл";
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // cipher_button
            // 
            this.cipher_button.BackColor = System.Drawing.Color.LawnGreen;
            this.cipher_button.Location = new System.Drawing.Point(345, 19);
            this.cipher_button.Name = "cipher_button";
            this.cipher_button.Size = new System.Drawing.Size(130, 34);
            this.cipher_button.TabIndex = 14;
            this.cipher_button.Text = "Шифровать";
            this.cipher_button.UseVisualStyleBackColor = false;
            this.cipher_button.Click += new System.EventHandler(this.cipher_button_Click);
            // 
            // decipher_button
            // 
            this.decipher_button.BackColor = System.Drawing.Color.LawnGreen;
            this.decipher_button.Location = new System.Drawing.Point(510, 19);
            this.decipher_button.Name = "decipher_button";
            this.decipher_button.Size = new System.Drawing.Size(124, 34);
            this.decipher_button.TabIndex = 15;
            this.decipher_button.Text = "Дешифровать";
            this.decipher_button.UseVisualStyleBackColor = false;
            this.decipher_button.Click += new System.EventHandler(this.decipher_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.BackColor = System.Drawing.Color.LawnGreen;
            this.clean_button.Location = new System.Drawing.Point(661, 19);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(112, 34);
            this.clean_button.TabIndex = 16;
            this.clean_button.Text = "Очистить";
            this.clean_button.UseVisualStyleBackColor = false;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // gChoice
            // 
            this.gChoice.FormattingEnabled = true;
            this.gChoice.Location = new System.Drawing.Point(16, 268);
            this.gChoice.Name = "gChoice";
            this.gChoice.Size = new System.Drawing.Size(187, 24);
            this.gChoice.TabIndex = 17;
            this.gChoice.SelectedIndexChanged += new System.EventHandler(this.gChoice_SelectedIndexChanged);
            // 
            // getPervoobr
            // 
            this.getPervoobr.BackColor = System.Drawing.Color.LawnGreen;
            this.getPervoobr.Location = new System.Drawing.Point(12, 199);
            this.getPervoobr.Name = "getPervoobr";
            this.getPervoobr.Size = new System.Drawing.Size(208, 34);
            this.getPervoobr.TabIndex = 18;
            this.getPervoobr.Text = "Вычислить первообразные";
            this.getPervoobr.UseVisualStyleBackColor = false;
            this.getPervoobr.Click += new System.EventHandler(this.getPervoobr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.getPervoobr);
            this.Controls.Add(this.gChoice);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.decipher_button);
            this.Controls.Add(this.cipher_button);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.fileChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputlabel3);
            this.Controls.Add(this.inputlabel2);
            this.Controls.Add(this.inputlabel1);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.kInput);
            this.Controls.Add(this.pInput);
            this.Name = "Form1";
            this.Text = "El Gamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pInput;
        private System.Windows.Forms.TextBox kInput;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label inputlabel1;
        private System.Windows.Forms.Label inputlabel2;
        private System.Windows.Forms.Label inputlabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileResult;
        private System.Windows.Forms.Button fileChoice;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button cipher_button;
        private System.Windows.Forms.Button decipher_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.ComboBox gChoice;
        private System.Windows.Forms.Button getPervoobr;
    }
}

