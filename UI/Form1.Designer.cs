namespace UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paste_txtbox = new System.Windows.Forms.TextBox();
            this.copy_txtbox = new System.Windows.Forms.TextBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paste_txtbox);
            this.groupBox1.Controls.Add(this.copy_txtbox);
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.copy_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // paste_txtbox
            // 
            this.paste_txtbox.Location = new System.Drawing.Point(453, 19);
            this.paste_txtbox.Multiline = true;
            this.paste_txtbox.Name = "paste_txtbox";
            this.paste_txtbox.Size = new System.Drawing.Size(323, 307);
            this.paste_txtbox.TabIndex = 3;
            this.paste_txtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paste_txtbox_MouseDown);
            // 
            // copy_txtbox
            // 
            this.copy_txtbox.Location = new System.Drawing.Point(0, 19);
            this.copy_txtbox.Multiline = true;
            this.copy_txtbox.Name = "copy_txtbox";
            this.copy_txtbox.Size = new System.Drawing.Size(356, 307);
            this.copy_txtbox.TabIndex = 2;
            this.copy_txtbox.TextChanged += new System.EventHandler(this.Copy_txtbox_TextChanged);
            this.copy_txtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.copy_txtbox_MouseDown);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(611, 397);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(611, 332);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(75, 23);
            this.copy_btn.TabIndex = 0;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.Copy_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox paste_txtbox;
        private System.Windows.Forms.TextBox copy_txtbox;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button copy_btn;
    }
}

