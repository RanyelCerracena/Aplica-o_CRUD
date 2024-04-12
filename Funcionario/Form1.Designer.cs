namespace Funcionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            label = new Label();
            lblId = new Label();
            button1 = new Button();
            btnAtualizarDados = new Button();
            btnDeletarDados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 2;
            label3.Text = "CPF :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 280);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 3;
            label4.Text = "Endereço :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(141, 177);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(602, 30);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNome.Location = new Point(141, 131);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(602, 30);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.Location = new Point(141, 232);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(602, 30);
            txtCpf.TabIndex = 3;
            txtCpf.KeyPress += txtCpf_KeyPress;
            txtCpf.KeyUp += txtCpf_KeyUp;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEndereco.Location = new Point(141, 284);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(602, 30);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(12, 362);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(116, 63);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(141, 362);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(122, 63);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(12, 55);
            label.Name = "label";
            label.Size = new Size(158, 28);
            label.TabIndex = 7;
            label.Text = "Funcionário Id :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(176, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 28);
            lblId.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(635, 52);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 9;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAtualizarDados
            // 
            btnAtualizarDados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizarDados.Location = new Point(279, 362);
            btnAtualizarDados.Name = "btnAtualizarDados";
            btnAtualizarDados.Size = new Size(168, 63);
            btnAtualizarDados.TabIndex = 10;
            btnAtualizarDados.Text = "Atualizar dados";
            btnAtualizarDados.UseVisualStyleBackColor = true;
            btnAtualizarDados.Click += btnAtualizarDados_Click;
            // 
            // btnDeletarDados
            // 
            btnDeletarDados.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletarDados.Location = new Point(464, 362);
            btnDeletarDados.Name = "btnDeletarDados";
            btnDeletarDados.Size = new Size(279, 63);
            btnDeletarDados.TabIndex = 11;
            btnDeletarDados.Text = "Deletar dados do banco";
            btnDeletarDados.UseVisualStyleBackColor = true;
            btnDeletarDados.Click += btnDeletarDados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 472);
            Controls.Add(btnDeletarDados);
            Controls.Add(btnAtualizarDados);
            Controls.Add(button1);
            Controls.Add(lblId);
            Controls.Add(label);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de funcionários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label label;
        private Label lblId;
        private Button button1;
        private Button btnAtualizarDados;
        private Button btnDeletarDados;
    }
}
