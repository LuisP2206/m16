namespace M16_68
{
    partial class Form_Adm
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
			this.cbC_moeda = new System.Windows.Forms.ComboBox();
			this.cbC_colecao = new System.Windows.Forms.ComboBox();
			this.cbC_eventos = new System.Windows.Forms.ComboBox();
			this.btnC_moedas = new System.Windows.Forms.Button();
			this.btnC_colecao = new System.Windows.Forms.Button();
			this.btnC_eventos = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.suasMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarMoedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbC_moeda
			// 
			this.cbC_moeda.FormattingEnabled = true;
			this.cbC_moeda.Location = new System.Drawing.Point(12, 203);
			this.cbC_moeda.Name = "cbC_moeda";
			this.cbC_moeda.Size = new System.Drawing.Size(179, 21);
			this.cbC_moeda.TabIndex = 22;
			// 
			// cbC_colecao
			// 
			this.cbC_colecao.FormattingEnabled = true;
			this.cbC_colecao.Location = new System.Drawing.Point(12, 167);
			this.cbC_colecao.Name = "cbC_colecao";
			this.cbC_colecao.Size = new System.Drawing.Size(179, 21);
			this.cbC_colecao.TabIndex = 21;
			// 
			// cbC_eventos
			// 
			this.cbC_eventos.FormattingEnabled = true;
			this.cbC_eventos.Location = new System.Drawing.Point(12, 128);
			this.cbC_eventos.Name = "cbC_eventos";
			this.cbC_eventos.Size = new System.Drawing.Size(179, 21);
			this.cbC_eventos.TabIndex = 20;
			// 
			// btnC_moedas
			// 
			this.btnC_moedas.Location = new System.Drawing.Point(197, 201);
			this.btnC_moedas.Name = "btnC_moedas";
			this.btnC_moedas.Size = new System.Drawing.Size(75, 23);
			this.btnC_moedas.TabIndex = 19;
			this.btnC_moedas.Text = "Consultar";
			this.btnC_moedas.UseVisualStyleBackColor = true;
			this.btnC_moedas.Click += new System.EventHandler(this.btnC_moedas_Click);
			// 
			// btnC_colecao
			// 
			this.btnC_colecao.Location = new System.Drawing.Point(197, 165);
			this.btnC_colecao.Name = "btnC_colecao";
			this.btnC_colecao.Size = new System.Drawing.Size(75, 23);
			this.btnC_colecao.TabIndex = 18;
			this.btnC_colecao.Text = "Consultar";
			this.btnC_colecao.UseVisualStyleBackColor = true;
			this.btnC_colecao.Click += new System.EventHandler(this.btnC_colecao_Click);
			// 
			// btnC_eventos
			// 
			this.btnC_eventos.Location = new System.Drawing.Point(197, 126);
			this.btnC_eventos.Name = "btnC_eventos";
			this.btnC_eventos.Size = new System.Drawing.Size(75, 23);
			this.btnC_eventos.TabIndex = 17;
			this.btnC_eventos.Text = "Consultar";
			this.btnC_eventos.UseVisualStyleBackColor = true;
			this.btnC_eventos.Click += new System.EventHandler(this.btnC_eventos_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Moeda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Coleção";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Eventos";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suasMoedasToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// suasMoedasToolStripMenuItem
			// 
			this.suasMoedasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
			this.suasMoedasToolStripMenuItem.Name = "suasMoedasToolStripMenuItem";
			this.suasMoedasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.suasMoedasToolStripMenuItem.Text = "Gestão";
			// 
			// adicionarToolStripMenuItem
			// 
			this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
			this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.adicionarToolStripMenuItem.Text = "Colecionadores";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMoedaToolStripMenuItem,
            this.logOffToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// adicionarMoedaToolStripMenuItem
			// 
			this.adicionarMoedaToolStripMenuItem.Name = "adicionarMoedaToolStripMenuItem";
			this.adicionarMoedaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.adicionarMoedaToolStripMenuItem.Text = "Adicionar Moeda";
			this.adicionarMoedaToolStripMenuItem.Click += new System.EventHandler(this.adicionarMoedaToolStripMenuItem_Click);
			// 
			// logOffToolStripMenuItem
			// 
			this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
			this.logOffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.logOffToolStripMenuItem.Text = "Log off";
			// 
			// Form_Adm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 245);
			this.Controls.Add(this.cbC_moeda);
			this.Controls.Add(this.cbC_colecao);
			this.Controls.Add(this.cbC_eventos);
			this.Controls.Add(this.btnC_moedas);
			this.Controls.Add(this.btnC_colecao);
			this.Controls.Add(this.btnC_eventos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form_Adm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Adm";
			this.Load += new System.EventHandler(this.Form_Adm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbC_moeda;
        private System.Windows.Forms.ComboBox cbC_colecao;
        private System.Windows.Forms.ComboBox cbC_eventos;
        private System.Windows.Forms.Button btnC_moedas;
        private System.Windows.Forms.Button btnC_colecao;
        private System.Windows.Forms.Button btnC_eventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem suasMoedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMoedaToolStripMenuItem;
    }
}