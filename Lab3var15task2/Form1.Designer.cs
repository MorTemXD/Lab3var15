namespace Lab3var15task2
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
            this.smallRoomButton = new System.Windows.Forms.RadioButton();
            this.mediumRoomButton = new System.Windows.Forms.RadioButton();
            this.largeRoomButton = new System.Windows.Forms.RadioButton();
            this.countRoomUpDown = new System.Windows.Forms.NumericUpDown();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstPriceTextBox = new System.Windows.Forms.TextBox();
            this.secondPriceTextBox = new System.Windows.Forms.TextBox();
            this.thirdPriceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countRoomUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // smallRoomButton
            // 
            this.smallRoomButton.AutoSize = true;
            this.smallRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.smallRoomButton.Location = new System.Drawing.Point(39, 12);
            this.smallRoomButton.Name = "smallRoomButton";
            this.smallRoomButton.Size = new System.Drawing.Size(87, 21);
            this.smallRoomButton.TabIndex = 0;
            this.smallRoomButton.TabStop = true;
            this.smallRoomButton.Text = "1 місткий";
            this.smallRoomButton.UseVisualStyleBackColor = true;
            // 
            // mediumRoomButton
            // 
            this.mediumRoomButton.AutoSize = true;
            this.mediumRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mediumRoomButton.Location = new System.Drawing.Point(39, 39);
            this.mediumRoomButton.Name = "mediumRoomButton";
            this.mediumRoomButton.Size = new System.Drawing.Size(87, 21);
            this.mediumRoomButton.TabIndex = 1;
            this.mediumRoomButton.TabStop = true;
            this.mediumRoomButton.Text = "2 місткий";
            this.mediumRoomButton.UseVisualStyleBackColor = true;
            // 
            // largeRoomButton
            // 
            this.largeRoomButton.AutoSize = true;
            this.largeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.largeRoomButton.Location = new System.Drawing.Point(39, 66);
            this.largeRoomButton.Name = "largeRoomButton";
            this.largeRoomButton.Size = new System.Drawing.Size(87, 21);
            this.largeRoomButton.TabIndex = 2;
            this.largeRoomButton.TabStop = true;
            this.largeRoomButton.Text = "3 місткий";
            this.largeRoomButton.UseVisualStyleBackColor = true;
            // 
            // countRoomUpDown
            // 
            this.countRoomUpDown.Location = new System.Drawing.Point(141, 102);
            this.countRoomUpDown.Name = "countRoomUpDown";
            this.countRoomUpDown.Size = new System.Drawing.Size(51, 20);
            this.countRoomUpDown.TabIndex = 3;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.outputTextBox.Location = new System.Drawing.Point(8, 137);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(184, 20);
            this.outputTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(5, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Виберіть кількість:";
            // 
            // firstPriceTextBox
            // 
            this.firstPriceTextBox.Location = new System.Drawing.Point(132, 14);
            this.firstPriceTextBox.Name = "firstPriceTextBox";
            this.firstPriceTextBox.ReadOnly = true;
            this.firstPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.firstPriceTextBox.TabIndex = 6;
            this.firstPriceTextBox.Text = "700";
            // 
            // secondPriceTextBox
            // 
            this.secondPriceTextBox.Location = new System.Drawing.Point(132, 41);
            this.secondPriceTextBox.Name = "secondPriceTextBox";
            this.secondPriceTextBox.ReadOnly = true;
            this.secondPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.secondPriceTextBox.TabIndex = 7;
            this.secondPriceTextBox.Text = "1000";
            // 
            // thirdPriceTextBox
            // 
            this.thirdPriceTextBox.Location = new System.Drawing.Point(132, 68);
            this.thirdPriceTextBox.Name = "thirdPriceTextBox";
            this.thirdPriceTextBox.ReadOnly = true;
            this.thirdPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.thirdPriceTextBox.TabIndex = 8;
            this.thirdPriceTextBox.Text = "1300";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 195);
            this.Controls.Add(this.thirdPriceTextBox);
            this.Controls.Add(this.secondPriceTextBox);
            this.Controls.Add(this.firstPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.countRoomUpDown);
            this.Controls.Add(this.largeRoomButton);
            this.Controls.Add(this.mediumRoomButton);
            this.Controls.Add(this.smallRoomButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countRoomUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton smallRoomButton;
        private System.Windows.Forms.RadioButton mediumRoomButton;
        private System.Windows.Forms.RadioButton largeRoomButton;
        private System.Windows.Forms.NumericUpDown countRoomUpDown;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstPriceTextBox;
        private System.Windows.Forms.TextBox secondPriceTextBox;
        private System.Windows.Forms.TextBox thirdPriceTextBox;
    }
}

