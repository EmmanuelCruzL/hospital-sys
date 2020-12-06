namespace hospital_sys
{
    partial class PanelGeneral
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
            this.UserPanel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.Button();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // UserPanel
            // 
            this.UserPanel.Location = new System.Drawing.Point(111, 13);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.ReadOnly = true;
            this.UserPanel.Size = new System.Drawing.Size(100, 20);
            this.UserPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "PANEL DE CONTROL ADMINISTRADOR ";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(95, 155);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(148, 84);
            this.txtPaciente.TabIndex = 3;
            this.txtPaciente.Text = "Pacientes";
            this.txtPaciente.UseVisualStyleBackColor = true;
            this.txtPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDescanso
            // 
            this.btnDescanso.Location = new System.Drawing.Point(95, 263);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(148, 84);
            this.btnDescanso.TabIndex = 4;
            this.btnDescanso.Text = "USUARIOS";
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(425, 155);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(125, 84);
            this.btnNotify.TabIndex = 5;
            this.btnNotify.Text = "NOTIFICACIONES";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(251, 155);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(148, 82);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "PANEL MEDICO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(251, 263);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(148, 82);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(823, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 25);
            this.button6.TabIndex = 8;
            this.button6.Text = "EXIT";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salir";
            // 
            // PanelGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.btnDescanso);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.label1);
            this.Name = "PanelGeneral";
            this.Text = "PanelGeneral";
            this.Load += new System.EventHandler(this.PanelGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtPaciente;
        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
    }
}