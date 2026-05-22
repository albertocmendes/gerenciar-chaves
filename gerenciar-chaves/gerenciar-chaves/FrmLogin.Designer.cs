namespace gerenciar_chaves
{
    partial class FrmLogin
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
            groupBox1 = new GroupBox();
            BTN_cancelar = new Button();
            BTN_confirmar = new Button();
            label1 = new Label();
            TXT_login = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTN_cancelar);
            groupBox1.Controls.Add(BTN_confirmar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TXT_login);
            groupBox1.Location = new Point(185, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // BTN_cancelar
            // 
            BTN_cancelar.Location = new Point(107, 66);
            BTN_cancelar.Name = "BTN_cancelar";
            BTN_cancelar.Size = new Size(87, 28);
            BTN_cancelar.TabIndex = 7;
            BTN_cancelar.Text = "&Cancelar";
            BTN_cancelar.UseVisualStyleBackColor = true;
            BTN_cancelar.Click += BTN_cancelar_Click;
            // 
            // BTN_confirmar
            // 
            BTN_confirmar.Location = new Point(6, 66);
            BTN_confirmar.Name = "BTN_confirmar";
            BTN_confirmar.Size = new Size(95, 27);
            BTN_confirmar.TabIndex = 6;
            BTN_confirmar.Text = "&Confirmar";
            BTN_confirmar.UseVisualStyleBackColor = true;
            BTN_confirmar.Click += BTN_confirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // TXT_login
            // 
            TXT_login.Location = new Point(6, 37);
            TXT_login.MaxLength = 4;
            TXT_login.Name = "TXT_login";
            TXT_login.PasswordChar = '*';
            TXT_login.Size = new Size(188, 23);
            TXT_login.TabIndex = 4;
            TXT_login.KeyDown += TXT_login_KeyDown;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 460);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            Text = "Gerenciador de chaves";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BTN_cancelar;
        private Button BTN_confirmar;
        private Label label1;
        private TextBox TXT_login;
    }
}