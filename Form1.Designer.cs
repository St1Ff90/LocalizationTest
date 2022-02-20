namespace LocalizationTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAgreement = new System.Windows.Forms.CheckBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnUA = new System.Windows.Forms.Button();
            this.btnRU = new System.Windows.Forms.Button();
            this.rtxMainText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbAgreement
            // 
            this.cbAgreement.AutoSize = true;
            this.cbAgreement.Location = new System.Drawing.Point(12, 311);
            this.cbAgreement.Name = "cbAgreement";
            this.cbAgreement.Size = new System.Drawing.Size(154, 19);
            this.cbAgreement.TabIndex = 1;
            this.cbAgreement.Text = "You have my agreement";
            this.cbAgreement.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(374, 311);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnEN
            // 
            this.btnEN.Location = new System.Drawing.Point(412, 6);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(37, 23);
            this.btnEN.TabIndex = 6;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnUA
            // 
            this.btnUA.Location = new System.Drawing.Point(369, 6);
            this.btnUA.Name = "btnUA";
            this.btnUA.Size = new System.Drawing.Size(37, 23);
            this.btnUA.TabIndex = 7;
            this.btnUA.Text = "UA";
            this.btnUA.UseVisualStyleBackColor = true;
            this.btnUA.Click += new System.EventHandler(this.btnUA_Click);
            // 
            // btnRU
            // 
            this.btnRU.Location = new System.Drawing.Point(326, 6);
            this.btnRU.Name = "btnRU";
            this.btnRU.Size = new System.Drawing.Size(37, 23);
            this.btnRU.TabIndex = 8;
            this.btnRU.Text = "RU";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Click += new System.EventHandler(this.btnRU_Click);
            // 
            // rtxMainText
            // 
            this.rtxMainText.Location = new System.Drawing.Point(12, 35);
            this.rtxMainText.Name = "rtxMainText";
            this.rtxMainText.Size = new System.Drawing.Size(437, 270);
            this.rtxMainText.TabIndex = 9;
            this.rtxMainText.Text = resources.GetString("rtxMainText.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 349);
            this.Controls.Add(this.rtxMainText);
            this.Controls.Add(this.btnRU);
            this.Controls.Add(this.btnUA);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.cbAgreement);
            this.Controls.Add(this.btnCancel);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbAgreement;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnUA;
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.RichTextBox rtxMainText;
    }
}
