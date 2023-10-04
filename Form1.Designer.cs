namespace radioButton08
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbavion = new System.Windows.Forms.RadioButton();
            this.rbautobus = new System.Windows.Forms.RadioButton();
            this.rbvlastit = new System.Windows.Forms.RadioButton();
            this.btrezerviraj = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbvlastit);
            this.gb1.Controls.Add(this.rbautobus);
            this.gb1.Controls.Add(this.rbavion);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb1.Location = new System.Drawing.Point(225, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(270, 174);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Odaberite vrstu prijevoza";
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbavion
            // 
            this.rbavion.AutoSize = true;
            this.rbavion.Location = new System.Drawing.Point(35, 38);
            this.rbavion.Name = "rbavion";
            this.rbavion.Size = new System.Drawing.Size(76, 28);
            this.rbavion.TabIndex = 0;
            this.rbavion.TabStop = true;
            this.rbavion.Text = "Avion";
            this.rbavion.UseVisualStyleBackColor = true;
            // 
            // rbautobus
            // 
            this.rbautobus.AutoSize = true;
            this.rbautobus.Location = new System.Drawing.Point(35, 82);
            this.rbautobus.Name = "rbautobus";
            this.rbautobus.Size = new System.Drawing.Size(98, 28);
            this.rbautobus.TabIndex = 1;
            this.rbautobus.TabStop = true;
            this.rbautobus.Text = "Autobus";
            this.rbautobus.UseVisualStyleBackColor = true;
            // 
            // rbvlastit
            // 
            this.rbvlastit.AutoSize = true;
            this.rbvlastit.Location = new System.Drawing.Point(35, 128);
            this.rbvlastit.Name = "rbvlastit";
            this.rbvlastit.Size = new System.Drawing.Size(193, 28);
            this.rbvlastit.TabIndex = 2;
            this.rbvlastit.TabStop = true;
            this.rbvlastit.Text = "Vlastitim prijevozom";
            this.rbvlastit.UseVisualStyleBackColor = true;
            // 
            // btrezerviraj
            // 
            this.btrezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btrezerviraj.Location = new System.Drawing.Point(286, 213);
            this.btrezerviraj.Name = "btrezerviraj";
            this.btrezerviraj.Size = new System.Drawing.Size(127, 39);
            this.btrezerviraj.TabIndex = 1;
            this.btrezerviraj.Text = "Rezerviraj";
            this.btrezerviraj.UseVisualStyleBackColor = true;
            this.btrezerviraj.Click += new System.EventHandler(this.btrezerviraj_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb1.Location = new System.Drawing.Point(239, 280);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(228, 96);
            this.tb1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btrezerviraj);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbvlastit;
        private System.Windows.Forms.RadioButton rbautobus;
        private System.Windows.Forms.RadioButton rbavion;
        private System.Windows.Forms.Button btrezerviraj;
        private System.Windows.Forms.TextBox tb1;
    }
}

