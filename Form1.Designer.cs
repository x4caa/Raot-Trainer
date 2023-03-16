namespace Raot
{
    partial class Raot_Trainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raot_Trainer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkbox_Gas = new System.Windows.Forms.CheckBox();
            this.checkbox_Stress = new System.Windows.Forms.CheckBox();
            this.checkbox_Fly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkbox_Gas
            // 
            this.checkbox_Gas.AutoSize = true;
            this.checkbox_Gas.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_Gas.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkbox_Gas.ForeColor = System.Drawing.Color.GhostWhite;
            this.checkbox_Gas.Location = new System.Drawing.Point(12, 12);
            this.checkbox_Gas.Name = "checkbox_Gas";
            this.checkbox_Gas.Size = new System.Drawing.Size(101, 23);
            this.checkbox_Gas.TabIndex = 0;
            this.checkbox_Gas.Text = "Infinite Gas";
            this.checkbox_Gas.UseVisualStyleBackColor = false;
            this.checkbox_Gas.CheckedChanged += new System.EventHandler(this.checkbox_Gas_CheckedChanged);
            // 
            // checkbox_Stress
            // 
            this.checkbox_Stress.AutoSize = true;
            this.checkbox_Stress.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_Stress.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkbox_Stress.ForeColor = System.Drawing.Color.GhostWhite;
            this.checkbox_Stress.Location = new System.Drawing.Point(12, 41);
            this.checkbox_Stress.Name = "checkbox_Stress";
            this.checkbox_Stress.Size = new System.Drawing.Size(87, 23);
            this.checkbox_Stress.TabIndex = 1;
            this.checkbox_Stress.Text = "No Stress";
            this.checkbox_Stress.UseVisualStyleBackColor = false;
            this.checkbox_Stress.CheckedChanged += new System.EventHandler(this.checkbox_Stress_CheckedChanged);
            // 
            // checkbox_Fly
            // 
            this.checkbox_Fly.AutoSize = true;
            this.checkbox_Fly.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_Fly.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkbox_Fly.ForeColor = System.Drawing.Color.GhostWhite;
            this.checkbox_Fly.Location = new System.Drawing.Point(12, 70);
            this.checkbox_Fly.Name = "checkbox_Fly";
            this.checkbox_Fly.Size = new System.Drawing.Size(48, 23);
            this.checkbox_Fly.TabIndex = 2;
            this.checkbox_Fly.Text = "Fly";
            this.checkbox_Fly.UseVisualStyleBackColor = false;
            this.checkbox_Fly.CheckedChanged += new System.EventHandler(this.checkbox_Fly_CheckedChanged);
            // 
            // Raot_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(119, 103);
            this.Controls.Add(this.checkbox_Fly);
            this.Controls.Add(this.checkbox_Stress);
            this.Controls.Add(this.checkbox_Gas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raot_Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Raot Trainer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private CheckBox checkbox_Gas;
        private CheckBox checkbox_Stress;
        private CheckBox checkbox_Fly;
    }
}