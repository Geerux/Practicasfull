namespace Practicasfull
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeDosNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDe3CalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arraysBidemensionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaDeDosNumerosToolStripMenuItem,
            this.promedioDe3CalificacionesToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.arraysBidemensionalesToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // sumaDeDosNumerosToolStripMenuItem
            // 
            this.sumaDeDosNumerosToolStripMenuItem.Name = "sumaDeDosNumerosToolStripMenuItem";
            this.sumaDeDosNumerosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.sumaDeDosNumerosToolStripMenuItem.Text = "Suma de dos numeros";
            this.sumaDeDosNumerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDeDosNumerosToolStripMenuItem_Click);
            // 
            // promedioDe3CalificacionesToolStripMenuItem
            // 
            this.promedioDe3CalificacionesToolStripMenuItem.Name = "promedioDe3CalificacionesToolStripMenuItem";
            this.promedioDe3CalificacionesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.promedioDe3CalificacionesToolStripMenuItem.Text = "Promedio de 3 calificaciones";
            this.promedioDe3CalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDe3CalificacionesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // arraysBidemensionalesToolStripMenuItem
            // 
            this.arraysBidemensionalesToolStripMenuItem.Name = "arraysBidemensionalesToolStripMenuItem";
            this.arraysBidemensionalesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.arraysBidemensionalesToolStripMenuItem.Text = "Arrays bidemensionales";
            this.arraysBidemensionalesToolStripMenuItem.Click += new System.EventHandler(this.arraysBidemensionalesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de opciones materia paradigmas de programacion";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeDosNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDe3CalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arraysBidemensionalesToolStripMenuItem;
    }
}

