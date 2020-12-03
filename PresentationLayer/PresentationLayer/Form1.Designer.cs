namespace PresentationLayer
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxExpirience = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 11);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(533, 260);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 314);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "FullName";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Location = new System.Drawing.Point(231, 314);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(68, 17);
            this.labelSpeciality.TabIndex = 2;
            this.labelSpeciality.Text = "Speciality";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(456, 314);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(73, 17);
            this.labelExperience.TabIndex = 3;
            this.labelExperience.Text = "Expirience";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 352);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.Location = new System.Drawing.Point(209, 352);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeciality.TabIndex = 5;
            // 
            // textBoxExpirience
            // 
            this.textBoxExpirience.Location = new System.Drawing.Point(434, 352);
            this.textBoxExpirience.Name = "textBoxExpirience";
            this.textBoxExpirience.Size = new System.Drawing.Size(100, 22);
            this.textBoxExpirience.TabIndex = 6;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(209, 401);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(88, 23);
            this.button.TabIndex = 7;
            this.button.Text = "AddToList";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxExpirience);
            this.Controls.Add(this.textBoxSpeciality);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.TextBox textBoxExpirience;
        private System.Windows.Forms.Button button;
    }
}

