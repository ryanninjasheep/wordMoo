namespace wordMoo
{
    partial class NewThing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewThing));
            this.ToName = new System.Windows.Forms.TextBox();
            this.NameIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToName
            // 
            this.ToName.Location = new System.Drawing.Point(13, 13);
            this.ToName.Name = "ToName";
            this.ToName.Size = new System.Drawing.Size(312, 20);
            this.ToName.TabIndex = 0;
            // 
            // NameIt
            // 
            this.NameIt.Location = new System.Drawing.Point(13, 39);
            this.NameIt.Name = "NameIt";
            this.NameIt.Size = new System.Drawing.Size(312, 27);
            this.NameIt.TabIndex = 1;
            this.NameIt.Text = "Create";
            this.NameIt.UseVisualStyleBackColor = true;
            this.NameIt.Click += new System.EventHandler(this.NameIt_Click);
            // 
            // NewThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 78);
            this.Controls.Add(this.NameIt);
            this.Controls.Add(this.ToName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewThing";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.NewThing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToName;
        private System.Windows.Forms.Button NameIt;
    }
}