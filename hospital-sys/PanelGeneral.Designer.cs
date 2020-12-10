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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mainActions = new System.Windows.Forms.Panel();
            this.mainActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // UserPanel
            // 
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPanel.Location = new System.Drawing.Point(120, 13);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.ReadOnly = true;
            this.UserPanel.Size = new System.Drawing.Size(229, 23);
            this.UserPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "PANEL DE CONTROL ADMINISTRADOR ";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(29, 86);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(148, 84);
            this.txtPaciente.TabIndex = 3;
            this.txtPaciente.Text = "PACIENTES";
            this.txtPaciente.UseVisualStyleBackColor = true;
            this.txtPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(473, 86);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(148, 84);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "USUARIOS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(342, 86);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(125, 84);
            this.btnNotify.TabIndex = 5;
            this.btnNotify.Text = "NOTIFICACIONES";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(185, 86);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(148, 82);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "DESCANSOS MEDICOS";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(627, 86);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(148, 82);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(965, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // mainActions
            // 
            this.mainActions.Controls.Add(this.btnReportes);
            this.mainActions.Controls.Add(this.txtPaciente);
            this.mainActions.Controls.Add(this.label2);
            this.mainActions.Controls.Add(this.btnUsers);
            this.mainActions.Controls.Add(this.btnUsuario);
            this.mainActions.Controls.Add(this.btnNotify);
            this.mainActions.Location = new System.Drawing.Point(93, 113);
            this.mainActions.Name = "mainActions";
            this.mainActions.Size = new System.Drawing.Size(815, 196);
            this.mainActions.TabIndex = 9;
            // 
            // PanelGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 507);
            this.Controls.Add(this.mainActions);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.label1);
            this.Name = "PanelGeneral";
            this.Text = "PanelGeneral";
            this.Load += new System.EventHandler(this.PanelGeneral_Load);
            this.mainActions.ResumeLayout(false);
            this.mainActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtPaciente;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel mainActions;
    }
}