namespace SifrovyPrekladac.src.forms
{
    partial class PrekladForm
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
            this.TextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.TextBoxInput = new System.Windows.Forms.RichTextBox();
            this.BackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxOutput.Location = new System.Drawing.Point(503, 12);
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.Size = new System.Drawing.Size(469, 209);
            this.TextBoxOutput.TabIndex = 0;
            this.TextBoxOutput.Text = "";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(469, 209);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.Text = "";
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(139, 366);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 23);
            this.BackBTN.TabIndex = 2;
            this.BackBTN.Text = "Zpět";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // PrekladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.TextBoxOutput);
            this.Name = "PrekladForm";
            this.Text = "PrekladForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxOutput;
        private System.Windows.Forms.RichTextBox TextBoxInput;
        private System.Windows.Forms.Button BackBTN;
    }
}