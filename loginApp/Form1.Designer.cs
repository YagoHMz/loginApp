namespace loginApp
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
            senhaInserir = new MaskedTextBox();
            loginInserir = new TextBox();
            verSenha = new CheckBox();
            validarButton = new Button();
            resultadoText = new Label();
            bemvindoText = new Label();
            loginLabel = new Label();
            senhaLabel = new Label();
            SuspendLayout();
            // 
            // senhaInserir
            // 
            senhaInserir.Location = new Point(115, 85);
            senhaInserir.Name = "senhaInserir";
            senhaInserir.Size = new Size(100, 23);
            senhaInserir.TabIndex = 0;
            senhaInserir.UseSystemPasswordChar = true;
            // 
            // loginInserir
            // 
            loginInserir.Location = new Point(115, 56);
            loginInserir.Name = "loginInserir";
            loginInserir.Size = new Size(100, 23);
            loginInserir.TabIndex = 1;
            // 
            // verSenha
            // 
            verSenha.AutoSize = true;
            verSenha.Location = new Point(115, 114);
            verSenha.Name = "verSenha";
            verSenha.Size = new Size(89, 19);
            verSenha.TabIndex = 2;
            verSenha.Text = "Exibir senha";
            verSenha.UseVisualStyleBackColor = true;
            verSenha.CheckedChanged += verSenha_CheckedChanged;
            // 
            // validarButton
            // 
            validarButton.Location = new Point(115, 139);
            validarButton.Name = "validarButton";
            validarButton.Size = new Size(100, 23);
            validarButton.TabIndex = 3;
            validarButton.Text = "Validar";
            validarButton.UseVisualStyleBackColor = true;
            validarButton.Click += validarButton_Click;
            // 
            // resultadoText
            // 
            resultadoText.AutoSize = true;
            resultadoText.Location = new Point(106, 176);
            resultadoText.Name = "resultadoText";
            resultadoText.Size = new Size(0, 15);
            resultadoText.TabIndex = 4;
            resultadoText.Visible = false;
            // 
            // bemvindoText
            // 
            bemvindoText.AutoSize = true;
            bemvindoText.Location = new Point(66, 21);
            bemvindoText.Name = "bemvindoText";
            bemvindoText.Size = new Size(218, 15);
            bemvindoText.TabIndex = 5;
            bemvindoText.Text = "Bem-vindo ao sistema de login de teste!";
            bemvindoText.Visible = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(66, 59);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(40, 15);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new Point(67, 88);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(42, 15);
            senhaLabel.TabIndex = 7;
            senhaLabel.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(senhaLabel);
            Controls.Add(loginLabel);
            Controls.Add(bemvindoText);
            Controls.Add(resultadoText);
            Controls.Add(validarButton);
            Controls.Add(verSenha);
            Controls.Add(loginInserir);
            Controls.Add(senhaInserir);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox senhaInserir;
        private TextBox loginInserir;
        private CheckBox verSenha;
        private Button validarButton;
        private Label resultadoText;
        private Label bemvindoText;
        private Label loginLabel;
        private Label senhaLabel;
    }
}
