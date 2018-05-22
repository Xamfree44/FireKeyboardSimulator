namespace FireKeyboardSimulator
{
    partial class Start_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndlessButton = new System.Windows.Forms.RadioButton();
            this.ScoreButton = new System.Windows.Forms.RadioButton();
            this.SpeedUpButton = new System.Windows.Forms.RadioButton();
            this.LearnButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Punctuation = new System.Windows.Forms.CheckBox();
            this.HotKeys = new System.Windows.Forms.CheckBox();
            this.Numb = new System.Windows.Forms.CheckBox();
            this.BigLett = new System.Windows.Forms.CheckBox();
            this.smallLett = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fire Keyboard Simulator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FireKeyboardSimulator.Properties.Resources.лого_финал2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndlessButton);
            this.groupBox1.Controls.Add(this.ScoreButton);
            this.groupBox1.Controls.Add(this.SpeedUpButton);
            this.groupBox1.Controls.Add(this.LearnButton);
            this.groupBox1.Location = new System.Drawing.Point(144, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // EndlessButton
            // 
            this.EndlessButton.AutoSize = true;
            this.EndlessButton.Location = new System.Drawing.Point(7, 89);
            this.EndlessButton.Name = "EndlessButton";
            this.EndlessButton.Size = new System.Drawing.Size(93, 17);
            this.EndlessButton.TabIndex = 3;
            this.EndlessButton.TabStop = true;
            this.EndlessButton.Text = "Бесконечный";
            this.EndlessButton.UseVisualStyleBackColor = true;
            // 
            // ScoreButton
            // 
            this.ScoreButton.AutoSize = true;
            this.ScoreButton.Location = new System.Drawing.Point(7, 66);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(78, 17);
            this.ScoreButton.TabIndex = 2;
            this.ScoreButton.TabStop = true;
            this.ScoreButton.Text = "На рекорд";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.AutoSize = true;
            this.SpeedUpButton.Location = new System.Drawing.Point(7, 43);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(104, 17);
            this.SpeedUpButton.TabIndex = 1;
            this.SpeedUpButton.TabStop = true;
            this.SpeedUpButton.Text = "Ускоряющийся";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            // 
            // LearnButton
            // 
            this.LearnButton.AutoSize = true;
            this.LearnButton.Location = new System.Drawing.Point(7, 20);
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(73, 17);
            this.LearnButton.TabIndex = 0;
            this.LearnButton.TabStop = true;
            this.LearnButton.Text = "Обучение";
            this.LearnButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Punctuation);
            this.groupBox2.Controls.Add(this.HotKeys);
            this.groupBox2.Controls.Add(this.Numb);
            this.groupBox2.Controls.Add(this.BigLett);
            this.groupBox2.Controls.Add(this.smallLett);
            this.groupBox2.Location = new System.Drawing.Point(327, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сложность";
            // 
            // Punctuation
            // 
            this.Punctuation.AutoSize = true;
            this.Punctuation.Location = new System.Drawing.Point(6, 110);
            this.Punctuation.Name = "Punctuation";
            this.Punctuation.Size = new System.Drawing.Size(120, 17);
            this.Punctuation.TabIndex = 4;
            this.Punctuation.Text = "Знаки препинания";
            this.Punctuation.UseVisualStyleBackColor = true;
            // 
            // HotKeys
            // 
            this.HotKeys.AutoSize = true;
            this.HotKeys.Location = new System.Drawing.Point(6, 88);
            this.HotKeys.Name = "HotKeys";
            this.HotKeys.Size = new System.Drawing.Size(120, 17);
            this.HotKeys.TabIndex = 3;
            this.HotKeys.Text = "Сочетания клавиш";
            this.HotKeys.UseVisualStyleBackColor = true;
            // 
            // Numb
            // 
            this.Numb.AutoSize = true;
            this.Numb.Location = new System.Drawing.Point(6, 65);
            this.Numb.Name = "Numb";
            this.Numb.Size = new System.Drawing.Size(62, 17);
            this.Numb.TabIndex = 2;
            this.Numb.Text = "Цифры";
            this.Numb.UseVisualStyleBackColor = true;
            // 
            // BigLett
            // 
            this.BigLett.AutoSize = true;
            this.BigLett.Location = new System.Drawing.Point(6, 42);
            this.BigLett.Name = "BigLett";
            this.BigLett.Size = new System.Drawing.Size(118, 17);
            this.BigLett.TabIndex = 1;
            this.BigLett.Text = "Прописные буквы";
            this.BigLett.UseVisualStyleBackColor = true;
            // 
            // smallLett
            // 
            this.smallLett.AutoSize = true;
            this.smallLett.Location = new System.Drawing.Point(6, 20);
            this.smallLett.Name = "smallLett";
            this.smallLett.Size = new System.Drawing.Size(109, 17);
            this.smallLett.TabIndex = 0;
            this.smallLett.Text = "Строчные буквы";
            this.smallLett.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Start_Form";
            this.Text = "FireKeyboardSimulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EndlessButton;
        private System.Windows.Forms.RadioButton ScoreButton;
        private System.Windows.Forms.RadioButton SpeedUpButton;
        private System.Windows.Forms.RadioButton LearnButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Punctuation;
        private System.Windows.Forms.CheckBox HotKeys;
        private System.Windows.Forms.CheckBox Numb;
        private System.Windows.Forms.CheckBox BigLett;
        private System.Windows.Forms.CheckBox smallLett;
        private System.Windows.Forms.Button button1;
    }
}

