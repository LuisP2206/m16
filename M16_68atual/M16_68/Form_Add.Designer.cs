namespace M16_68
{
    partial class Form_Add
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
			this.btn_back = new System.Windows.Forms.Button();
			this.cb_moedas = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(212, 128);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 5;
			this.btn_back.Text = "<------";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// cb_moedas
			// 
			this.cb_moedas.FormattingEnabled = true;
			this.cb_moedas.Location = new System.Drawing.Point(12, 58);
			this.cb_moedas.Name = "cb_moedas";
			this.cb_moedas.Size = new System.Drawing.Size(181, 21);
			this.cb_moedas.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Moeda";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(212, 99);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 8;
			this.btn_add.Text = "Adicionar";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 171);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_moedas);
			this.Controls.Add(this.btn_back);
			this.Name = "Form_Add";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_moedas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ImageList imageList1;
    }
}