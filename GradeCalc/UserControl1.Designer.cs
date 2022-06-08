namespace GradeCalc
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbutton1 = new GradeCalc.RJButton();
            this.rjButton1 = new GradeCalc.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbutton1
            // 
            this.rbutton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbutton1.BackColor1 = System.Drawing.Color.Empty;
            this.rbutton1.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbutton1.BorderRadius = 20;
            this.rbutton1.BorderSize = 2;
            this.rbutton1.FlatAppearance.BorderSize = 0;
            this.rbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbutton1.ForeColor = System.Drawing.Color.Fuchsia;
            this.rbutton1.ForeColor1 = System.Drawing.Color.Empty;
            this.rbutton1.Location = new System.Drawing.Point(80, 344);
            this.rbutton1.Name = "rbutton1";
            this.rbutton1.Size = new System.Drawing.Size(252, 52);
            this.rbutton1.TabIndex = 17;
            this.rbutton1.Text = "Calculate";
            this.rbutton1.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rjButton1.BackColor1 = System.Drawing.Color.Empty;
            this.rjButton1.BorderColor = System.Drawing.Color.Lime;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Lime;
            this.rjButton1.ForeColor1 = System.Drawing.Color.Empty;
            this.rjButton1.Location = new System.Drawing.Point(80, 277);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(252, 52);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "Add";
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(270, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grade %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbutton1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(413, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton rbutton1;
        private RJButton rjButton1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
