namespace TicketPunchApps
{
    partial class CounterUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomarName = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTicket);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblTicket);
            this.groupBox1.Controls.Add(this.lblCustomarName);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket and Customar Information";
            // 
            // lblCustomarName
            // 
            this.lblCustomarName.AutoSize = true;
            this.lblCustomarName.Location = new System.Drawing.Point(26, 30);
            this.lblCustomarName.Name = "lblCustomarName";
            this.lblCustomarName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomarName.TabIndex = 0;
            this.lblCustomarName.Text = "Customar Name";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(26, 89);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(37, 13);
            this.lblTicket.TabIndex = 1;
            this.lblTicket.Text = "Ticket";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(191, 86);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(100, 20);
            this.txtTicket.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "One Ticket 20Taka";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(55, 214);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(75, 23);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Total price";
            this.lblTotalPrice.UseVisualStyleBackColor = true;
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(203, 214);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(75, 23);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            this.lblDetails.UseVisualStyleBackColor = true;
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // CounterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 322);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Name = "CounterUI";
            this.Text = "Ticket Counter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblCustomarName;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblTotalPrice;
        private System.Windows.Forms.Button lblDetails;
    }
}

