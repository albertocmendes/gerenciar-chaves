namespace gerenciar_chaves
{
    partial class FrmChaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChaves));
            TXTchave = new TextBox();
            TXTconteudo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BTNvisualizar = new Button();
            BTNcadastrar = new Button();
            LVdados = new ListView();
            BTNremover = new Button();
            TXTdetalhes = new TextBox();
            label1 = new Label();
            BTNlimpar = new Button();
            SuspendLayout();
            // 
            // TXTchave
            // 
            TXTchave.CharacterCasing = CharacterCasing.Upper;
            TXTchave.Location = new Point(21, 27);
            TXTchave.MaxLength = 50;
            TXTchave.Name = "TXTchave";
            TXTchave.Size = new Size(385, 23);
            TXTchave.TabIndex = 0;
            TXTchave.KeyDown += TXTchave_KeyDown;
            // 
            // TXTconteudo
            // 
            TXTconteudo.Location = new Point(21, 71);
            TXTconteudo.MaxLength = 50;
            TXTconteudo.Name = "TXTconteudo";
            TXTconteudo.PasswordChar = '*';
            TXTconteudo.Size = new Size(385, 23);
            TXTconteudo.TabIndex = 1;
            TXTconteudo.KeyDown += TXTconteudo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Chave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 53);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Conteudo";
            // 
            // BTNvisualizar
            // 
            BTNvisualizar.Image = (Image)resources.GetObject("BTNvisualizar.Image");
            BTNvisualizar.Location = new Point(407, 72);
            BTNvisualizar.Name = "BTNvisualizar";
            BTNvisualizar.Size = new Size(28, 22);
            BTNvisualizar.TabIndex = 5;
            BTNvisualizar.UseVisualStyleBackColor = true;
            BTNvisualizar.Click += BTNvisualizar_Click;
            // 
            // BTNcadastrar
            // 
            BTNcadastrar.Location = new Point(21, 100);
            BTNcadastrar.Name = "BTNcadastrar";
            BTNcadastrar.Size = new Size(82, 33);
            BTNcadastrar.TabIndex = 6;
            BTNcadastrar.Text = "Cadastrar";
            BTNcadastrar.UseVisualStyleBackColor = true;
            BTNcadastrar.Click += BTNcadastrar_Click;
            // 
            // LVdados
            // 
            LVdados.Location = new Point(23, 139);
            LVdados.Name = "LVdados";
            LVdados.Size = new Size(486, 527);
            LVdados.TabIndex = 7;
            LVdados.UseCompatibleStateImageBehavior = false;
            LVdados.MouseClick += LVdados_MouseClick;
            LVdados.MouseDoubleClick += LVdados_MouseDoubleClick_1;
            // 
            // BTNremover
            // 
            BTNremover.Location = new Point(109, 100);
            BTNremover.Name = "BTNremover";
            BTNremover.Size = new Size(82, 33);
            BTNremover.TabIndex = 8;
            BTNremover.Text = "Remover";
            BTNremover.UseVisualStyleBackColor = true;
            BTNremover.Click += BTNremover_Click;
            // 
            // TXTdetalhes
            // 
            TXTdetalhes.Location = new Point(23, 687);
            TXTdetalhes.Name = "TXTdetalhes";
            TXTdetalhes.Size = new Size(486, 23);
            TXTdetalhes.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 669);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Visualização";
            // 
            // BTNlimpar
            // 
            BTNlimpar.Location = new Point(197, 100);
            BTNlimpar.Name = "BTNlimpar";
            BTNlimpar.Size = new Size(82, 33);
            BTNlimpar.TabIndex = 11;
            BTNlimpar.Text = "Limpar";
            BTNlimpar.UseVisualStyleBackColor = true;
            BTNlimpar.Click += BTNlimpar_Click;
            // 
            // FrmChaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 733);
            Controls.Add(BTNlimpar);
            Controls.Add(label1);
            Controls.Add(TXTdetalhes);
            Controls.Add(BTNremover);
            Controls.Add(LVdados);
            Controls.Add(BTNcadastrar);
            Controls.Add(BTNvisualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TXTconteudo);
            Controls.Add(TXTchave);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChaves";
            Text = "Chaves Cadastradas";
            Load += FrmChaves_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTchave;
        private TextBox TXTconteudo;
        private Label label2;
        private Label label3;
        private Button BTNvisualizar;
        private Button BTNcadastrar;
        private ListView LVdados;
        private Button BTNremover;
        private TextBox TXTdetalhes;
        private Label label1;
        private Button BTNlimpar;
    }
}
