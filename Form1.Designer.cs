namespace WinGitHub
{
    partial class MekhedaDima
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGaf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Животные";
            // 
            // ButtonGaf
            // 
            this.ButtonGaf.Location = new System.Drawing.Point(520, 158);
            this.ButtonGaf.Name = "ButtonGaf";
            this.ButtonGaf.Size = new System.Drawing.Size(166, 87);
            this.ButtonGaf.TabIndex = 1;
            this.ButtonGaf.Text = "Собака";
            this.ButtonGaf.UseVisualStyleBackColor = true;
            this.ButtonGaf.Click += new System.EventHandler(this.ButtonGaf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кошка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MekhedaDima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonGaf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MekhedaDima";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ButtonGaf;
        private Button button1;
    }
}