namespace Visualization
{
    partial class Sorting
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
            this.label1 = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_suffle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Speed in ms";
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.ForeColor = System.Drawing.Color.Red;
            this.period.Location = new System.Drawing.Point(166, 439);
            this.period.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.period.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.period.Name = "period";
            this.period.ReadOnly = true;
            this.period.Size = new System.Drawing.Size(119, 32);
            this.period.TabIndex = 8;
            this.period.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_start.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Red;
            this.btn_start.Location = new System.Drawing.Point(886, 435);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(162, 37);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Sort";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_close.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(1052, 434);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(162, 37);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(24, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 376);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(421, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 48);
            this.label2.TabIndex = 10;
            // 
            // btn_suffle
            // 
            this.btn_suffle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_suffle.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suffle.ForeColor = System.Drawing.Color.Red;
            this.btn_suffle.Location = new System.Drawing.Point(578, 435);
            this.btn_suffle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_suffle.Name = "btn_suffle";
            this.btn_suffle.Size = new System.Drawing.Size(150, 37);
            this.btn_suffle.TabIndex = 11;
            this.btn_suffle.Text = "Shuffled List";
            this.btn_suffle.UseVisualStyleBackColor = true;
            this.btn_suffle.Click += new System.EventHandler(this.btn_suffle_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(732, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_suffle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.period);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Sorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown period;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_suffle;
        private System.Windows.Forms.Button button1;
    }
}

