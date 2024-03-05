namespace Hashing_Algorithm
{
    partial class Form1
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
            this.originalText = new System.Windows.Forms.RichTextBox();
            this.hashButton = new System.Windows.Forms.Button();
            this.HMACtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hashText = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // originalText
            // 
            this.originalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalText.Location = new System.Drawing.Point(12, 12);
            this.originalText.Name = "originalText";
            this.originalText.Size = new System.Drawing.Size(970, 262);
            this.originalText.TabIndex = 0;
            this.originalText.Text = "";
            // 
            // hashButton
            // 
            this.hashButton.Location = new System.Drawing.Point(426, 305);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(89, 41);
            this.hashButton.TabIndex = 1;
            this.hashButton.Text = "Hash";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // HMACtextBox
            // 
            this.HMACtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMACtextBox.Location = new System.Drawing.Point(79, 311);
            this.HMACtextBox.Name = "HMACtextBox";
            this.HMACtextBox.Size = new System.Drawing.Size(218, 26);
            this.HMACtextBox.TabIndex = 2;
            this.HMACtextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HMAC:";
            this.label1.Visible = false;
            // 
            // hashText
            // 
            this.hashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashText.Location = new System.Drawing.Point(12, 372);
            this.hashText.Name = "hashText";
            this.hashText.Size = new System.Drawing.Size(970, 262);
            this.hashText.TabIndex = 4;
            this.hashText.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable HMAC";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 646);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.hashText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HMACtextBox);
            this.Controls.Add(this.hashButton);
            this.Controls.Add(this.originalText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox originalText;
        private System.Windows.Forms.Button hashButton;
        private System.Windows.Forms.TextBox HMACtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox hashText;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

