namespace CartomancyUI
{
    partial class MainForm
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
            this.MapHorzLabel = new System.Windows.Forms.Label();
            this.MapHorzTextBox = new System.Windows.Forms.TextBox();
            this.MapVertLabel = new System.Windows.Forms.Label();
            this.MapVertTextBox = new System.Windows.Forms.TextBox();
            this.JsonLabel = new System.Windows.Forms.Label();
            this.JsonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateJsonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MapHorzLabel
            // 
            this.MapHorzLabel.AutoSize = true;
            this.MapHorzLabel.Location = new System.Drawing.Point(9, 8);
            this.MapHorzLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MapHorzLabel.Name = "MapHorzLabel";
            this.MapHorzLabel.Size = new System.Drawing.Size(77, 13);
            this.MapHorzLabel.TabIndex = 0;
            this.MapHorzLabel.Text = "Horizontal Size";
            // 
            // MapHorzTextBox
            // 
            this.MapHorzTextBox.Location = new System.Drawing.Point(8, 23);
            this.MapHorzTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapHorzTextBox.Name = "MapHorzTextBox";
            this.MapHorzTextBox.Size = new System.Drawing.Size(68, 20);
            this.MapHorzTextBox.TabIndex = 1;
            this.MapHorzTextBox.Text = "100";
            // 
            // MapVertLabel
            // 
            this.MapVertLabel.AutoSize = true;
            this.MapVertLabel.Location = new System.Drawing.Point(9, 50);
            this.MapVertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MapVertLabel.Name = "MapVertLabel";
            this.MapVertLabel.Size = new System.Drawing.Size(65, 13);
            this.MapVertLabel.TabIndex = 2;
            this.MapVertLabel.Text = "Vertical Size";
            // 
            // MapVertTextBox
            // 
            this.MapVertTextBox.Location = new System.Drawing.Point(8, 66);
            this.MapVertTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapVertTextBox.Name = "MapVertTextBox";
            this.MapVertTextBox.Size = new System.Drawing.Size(68, 20);
            this.MapVertTextBox.TabIndex = 3;
            this.MapVertTextBox.Text = "200";
            // 
            // JsonLabel
            // 
            this.JsonLabel.AutoSize = true;
            this.JsonLabel.Location = new System.Drawing.Point(8, 104);
            this.JsonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JsonLabel.Name = "JsonLabel";
            this.JsonLabel.Size = new System.Drawing.Size(29, 13);
            this.JsonLabel.TabIndex = 4;
            this.JsonLabel.Text = "Json";
            // 
            // JsonRichTextBox
            // 
            this.JsonRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonRichTextBox.Location = new System.Drawing.Point(8, 120);
            this.JsonRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JsonRichTextBox.Name = "JsonRichTextBox";
            this.JsonRichTextBox.ReadOnly = true;
            this.JsonRichTextBox.Size = new System.Drawing.Size(513, 166);
            this.JsonRichTextBox.TabIndex = 5;
            this.JsonRichTextBox.Text = "";
            // 
            // GenerateJsonButton
            // 
            this.GenerateJsonButton.Location = new System.Drawing.Point(103, 37);
            this.GenerateJsonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateJsonButton.Name = "GenerateJsonButton";
            this.GenerateJsonButton.Size = new System.Drawing.Size(101, 26);
            this.GenerateJsonButton.TabIndex = 6;
            this.GenerateJsonButton.Text = "Generate Json";
            this.GenerateJsonButton.UseVisualStyleBackColor = true;
            this.GenerateJsonButton.Click += new System.EventHandler(this.GenerateJsonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.GenerateJsonButton);
            this.Controls.Add(this.JsonRichTextBox);
            this.Controls.Add(this.JsonLabel);
            this.Controls.Add(this.MapVertTextBox);
            this.Controls.Add(this.MapVertLabel);
            this.Controls.Add(this.MapHorzTextBox);
            this.Controls.Add(this.MapHorzLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MapHorzLabel;
        private System.Windows.Forms.TextBox MapHorzTextBox;
        private System.Windows.Forms.Label MapVertLabel;
        private System.Windows.Forms.TextBox MapVertTextBox;
        private System.Windows.Forms.Label JsonLabel;
        private System.Windows.Forms.RichTextBox JsonRichTextBox;
        private System.Windows.Forms.Button GenerateJsonButton;
    }
}

