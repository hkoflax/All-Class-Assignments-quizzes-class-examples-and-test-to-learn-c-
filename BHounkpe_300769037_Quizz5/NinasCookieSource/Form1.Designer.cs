namespace NinasCookieSource
{
    partial class NinaCookieSource
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
            this.gbCookiesType = new System.Windows.Forms.GroupBox();
            this.rbtnTrefoils = new System.Windows.Forms.RadioButton();
            this.rbtnTagalongs = new System.Windows.Forms.RadioButton();
            this.rbtnSamoas = new System.Windows.Forms.RadioButton();
            this.gbCookiesQuantity = new System.Windows.Forms.GroupBox();
            this.rbtnThree = new System.Windows.Forms.RadioButton();
            this.rbtnTwo = new System.Windows.Forms.RadioButton();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.rbtnOnehalf = new System.Windows.Forms.RadioButton();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dTPOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblCookiesType = new System.Windows.Forms.Label();
            this.lblCookiesPrice = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOnePrice = new System.Windows.Forms.Label();
            this.gbCookiesType.SuspendLayout();
            this.gbCookiesQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCookiesType
            // 
            this.gbCookiesType.Controls.Add(this.rbtnTrefoils);
            this.gbCookiesType.Controls.Add(this.rbtnTagalongs);
            this.gbCookiesType.Controls.Add(this.rbtnSamoas);
            this.gbCookiesType.Location = new System.Drawing.Point(14, 12);
            this.gbCookiesType.Name = "gbCookiesType";
            this.gbCookiesType.Size = new System.Drawing.Size(147, 111);
            this.gbCookiesType.TabIndex = 0;
            this.gbCookiesType.TabStop = false;
            this.gbCookiesType.Text = "Cookies Type";
            // 
            // rbtnTrefoils
            // 
            this.rbtnTrefoils.AutoSize = true;
            this.rbtnTrefoils.Location = new System.Drawing.Point(7, 88);
            this.rbtnTrefoils.Name = "rbtnTrefoils";
            this.rbtnTrefoils.Size = new System.Drawing.Size(67, 17);
            this.rbtnTrefoils.TabIndex = 2;
            this.rbtnTrefoils.Text = "Trefoils";
            this.rbtnTrefoils.UseVisualStyleBackColor = true;
            this.rbtnTrefoils.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // rbtnTagalongs
            // 
            this.rbtnTagalongs.AutoSize = true;
            this.rbtnTagalongs.Location = new System.Drawing.Point(6, 54);
            this.rbtnTagalongs.Name = "rbtnTagalongs";
            this.rbtnTagalongs.Size = new System.Drawing.Size(84, 17);
            this.rbtnTagalongs.TabIndex = 1;
            this.rbtnTagalongs.Text = "Tagalongs";
            this.rbtnTagalongs.UseVisualStyleBackColor = true;
            this.rbtnTagalongs.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // rbtnSamoas
            // 
            this.rbtnSamoas.AutoSize = true;
            this.rbtnSamoas.Checked = true;
            this.rbtnSamoas.Location = new System.Drawing.Point(7, 20);
            this.rbtnSamoas.Name = "rbtnSamoas";
            this.rbtnSamoas.Size = new System.Drawing.Size(69, 17);
            this.rbtnSamoas.TabIndex = 0;
            this.rbtnSamoas.TabStop = true;
            this.rbtnSamoas.Text = "Samoas";
            this.rbtnSamoas.UseVisualStyleBackColor = true;
            this.rbtnSamoas.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // gbCookiesQuantity
            // 
            this.gbCookiesQuantity.Controls.Add(this.rbtnThree);
            this.gbCookiesQuantity.Controls.Add(this.rbtnTwo);
            this.gbCookiesQuantity.Controls.Add(this.rbtnOne);
            this.gbCookiesQuantity.Controls.Add(this.rbtnOnehalf);
            this.gbCookiesQuantity.Location = new System.Drawing.Point(169, 13);
            this.gbCookiesQuantity.Name = "gbCookiesQuantity";
            this.gbCookiesQuantity.Size = new System.Drawing.Size(148, 110);
            this.gbCookiesQuantity.TabIndex = 1;
            this.gbCookiesQuantity.TabStop = false;
            this.gbCookiesQuantity.Text = "Quantity (in Dozen)";
            // 
            // rbtnThree
            // 
            this.rbtnThree.AutoSize = true;
            this.rbtnThree.Location = new System.Drawing.Point(7, 86);
            this.rbtnThree.Name = "rbtnThree";
            this.rbtnThree.Size = new System.Drawing.Size(58, 17);
            this.rbtnThree.TabIndex = 3;
            this.rbtnThree.Text = "Three";
            this.rbtnThree.UseVisualStyleBackColor = true;
            this.rbtnThree.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // rbtnTwo
            // 
            this.rbtnTwo.AutoSize = true;
            this.rbtnTwo.Location = new System.Drawing.Point(7, 63);
            this.rbtnTwo.Name = "rbtnTwo";
            this.rbtnTwo.Size = new System.Drawing.Size(49, 17);
            this.rbtnTwo.TabIndex = 2;
            this.rbtnTwo.Text = "Two";
            this.rbtnTwo.UseVisualStyleBackColor = true;
            this.rbtnTwo.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.Location = new System.Drawing.Point(7, 40);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(48, 17);
            this.rbtnOne.TabIndex = 1;
            this.rbtnOne.Text = "One";
            this.rbtnOne.UseVisualStyleBackColor = true;
            this.rbtnOne.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // rbtnOnehalf
            // 
            this.rbtnOnehalf.AutoSize = true;
            this.rbtnOnehalf.Checked = true;
            this.rbtnOnehalf.Location = new System.Drawing.Point(7, 19);
            this.rbtnOnehalf.Name = "rbtnOnehalf";
            this.rbtnOnehalf.Size = new System.Drawing.Size(73, 17);
            this.rbtnOnehalf.TabIndex = 0;
            this.rbtnOnehalf.TabStop = true;
            this.rbtnOnehalf.Text = "One-half";
            this.rbtnOnehalf.UseVisualStyleBackColor = true;
            this.rbtnOnehalf.CheckedChanged += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(15, 133);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(77, 13);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date :";
            // 
            // dTPOrderDate
            // 
            this.dTPOrderDate.Location = new System.Drawing.Point(98, 130);
            this.dTPOrderDate.Name = "dTPOrderDate";
            this.dTPOrderDate.Size = new System.Drawing.Size(219, 20);
            this.dTPOrderDate.TabIndex = 3;
            this.dTPOrderDate.ValueChanged += new System.EventHandler(this.dTPOrderDate_ValueChanged);
            // 
            // lblCookiesType
            // 
            this.lblCookiesType.AutoSize = true;
            this.lblCookiesType.Location = new System.Drawing.Point(14, 183);
            this.lblCookiesType.Name = "lblCookiesType";
            this.lblCookiesType.Size = new System.Drawing.Size(123, 13);
            this.lblCookiesType.TabIndex = 4;
            this.lblCookiesType.Text = "You have Selected :";
            // 
            // lblCookiesPrice
            // 
            this.lblCookiesPrice.AutoSize = true;
            this.lblCookiesPrice.Location = new System.Drawing.Point(14, 210);
            this.lblCookiesPrice.Name = "lblCookiesPrice";
            this.lblCookiesPrice.Size = new System.Drawing.Size(41, 13);
            this.lblCookiesPrice.TabIndex = 5;
            this.lblCookiesPrice.Text = "label3";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(14, 237);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(41, 13);
            this.lblDeliveryDate.TabIndex = 6;
            this.lblDeliveryDate.Text = "label4";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(143, 183);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "label1";
            // 
            // lblOnePrice
            // 
            this.lblOnePrice.AutoSize = true;
            this.lblOnePrice.Location = new System.Drawing.Point(14, 161);
            this.lblOnePrice.Name = "lblOnePrice";
            this.lblOnePrice.Size = new System.Drawing.Size(41, 13);
            this.lblOnePrice.TabIndex = 8;
            this.lblOnePrice.Text = "label1";
            // 
            // NinaCookieSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.lblOnePrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblCookiesPrice);
            this.Controls.Add(this.lblCookiesType);
            this.Controls.Add(this.dTPOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.gbCookiesQuantity);
            this.Controls.Add(this.gbCookiesType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 300);
            this.Name = "NinaCookieSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NinaCookieSource";
            this.Load += new System.EventHandler(this.rbtnSamoas_CheckedChanged);
            this.gbCookiesType.ResumeLayout(false);
            this.gbCookiesType.PerformLayout();
            this.gbCookiesQuantity.ResumeLayout(false);
            this.gbCookiesQuantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCookiesType;
        private System.Windows.Forms.RadioButton rbtnTrefoils;
        private System.Windows.Forms.RadioButton rbtnTagalongs;
        private System.Windows.Forms.RadioButton rbtnSamoas;
        private System.Windows.Forms.GroupBox gbCookiesQuantity;
        private System.Windows.Forms.RadioButton rbtnThree;
        private System.Windows.Forms.RadioButton rbtnTwo;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.RadioButton rbtnOnehalf;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dTPOrderDate;
        private System.Windows.Forms.Label lblCookiesType;
        private System.Windows.Forms.Label lblCookiesPrice;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOnePrice;
    }
}

