namespace M16_68
{
    partial class Form_CEventos
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
			this.lv_eventos = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_local = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_desc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_dataF = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_dataI = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lv_eventos
			// 
			this.lv_eventos.HideSelection = false;
			this.lv_eventos.Location = new System.Drawing.Point(12, 139);
			this.lv_eventos.Name = "lv_eventos";
			this.lv_eventos.Size = new System.Drawing.Size(357, 196);
			this.lv_eventos.TabIndex = 0;
			this.lv_eventos.UseCompatibleStateImageBehavior = false;
			this.lv_eventos.SelectedIndexChanged += new System.EventHandler(this.lv_eventos_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Local";
			// 
			// txt_local
			// 
			this.txt_local.Location = new System.Drawing.Point(12, 77);
			this.txt_local.Name = "txt_local";
			this.txt_local.ReadOnly = true;
			this.txt_local.Size = new System.Drawing.Size(100, 20);
			this.txt_local.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Coleções do Evento";
			// 
			// txt_desc
			// 
			this.txt_desc.Location = new System.Drawing.Point(375, 139);
			this.txt_desc.Multiline = true;
			this.txt_desc.Name = "txt_desc";
			this.txt_desc.ReadOnly = true;
			this.txt_desc.Size = new System.Drawing.Size(266, 196);
			this.txt_desc.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(372, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Descrição do Evento";
			// 
			// txt_dataF
			// 
			this.txt_dataF.Location = new System.Drawing.Point(224, 77);
			this.txt_dataF.Name = "txt_dataF";
			this.txt_dataF.ReadOnly = true;
			this.txt_dataF.Size = new System.Drawing.Size(100, 20);
			this.txt_dataF.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Data Fim";
			// 
			// txt_dataI
			// 
			this.txt_dataI.Location = new System.Drawing.Point(118, 77);
			this.txt_dataI.Name = "txt_dataI";
			this.txt_dataI.ReadOnly = true;
			this.txt_dataI.Size = new System.Drawing.Size(100, 20);
			this.txt_dataI.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(118, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Data Inicio";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(312, 20);
			this.textBox1.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Nome";
			// 
			// Form_CEventos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 347);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txt_dataI);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_dataF);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_desc);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_local);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lv_eventos);
			this.Name = "Form_CEventos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta Eventos";
			this.Load += new System.EventHandler(this.Form_CEventos_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_eventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dataF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dataI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}