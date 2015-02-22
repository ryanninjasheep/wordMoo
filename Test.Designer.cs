namespace wordMoo
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.OutputText = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.UpdateOut = new System.Windows.Forms.Button();
            this.IterateBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputText.Location = new System.Drawing.Point(12, 12);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(516, 187);
            this.OutputText.TabIndex = 0;
            // 
            // InputText
            // 
            this.InputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputText.Location = new System.Drawing.Point(12, 205);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputText.Size = new System.Drawing.Size(516, 198);
            this.InputText.TabIndex = 0;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // UpdateOut
            // 
            this.UpdateOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateOut.Location = new System.Drawing.Point(13, 410);
            this.UpdateOut.Name = "UpdateOut";
            this.UpdateOut.Size = new System.Drawing.Size(447, 31);
            this.UpdateOut.TabIndex = 2;
            this.UpdateOut.Text = "Update";
            this.UpdateOut.UseVisualStyleBackColor = true;
            this.UpdateOut.Click += new System.EventHandler(this.UpdateOut_Click);
            // 
            // IterateBox
            // 
            this.IterateBox.AutoSize = true;
            this.IterateBox.Location = new System.Drawing.Point(466, 418);
            this.IterateBox.Name = "IterateBox";
            this.IterateBox.Size = new System.Drawing.Size(62, 17);
            this.IterateBox.TabIndex = 3;
            this.IterateBox.Text = "Iterate?";
            this.IterateBox.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 453);
            this.Controls.Add(this.IterateBox);
            this.Controls.Add(this.UpdateOut);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.OutputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button UpdateOut;
        private System.Windows.Forms.CheckBox IterateBox;
    }
}

