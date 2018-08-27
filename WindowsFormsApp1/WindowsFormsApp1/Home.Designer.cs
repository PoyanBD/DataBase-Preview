namespace WindowsFormsApp1
{
    partial class Home
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
            this.AddB = new System.Windows.Forms.Button();
            this.SearchB = new System.Windows.Forms.Button();
            this.AllB = new System.Windows.Forms.Button();
            this.ListB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(12, 12);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(158, 111);
            this.AddB.TabIndex = 0;
            this.AddB.Text = "add";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(176, 12);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(158, 111);
            this.SearchB.TabIndex = 2;
            this.SearchB.Text = "search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // AllB
            // 
            this.AllB.Location = new System.Drawing.Point(340, 12);
            this.AllB.Name = "AllB";
            this.AllB.Size = new System.Drawing.Size(158, 111);
            this.AllB.TabIndex = 3;
            this.AllB.Text = "all";
            this.AllB.UseVisualStyleBackColor = true;
            this.AllB.Click += new System.EventHandler(this.AllB_Click);
            // 
            // ListB
            // 
            this.ListB.Location = new System.Drawing.Point(504, 12);
            this.ListB.Name = "ListB";
            this.ListB.Size = new System.Drawing.Size(158, 111);
            this.ListB.TabIndex = 4;
            this.ListB.Text = "List";
            this.ListB.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 144);
            this.Controls.Add(this.ListB);
            this.Controls.Add(this.AllB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.AddB);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button AllB;
        private System.Windows.Forms.Button ListB;
    }
}

