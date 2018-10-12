namespace S5W12C1E2
{
    partial class SayHello
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
            this.lblEnterYourName = new System.Windows.Forms.Label();
            this.txtbSayHello = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.chbFeelingGood = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblEnterYourName
            // 
            this.lblEnterYourName.AutoSize = true;
            this.lblEnterYourName.Location = new System.Drawing.Point(13, 13);
            this.lblEnterYourName.Name = "lblEnterYourName";
            this.lblEnterYourName.Size = new System.Drawing.Size(92, 13);
            this.lblEnterYourName.TabIndex = 0;
            this.lblEnterYourName.Text = "Enter your Name :";
            // 
            // txtbSayHello
            // 
            this.txtbSayHello.Location = new System.Drawing.Point(108, 10);
            this.txtbSayHello.Name = "txtbSayHello";
            this.txtbSayHello.Size = new System.Drawing.Size(100, 20);
            this.txtbSayHello.TabIndex = 1;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(108, 213);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(75, 23);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "SayHello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(12, 90);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(0, 25);
            this.lblDisplayName.TabIndex = 3;
            // 
            // chbFeelingGood
            // 
            this.chbFeelingGood.AutoSize = true;
            this.chbFeelingGood.Location = new System.Drawing.Point(16, 45);
            this.chbFeelingGood.Name = "chbFeelingGood";
            this.chbFeelingGood.Size = new System.Drawing.Size(89, 17);
            this.chbFeelingGood.TabIndex = 4;
            this.chbFeelingGood.Text = "Feeling Good";
            this.chbFeelingGood.UseVisualStyleBackColor = true;
            // 
            // SayHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chbFeelingGood);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtbSayHello);
            this.Controls.Add(this.lblEnterYourName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SayHello";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterYourName;
        private System.Windows.Forms.TextBox txtbSayHello;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.CheckBox chbFeelingGood;
    }
}

