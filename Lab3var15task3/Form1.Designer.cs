namespace Lab3var15task3
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.countSmallRoomUpDown = new System.Windows.Forms.NumericUpDown();
            this.smallRoomBox = new System.Windows.Forms.CheckBox();
            this.mediumRoomBox = new System.Windows.Forms.CheckBox();
            this.largeRoomBox = new System.Windows.Forms.CheckBox();
            this.thirdPriceTextBox = new System.Windows.Forms.TextBox();
            this.secondPriceTextBox = new System.Windows.Forms.TextBox();
            this.firstPriceTextBox = new System.Windows.Forms.TextBox();
            this.countMediumRoomUpDown = new System.Windows.Forms.NumericUpDown();
            this.countLargeRoomUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.countSmallRoomUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMediumRoomUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLargeRoomUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.outputTextBox.Location = new System.Drawing.Point(44, 105);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(184, 20);
            this.outputTextBox.TabIndex = 13;
            // 
            // countSmallRoomUpDown
            // 
            this.countSmallRoomUpDown.Location = new System.Drawing.Point(196, 12);
            this.countSmallRoomUpDown.Name = "countSmallRoomUpDown";
            this.countSmallRoomUpDown.Size = new System.Drawing.Size(51, 20);
            this.countSmallRoomUpDown.TabIndex = 12;
            // 
            // smallRoomBox
            // 
            this.smallRoomBox.AutoSize = true;
            this.smallRoomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.smallRoomBox.Location = new System.Drawing.Point(33, 13);
            this.smallRoomBox.Name = "smallRoomBox";
            this.smallRoomBox.Size = new System.Drawing.Size(88, 21);
            this.smallRoomBox.TabIndex = 15;
            this.smallRoomBox.Text = "1 місткий";
            this.smallRoomBox.UseVisualStyleBackColor = true;
            // 
            // mediumRoomBox
            // 
            this.mediumRoomBox.AutoSize = true;
            this.mediumRoomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mediumRoomBox.Location = new System.Drawing.Point(33, 40);
            this.mediumRoomBox.Name = "mediumRoomBox";
            this.mediumRoomBox.Size = new System.Drawing.Size(88, 21);
            this.mediumRoomBox.TabIndex = 16;
            this.mediumRoomBox.Text = "2 місткий";
            this.mediumRoomBox.UseVisualStyleBackColor = true;
            // 
            // largeRoomBox
            // 
            this.largeRoomBox.AutoSize = true;
            this.largeRoomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.largeRoomBox.Location = new System.Drawing.Point(33, 67);
            this.largeRoomBox.Name = "largeRoomBox";
            this.largeRoomBox.Size = new System.Drawing.Size(88, 21);
            this.largeRoomBox.TabIndex = 17;
            this.largeRoomBox.Text = "3 місткий";
            this.largeRoomBox.UseVisualStyleBackColor = true;
            // 
            // thirdPriceTextBox
            // 
            this.thirdPriceTextBox.Location = new System.Drawing.Point(134, 68);
            this.thirdPriceTextBox.Name = "thirdPriceTextBox";
            this.thirdPriceTextBox.ReadOnly = true;
            this.thirdPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.thirdPriceTextBox.TabIndex = 20;
            this.thirdPriceTextBox.Text = "1300";
            // 
            // secondPriceTextBox
            // 
            this.secondPriceTextBox.Location = new System.Drawing.Point(134, 41);
            this.secondPriceTextBox.Name = "secondPriceTextBox";
            this.secondPriceTextBox.ReadOnly = true;
            this.secondPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.secondPriceTextBox.TabIndex = 19;
            this.secondPriceTextBox.Text = "1000";
            // 
            // firstPriceTextBox
            // 
            this.firstPriceTextBox.Location = new System.Drawing.Point(134, 14);
            this.firstPriceTextBox.Name = "firstPriceTextBox";
            this.firstPriceTextBox.ReadOnly = true;
            this.firstPriceTextBox.Size = new System.Drawing.Size(43, 20);
            this.firstPriceTextBox.TabIndex = 18;
            this.firstPriceTextBox.Text = "700";
            // 
            // countMediumRoomUpDown
            // 
            this.countMediumRoomUpDown.Location = new System.Drawing.Point(196, 38);
            this.countMediumRoomUpDown.Name = "countMediumRoomUpDown";
            this.countMediumRoomUpDown.Size = new System.Drawing.Size(51, 20);
            this.countMediumRoomUpDown.TabIndex = 21;
            // 
            // countLargeRoomUpDown
            // 
            this.countLargeRoomUpDown.Location = new System.Drawing.Point(196, 69);
            this.countLargeRoomUpDown.Name = "countLargeRoomUpDown";
            this.countLargeRoomUpDown.Size = new System.Drawing.Size(51, 20);
            this.countLargeRoomUpDown.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 152);
            this.Controls.Add(this.countLargeRoomUpDown);
            this.Controls.Add(this.countMediumRoomUpDown);
            this.Controls.Add(this.thirdPriceTextBox);
            this.Controls.Add(this.secondPriceTextBox);
            this.Controls.Add(this.firstPriceTextBox);
            this.Controls.Add(this.largeRoomBox);
            this.Controls.Add(this.mediumRoomBox);
            this.Controls.Add(this.smallRoomBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.countSmallRoomUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countSmallRoomUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMediumRoomUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLargeRoomUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.NumericUpDown countSmallRoomUpDown;
        private System.Windows.Forms.CheckBox smallRoomBox;
        private System.Windows.Forms.CheckBox mediumRoomBox;
        private System.Windows.Forms.CheckBox largeRoomBox;
        private System.Windows.Forms.TextBox thirdPriceTextBox;
        private System.Windows.Forms.TextBox secondPriceTextBox;
        private System.Windows.Forms.TextBox firstPriceTextBox;
        private System.Windows.Forms.NumericUpDown countMediumRoomUpDown;
        private System.Windows.Forms.NumericUpDown countLargeRoomUpDown;
    }
}

