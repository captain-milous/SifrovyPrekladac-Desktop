namespace SifrovyPrekladac.src.forms
{
    partial class MainMenuForm
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
            this.PrekladBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrekladBTN
            // 
            this.PrekladBTN.Location = new System.Drawing.Point(287, 75);
            this.PrekladBTN.Name = "PrekladBTN";
            this.PrekladBTN.Size = new System.Drawing.Size(170, 48);
            this.PrekladBTN.TabIndex = 0;
            this.PrekladBTN.Text = "Překlad";
            this.PrekladBTN.UseVisualStyleBackColor = true;
            this.PrekladBTN.Click += new System.EventHandler(this.PrekladBTN_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrekladBTN);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrekladBTN;
    }
}