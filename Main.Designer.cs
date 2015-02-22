namespace wordMoo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.EditType = new System.Windows.Forms.Button();
            this.OpenTest = new System.Windows.Forms.Button();
            this.TypeList = new System.Windows.Forms.ListBox();
            this.AddType = new System.Windows.Forms.Button();
            this.DeleteType = new System.Windows.Forms.Button();
            this.OpenThing = new System.Windows.Forms.Button();
            this.SaveThings = new System.Windows.Forms.Button();
            this.CopyType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditType
            // 
            this.EditType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditType.Location = new System.Drawing.Point(409, 12);
            this.EditType.Name = "EditType";
            this.EditType.Size = new System.Drawing.Size(93, 37);
            this.EditType.TabIndex = 3;
            this.EditType.Text = "Edit";
            this.EditType.UseVisualStyleBackColor = false;
            this.EditType.Click += new System.EventHandler(this.EditType_Click);
            // 
            // OpenTest
            // 
            this.OpenTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenTest.Location = new System.Drawing.Point(310, 187);
            this.OpenTest.Name = "OpenTest";
            this.OpenTest.Size = new System.Drawing.Size(192, 102);
            this.OpenTest.TabIndex = 4;
            this.OpenTest.Text = "Test";
            this.OpenTest.UseVisualStyleBackColor = false;
            this.OpenTest.Click += new System.EventHandler(this.OpenTest_Click);
            // 
            // TypeList
            // 
            this.TypeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Location = new System.Drawing.Point(12, 12);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(285, 277);
            this.TypeList.TabIndex = 5;
            this.TypeList.SelectedIndexChanged += new System.EventHandler(this.TypeList_SelectedIndexChanged);
            // 
            // AddType
            // 
            this.AddType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddType.Location = new System.Drawing.Point(310, 12);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(93, 37);
            this.AddType.TabIndex = 6;
            this.AddType.Text = "New";
            this.AddType.UseVisualStyleBackColor = false;
            this.AddType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // DeleteType
            // 
            this.DeleteType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteType.Location = new System.Drawing.Point(310, 55);
            this.DeleteType.Name = "DeleteType";
            this.DeleteType.Size = new System.Drawing.Size(93, 37);
            this.DeleteType.TabIndex = 7;
            this.DeleteType.Text = "Delete";
            this.DeleteType.UseVisualStyleBackColor = false;
            this.DeleteType.Click += new System.EventHandler(this.DeleteType_Click);
            // 
            // OpenThing
            // 
            this.OpenThing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenThing.Location = new System.Drawing.Point(310, 144);
            this.OpenThing.Name = "OpenThing";
            this.OpenThing.Size = new System.Drawing.Size(93, 37);
            this.OpenThing.TabIndex = 8;
            this.OpenThing.Text = "Open";
            this.OpenThing.UseVisualStyleBackColor = false;
            this.OpenThing.Click += new System.EventHandler(this.OpenThing_Click);
            // 
            // SaveThings
            // 
            this.SaveThings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveThings.Location = new System.Drawing.Point(409, 144);
            this.SaveThings.Name = "SaveThings";
            this.SaveThings.Size = new System.Drawing.Size(93, 37);
            this.SaveThings.TabIndex = 9;
            this.SaveThings.Text = "Save";
            this.SaveThings.UseVisualStyleBackColor = false;
            this.SaveThings.Click += new System.EventHandler(this.SaveThings_Click);
            // 
            // CopyType
            // 
            this.CopyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyType.Location = new System.Drawing.Point(409, 55);
            this.CopyType.Name = "CopyType";
            this.CopyType.Size = new System.Drawing.Size(93, 37);
            this.CopyType.TabIndex = 10;
            this.CopyType.Text = "Copy";
            this.CopyType.UseVisualStyleBackColor = false;
            this.CopyType.Click += new System.EventHandler(this.CopyType_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 301);
            this.Controls.Add(this.CopyType);
            this.Controls.Add(this.SaveThings);
            this.Controls.Add(this.OpenThing);
            this.Controls.Add(this.DeleteType);
            this.Controls.Add(this.AddType);
            this.Controls.Add(this.OpenTest);
            this.Controls.Add(this.EditType);
            this.Controls.Add(this.TypeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditType;
        private System.Windows.Forms.Button OpenTest;
        private System.Windows.Forms.ListBox TypeList;
        private System.Windows.Forms.Button AddType;
        private System.Windows.Forms.Button DeleteType;
        private System.Windows.Forms.Button OpenThing;
        private System.Windows.Forms.Button SaveThings;
        private System.Windows.Forms.Button CopyType;
    }
}