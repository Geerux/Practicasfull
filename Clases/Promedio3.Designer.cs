namespace Practicasfull
{
    partial class Promedio3
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.txtcali3 = new System.Windows.Forms.TextBox();
            this.txtcali2 = new System.Windows.Forms.TextBox();
            this.txtcali1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(408, 307);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 26;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(392, 252);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(100, 20);
            this.txtpromedio.TabIndex = 25;
            // 
            // txtcali3
            // 
            this.txtcali3.Location = new System.Drawing.Point(392, 212);
            this.txtcali3.Name = "txtcali3";
            this.txtcali3.Size = new System.Drawing.Size(100, 20);
            this.txtcali3.TabIndex = 24;
            // 
            // txtcali2
            // 
            this.txtcali2.Location = new System.Drawing.Point(392, 165);
            this.txtcali2.Name = "txtcali2";
            this.txtcali2.Size = new System.Drawing.Size(100, 20);
            this.txtcali2.TabIndex = 23;
            // 
            // txtcali1
            // 
            this.txtcali1.Location = new System.Drawing.Point(392, 121);
            this.txtcali1.Name = "txtcali1";
            this.txtcali1.Size = new System.Drawing.Size(100, 20);
            this.txtcali1.TabIndex = 22;
            this.txtcali1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Calificacion 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Calificacion 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Calificacion 1";
            // 
            // Promedio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.txtcali3);
            this.Controls.Add(this.txtcali2);
            this.Controls.Add(this.txtcali1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Promedio3";
            this.Text = "Promedio3";
            this.Load += new System.EventHandler(this.Promedio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.TextBox txtcali3;
        private System.Windows.Forms.TextBox txtcali2;
        private System.Windows.Forms.TextBox txtcali1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}