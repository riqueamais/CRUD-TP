namespace Crud
{
    partial class frmDetalhe
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
            components = new System.ComponentModel.Container();
            bsDetalhe = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bsDetalhe, "Nome", true));
            textBox1.Location = new Point(23, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 66);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 126);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereco";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bsDetalhe, "Endereco", true));
            textBox2.Location = new Point(23, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 190);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bsDetalhe, "Telefone", true));
            textBox3.Location = new Point(23, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(275, 250);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 30);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 9);
            label4.Name = "label4";
            label4.Size = new Size(283, 22);
            label4.TabIndex = 8;
            label4.Text = "Adicione ou Edite um Usuário";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(352, 303);
            Controls.Add(label4);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Cursor = Cursors.PanNW;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetalhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhe";
            Load += frmDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsDetalhe;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnCancelar;
        private Button btnOk;
        private Label label4;
    }
}