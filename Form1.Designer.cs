
namespace Sinama_Otomasyonu
{
    partial class Form1
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
            this.panelCords = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnMultiDisable = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSelledCord = new System.Windows.Forms.Label();
            this.lblYCord = new System.Windows.Forms.Label();
            this.lblEmptyCord = new System.Windows.Forms.Label();
            this.lblXCord = new System.Windows.Forms.Label();
            this.txtSelledCord = new System.Windows.Forms.TextBox();
            this.txtEmptyCord = new System.Windows.Forms.TextBox();
            this.txtYCord = new System.Windows.Forms.TextBox();
            this.txtXCord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCords
            // 
            this.panelCords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCords.Location = new System.Drawing.Point(0, 0);
            this.panelCords.Name = "panelCords";
            this.panelCords.Size = new System.Drawing.Size(1331, 972);
            this.panelCords.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.button1);
            this.panelControls.Controls.Add(this.btnMultiDisable);
            this.panelControls.Controls.Add(this.btnCreate);
            this.panelControls.Controls.Add(this.lblSelledCord);
            this.panelControls.Controls.Add(this.lblYCord);
            this.panelControls.Controls.Add(this.lblEmptyCord);
            this.panelControls.Controls.Add(this.lblXCord);
            this.panelControls.Controls.Add(this.txtSelledCord);
            this.panelControls.Controls.Add(this.txtEmptyCord);
            this.panelControls.Controls.Add(this.txtYCord);
            this.panelControls.Controls.Add(this.txtXCord);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 920);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1331, 52);
            this.panelControls.TabIndex = 0;
            // 
            // btnMultiDisable
            // 
            this.btnMultiDisable.Location = new System.Drawing.Point(991, 15);
            this.btnMultiDisable.Name = "btnMultiDisable";
            this.btnMultiDisable.Size = new System.Drawing.Size(179, 23);
            this.btnMultiDisable.TabIndex = 1;
            this.btnMultiDisable.Text = "SEÇİLİ ARALIKLARI KALDIR";
            this.btnMultiDisable.UseVisualStyleBackColor = true;
            this.btnMultiDisable.Click += new System.EventHandler(this.btnMultiDisable_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(875, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "SALON OLUŞTUR";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblSelledCord
            // 
            this.lblSelledCord.AutoSize = true;
            this.lblSelledCord.Location = new System.Drawing.Point(433, 19);
            this.lblSelledCord.Name = "lblSelledCord";
            this.lblSelledCord.Size = new System.Drawing.Size(92, 15);
            this.lblSelledCord.TabIndex = 5;
            this.lblSelledCord.Text = "Satılan Koltuklar";
            // 
            // lblYCord
            // 
            this.lblYCord.AutoSize = true;
            this.lblYCord.Location = new System.Drawing.Point(235, 20);
            this.lblYCord.Name = "lblYCord";
            this.lblYCord.Size = new System.Drawing.Size(65, 15);
            this.lblYCord.TabIndex = 6;
            this.lblYCord.Text = "Y Kordinatı";
            // 
            // lblEmptyCord
            // 
            this.lblEmptyCord.AutoSize = true;
            this.lblEmptyCord.Location = new System.Drawing.Point(647, 19);
            this.lblEmptyCord.Name = "lblEmptyCord";
            this.lblEmptyCord.Size = new System.Drawing.Size(106, 15);
            this.lblEmptyCord.TabIndex = 7;
            this.lblEmptyCord.Text = "Kaldırılan Koltuklar";
            // 
            // lblXCord
            // 
            this.lblXCord.AutoSize = true;
            this.lblXCord.Location = new System.Drawing.Point(45, 20);
            this.lblXCord.Name = "lblXCord";
            this.lblXCord.Size = new System.Drawing.Size(65, 15);
            this.lblXCord.TabIndex = 8;
            this.lblXCord.Text = "X Kordinatı";
            // 
            // txtSelledCord
            // 
            this.txtSelledCord.Location = new System.Drawing.Point(531, 15);
            this.txtSelledCord.Name = "txtSelledCord";
            this.txtSelledCord.Size = new System.Drawing.Size(100, 23);
            this.txtSelledCord.TabIndex = 2;
            // 
            // txtEmptyCord
            // 
            this.txtEmptyCord.Location = new System.Drawing.Point(759, 15);
            this.txtEmptyCord.Name = "txtEmptyCord";
            this.txtEmptyCord.Size = new System.Drawing.Size(100, 23);
            this.txtEmptyCord.TabIndex = 3;
            // 
            // txtYCord
            // 
            this.txtYCord.Location = new System.Drawing.Point(306, 16);
            this.txtYCord.Name = "txtYCord";
            this.txtYCord.Size = new System.Drawing.Size(100, 23);
            this.txtYCord.TabIndex = 1;
            // 
            // txtXCord
            // 
            this.txtXCord.Location = new System.Drawing.Point(116, 16);
            this.txtXCord.Name = "txtXCord";
            this.txtXCord.Size = new System.Drawing.Size(100, 23);
            this.txtXCord.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1176, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "ARKA ARKAYA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 972);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelCords);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCords;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSelledCord;
        private System.Windows.Forms.Label lblYCord;
        private System.Windows.Forms.Label lblEmptyCord;
        private System.Windows.Forms.Label lblXCord;
        private System.Windows.Forms.TextBox txtSelledCord;
        private System.Windows.Forms.TextBox txtEmptyCord;
        private System.Windows.Forms.TextBox txtYCord;
        private System.Windows.Forms.TextBox txtXCord;
        private System.Windows.Forms.Button btnMultiDisable;
        private System.Windows.Forms.Button button1;
    }
}

