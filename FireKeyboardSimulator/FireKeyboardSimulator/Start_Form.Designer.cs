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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.GroupBox();
            this.EndlessButton = new System.Windows.Forms.RadioButton();
            this.ScoreButton = new System.Windows.Forms.RadioButton();
            this.SpeedUpButton = new System.Windows.Forms.RadioButton();
            this.LearnButton = new System.Windows.Forms.RadioButton();
            this.Сomplication = new System.Windows.Forms.GroupBox();
            this.punctuation = new System.Windows.Forms.CheckBox();
            this.numb = new System.Windows.Forms.CheckBox();
            this.bigLett = new System.Windows.Forms.CheckBox();
            this.smallLett = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mode.SuspendLayout();
            this.Сomplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // Mode
            // 
            this.Mode.Controls.Add(this.EndlessButton);
            this.Mode.Controls.Add(this.ScoreButton);
            this.Mode.Controls.Add(this.SpeedUpButton);
            this.Mode.Controls.Add(this.LearnButton);
            this.Mode.Location = new System.Drawing.Point(144, 56);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(177, 119);
            this.Mode.TabIndex = 2;
            this.Mode.TabStop = false;
            this.Mode.Text = "Режим";
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
            // Сomplication
            // 
            this.Сomplication.Controls.Add(this.punctuation);
            this.Сomplication.Controls.Add(this.numb);
            this.Сomplication.Controls.Add(this.bigLett);
            this.Сomplication.Controls.Add(this.smallLett);
            this.Сomplication.Location = new System.Drawing.Point(327, 56);
            this.Сomplication.Name = "Сomplication";
            this.Сomplication.Size = new System.Drawing.Size(198, 119);
            this.Сomplication.TabIndex = 3;
            this.Сomplication.TabStop = false;
            this.Сomplication.Text = "Сложность";
            // 
            // punctuation
            // 
            this.punctuation.AutoSize = true;
            this.punctuation.Location = new System.Drawing.Point(6, 90);
            this.punctuation.Name = "punctuation";
            this.punctuation.Size = new System.Drawing.Size(120, 17);
            this.punctuation.TabIndex = 4;
            this.punctuation.Text = "Знаки препинания";
            this.punctuation.UseVisualStyleBackColor = true;
            // 
            // numb
            // 
            this.numb.AutoSize = true;
            this.numb.Location = new System.Drawing.Point(6, 67);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(62, 17);
            this.numb.TabIndex = 2;
            this.numb.Text = "Цифры";
            this.numb.UseVisualStyleBackColor = true;
            // 
            // bigLett
            // 
            this.bigLett.AutoSize = true;
            this.bigLett.Location = new System.Drawing.Point(6, 44);
            this.bigLett.Name = "bigLett";
            this.bigLett.Size = new System.Drawing.Size(116, 17);
            this.bigLett.TabIndex = 1;
            this.bigLett.Text = "Заглавные буквы";
            this.bigLett.UseVisualStyleBackColor = true;
            // 
            // smallLett
            // 
            this.smallLett.AutoSize = true;
            this.smallLett.Location = new System.Drawing.Point(6, 21);
            this.smallLett.Name = "smallLett";
            this.smallLett.Size = new System.Drawing.Size(109, 17);
            this.smallLett.TabIndex = 0;
            this.smallLett.Text = "Строчные буквы";
            this.smallLett.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Сomplication);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Form";
            this.Text = "FireKeyboardSimulator";
            this.Mode.ResumeLayout(false);
            this.Mode.PerformLayout();
            this.Сomplication.ResumeLayout(false);
            this.Сomplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Mode;
        private System.Windows.Forms.RadioButton EndlessButton;
        private System.Windows.Forms.RadioButton ScoreButton;
        private System.Windows.Forms.RadioButton SpeedUpButton;
        private System.Windows.Forms.RadioButton LearnButton;
        private System.Windows.Forms.GroupBox Сomplication;
        private System.Windows.Forms.CheckBox punctuation;
        private System.Windows.Forms.CheckBox numb;
        private System.Windows.Forms.CheckBox bigLett;
        private System.Windows.Forms.CheckBox smallLett;
        private System.Windows.Forms.Button button1;
    }
}

