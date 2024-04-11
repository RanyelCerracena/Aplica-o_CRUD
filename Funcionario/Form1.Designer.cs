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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
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
            btnCadastrar.Location = new Point(261, 362);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(221, 75);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 472);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
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
    }
}
