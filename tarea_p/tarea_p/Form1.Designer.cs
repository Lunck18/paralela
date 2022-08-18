
namespace tarea_p
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBoxProcesos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPid = new System.Windows.Forms.ListBox();
            this.listBoxMR = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonA = new System.Windows.Forms.Button();
            this.botonD = new System.Windows.Forms.Button();
            this.botonC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PA = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCPU = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProcesos
            // 
            this.listBoxProcesos.FormattingEnabled = true;
            this.listBoxProcesos.Location = new System.Drawing.Point(32, 70);
            this.listBoxProcesos.Name = "listBoxProcesos";
            this.listBoxProcesos.Size = new System.Drawing.Size(119, 316);
            this.listBoxProcesos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procesos ▼";
            // 
            // listBoxPid
            // 
            this.listBoxPid.FormattingEnabled = true;
            this.listBoxPid.Location = new System.Drawing.Point(167, 70);
            this.listBoxPid.Name = "listBoxPid";
            this.listBoxPid.Size = new System.Drawing.Size(119, 316);
            this.listBoxPid.TabIndex = 2;
            // 
            // listBoxMR
            // 
            this.listBoxMR.FormattingEnabled = true;
            this.listBoxMR.Location = new System.Drawing.Point(305, 70);
            this.listBoxMR.Name = "listBoxMR";
            this.listBoxMR.Size = new System.Drawing.Size(119, 316);
            this.listBoxMR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PID  ▼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Memoria Ram ▼";
            // 
            // botonA
            // 
            this.botonA.Location = new System.Drawing.Point(118, 392);
            this.botonA.Name = "botonA";
            this.botonA.Size = new System.Drawing.Size(75, 23);
            this.botonA.TabIndex = 6;
            this.botonA.Text = "Actualizar";
            this.botonA.UseVisualStyleBackColor = true;
            this.botonA.Click += new System.EventHandler(this.botonA_Click);
            // 
            // botonD
            // 
            this.botonD.Location = new System.Drawing.Point(260, 392);
            this.botonD.Name = "botonD";
            this.botonD.Size = new System.Drawing.Size(75, 23);
            this.botonD.TabIndex = 7;
            this.botonD.Text = "Detener";
            this.botonD.UseVisualStyleBackColor = true;
            this.botonD.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonC
            // 
            this.botonC.Location = new System.Drawing.Point(397, 392);
            this.botonC.Name = "botonC";
            this.botonC.Size = new System.Drawing.Size(75, 23);
            this.botonC.TabIndex = 8;
            this.botonC.Text = "Cerrar";
            this.botonC.UseVisualStyleBackColor = true;
            this.botonC.Click += new System.EventHandler(this.botonC_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PA
            // 
            this.PA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(118, 17);
            this.PA.Text = "toolStripStatusLabel1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPU ▼";
            // 
            // listBoxCPU
            // 
            this.listBoxCPU.FormattingEnabled = true;
            this.listBoxCPU.Location = new System.Drawing.Point(443, 70);
            this.listBoxCPU.Name = "listBoxCPU";
            this.listBoxCPU.Size = new System.Drawing.Size(119, 316);
            this.listBoxCPU.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tarea_p.Properties.Resources.fondo_tarea_de_paralela;
            this.ClientSize = new System.Drawing.Size(578, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCPU);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.botonC);
            this.Controls.Add(this.botonD);
            this.Controls.Add(this.botonA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMR);
            this.Controls.Add(this.listBoxPid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProcesos);
            this.Name = "Form1";
            this.Text = "Administrador de tarea flash :v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPid;
        private System.Windows.Forms.ListBox listBoxMR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonA;
        private System.Windows.Forms.Button botonD;
        private System.Windows.Forms.Button botonC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCPU;
    }
}

