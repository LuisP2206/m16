namespace M16_68
{
    partial class Form_MinhaC
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
			this.components = new System.ComponentModel.Container();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lv_colecao = new System.Windows.Forms.ListView();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.suasMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_back = new System.Windows.Forms.Button();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lv_colecao
			// 
			this.lv_colecao.HideSelection = false;
			this.lv_colecao.Location = new System.Drawing.Point(12, 39);
			this.lv_colecao.Name = "lv_colecao";
			this.lv_colecao.Size = new System.Drawing.Size(705, 386);
			this.lv_colecao.TabIndex = 0;
			this.lv_colecao.UseCompatibleStateImageBehavior = false;
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suasMoedasToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(898, 24);
			this.menuStrip2.TabIndex = 3;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// suasMoedasToolStripMenuItem
			// 
			this.suasMoedasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
			this.suasMoedasToolStripMenuItem.Name = "suasMoedasToolStripMenuItem";
			this.suasMoedasToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.suasMoedasToolStripMenuItem.Text = "Minha coleção";
			// 
			// adicionarToolStripMenuItem
			// 
			this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
			this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.adicionarToolStripMenuItem.Text = "Adicionar";
			this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(810, 402);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 4;
			this.btn_back.Text = "<------";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// Form_MinhaC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 437);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.lv_colecao);
			this.Name = "Form_MinhaC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minha coleção";
			this.Load += new System.EventHandler(this.Form_MinhaC_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lv_colecao;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem suasMoedasToolStripMenuItem;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
    }
}