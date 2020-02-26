namespace WinFormUI
{
    partial class Dashboard
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
            this.Banking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkingBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.savingBalance = new System.Windows.Forms.Label();
            this.recordTransactionButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkingTransactions = new System.Windows.Forms.ListBox();
            this.savingTransactions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Banking
            // 
            this.Banking.Location = new System.Drawing.Point(28, 50);
            this.Banking.Name = "Banking";
            this.Banking.Size = new System.Drawing.Size(100, 26);
            this.Banking.TabIndex = 0;
            this.Banking.Text = "Banking Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName.Location = new System.Drawing.Point(187, 125);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(115, 32);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "<None>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "CheckingBalance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkingBalance
            // 
            this.checkingBalance.AutoSize = true;
            this.checkingBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkingBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkingBalance.Location = new System.Drawing.Point(232, 207);
            this.checkingBalance.Name = "checkingBalance";
            this.checkingBalance.Size = new System.Drawing.Size(87, 32);
            this.checkingBalance.TabIndex = 4;
            this.checkingBalance.Text = "0.00$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saving Balance";
            // 
            // savingBalance
            // 
            this.savingBalance.AutoSize = true;
            this.savingBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.savingBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savingBalance.Location = new System.Drawing.Point(232, 273);
            this.savingBalance.Name = "savingBalance";
            this.savingBalance.Size = new System.Drawing.Size(87, 32);
            this.savingBalance.TabIndex = 6;
            this.savingBalance.Text = "0.00$";
            // 
            // recordTransactionButton
            // 
            this.recordTransactionButton.Location = new System.Drawing.Point(94, 341);
            this.recordTransactionButton.Name = "recordTransactionButton";
            this.recordTransactionButton.Size = new System.Drawing.Size(147, 85);
            this.recordTransactionButton.TabIndex = 7;
            this.recordTransactionButton.Text = "Record Transaction";
            this.recordTransactionButton.UseVisualStyleBackColor = true;
            this.recordTransactionButton.Click += new System.EventHandler(this.recordTransactionButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errorMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.errorMessage.Location = new System.Drawing.Point(335, 76);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(426, 32);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "You have an overdraft protection";
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(320, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Checking Transactions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(575, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Saving Transactions";
            // 
            // checkingTransactions
            // 
            this.checkingTransactions.FormattingEnabled = true;
            this.checkingTransactions.ItemHeight = 20;
            this.checkingTransactions.Location = new System.Drawing.Point(325, 167);
            this.checkingTransactions.Name = "checkingTransactions";
            this.checkingTransactions.Size = new System.Drawing.Size(221, 244);
            this.checkingTransactions.TabIndex = 11;
            // 
            // savingTransactions
            // 
            this.savingTransactions.FormattingEnabled = true;
            this.savingTransactions.ItemHeight = 20;
            this.savingTransactions.Location = new System.Drawing.Point(561, 167);
            this.savingTransactions.Name = "savingTransactions";
            this.savingTransactions.Size = new System.Drawing.Size(224, 244);
            this.savingTransactions.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savingTransactions);
            this.Controls.Add(this.checkingTransactions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.recordTransactionButton);
            this.Controls.Add(this.savingBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkingBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Banking);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Banking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label checkingBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label savingBalance;
        private System.Windows.Forms.Button recordTransactionButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox checkingTransactions;
        private System.Windows.Forms.ListBox savingTransactions;
    }
}

