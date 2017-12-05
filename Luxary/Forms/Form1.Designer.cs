namespace Luxary
{
    partial class FormConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtSayHello = new System.Windows.Forms.Button();
            this.sleep = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TRNG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConsole.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtConsole.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtConsole.Location = new System.Drawing.Point(12, 55);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(576, 306);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.TabStop = false;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // txtSayHello
            // 
            this.txtSayHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSayHello.Location = new System.Drawing.Point(12, 12);
            this.txtSayHello.Name = "txtSayHello";
            this.txtSayHello.Size = new System.Drawing.Size(75, 37);
            this.txtSayHello.TabIndex = 1;
            this.txtSayHello.Text = "Go online";
            this.txtSayHello.UseVisualStyleBackColor = false;
            this.txtSayHello.Click += new System.EventHandler(this.txtSayHello_Click);
            // 
            // sleep
            // 
            this.sleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sleep.Location = new System.Drawing.Point(94, 12);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(77, 37);
            this.sleep.TabIndex = 2;
            this.sleep.Text = "Go offline";
            this.sleep.UseVisualStyleBackColor = false;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(508, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(80, 37);
            this.Close.TabIndex = 3;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Channel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Music";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Normal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(589, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 19);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CPU
            // 
            this.CPU.Location = new System.Drawing.Point(604, 29);
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.Size = new System.Drawing.Size(120, 20);
            this.CPU.TabIndex = 10;
            this.CPU.TabStop = false;
            this.CPU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPU Usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Available RAM:";
            // 
            // RAM
            // 
            this.RAM.Location = new System.Drawing.Point(604, 73);
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Size = new System.Drawing.Size(120, 20);
            this.RAM.TabIndex = 13;
            this.RAM.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time running:";
            // 
            // TRNG
            // 
            this.TRNG.Location = new System.Drawing.Point(603, 117);
            this.TRNG.Name = "TRNG";
            this.TRNG.ReadOnly = true;
            this.TRNG.Size = new System.Drawing.Size(121, 20);
            this.TRNG.TabIndex = 15;
            this.TRNG.TabStop = false;
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 373);
            this.Controls.Add(this.TRNG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.txtSayHello);
            this.Controls.Add(this.txtConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsole";
            this.Text = "Luxary Console";
            this.Load += new System.EventHandler(this.FormConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button txtSayHello;
        private System.Windows.Forms.Button sleep;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TRNG;
    }
}
