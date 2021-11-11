
namespace WasteEater.UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.parametersPanel = new System.Windows.Forms.Panel();
            this.getDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.parametersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(354, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 681);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(892, 665);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(350, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 681);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // parametersPanel
            // 
            this.parametersPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.parametersPanel.Controls.Add(this.getDataButton);
            this.parametersPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.parametersPanel.Location = new System.Drawing.Point(0, 0);
            this.parametersPanel.Name = "parametersPanel";
            this.parametersPanel.Size = new System.Drawing.Size(350, 681);
            this.parametersPanel.TabIndex = 0;
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(89, 597);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(133, 59);
            this.getDataButton.TabIndex = 0;
            this.getDataButton.Text = "Search";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parametersPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.parametersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel parametersPanel;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        //private System.Windows.Forms.Label newPriceLabel;
        //private System.Windows.Forms.Label nameLabel;
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Label experationLabel;
        //private System.Windows.Forms.Label piecesLabel;
        //private System.Windows.Forms.Label oldPriceLabel;
        //private System.Windows.Forms.Label updatedLabel;
        //private System.Windows.Forms.Label storeInfoLabel;
        //private System.Windows.Forms.Panel productLayout;
    }
}

