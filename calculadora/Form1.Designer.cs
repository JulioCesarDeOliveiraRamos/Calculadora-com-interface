namespace calculadora
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
            btnzero = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btnvirgula = new Button();
            btnigual = new Button();
            btnadicao = new Button();
            btnsubtracao = new Button();
            btnmultiplicacao = new Button();
            btndivisao = new Button();
            btnlimpar = new Button();
            txtresultado = new TextBox();
            lbloperacao = new Label();
            lblvalorprimario = new Label();
            SuspendLayout();
            // 
            // btnzero
            // 
            btnzero.Location = new Point(71, 308);
            btnzero.Margin = new Padding(4, 3, 4, 3);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(50, 50);
            btnzero.TabIndex = 0;
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = true;
            btnzero.Click += btnzero_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(71, 140);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(13, 140);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(71, 196);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(129, 196);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(13, 196);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(13, 252);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(129, 252);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(71, 252);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(129, 140);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(13, 308);
            btnvirgula.Margin = new Padding(4, 3, 4, 3);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(50, 50);
            btnvirgula.TabIndex = 10;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            btnigual.Location = new Point(129, 308);
            btnigual.Margin = new Padding(4, 3, 4, 3);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(50, 50);
            btnigual.TabIndex = 11;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnadicao
            // 
            btnadicao.Location = new Point(200, 308);
            btnadicao.Margin = new Padding(4, 3, 4, 3);
            btnadicao.Name = "btnadicao";
            btnadicao.Size = new Size(50, 50);
            btnadicao.TabIndex = 12;
            btnadicao.Text = "+";
            btnadicao.UseVisualStyleBackColor = true;
            btnadicao.Click += btnadicao_Click;
            // 
            // btnsubtracao
            // 
            btnsubtracao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsubtracao.Location = new Point(200, 252);
            btnsubtracao.Margin = new Padding(4, 3, 4, 3);
            btnsubtracao.Name = "btnsubtracao";
            btnsubtracao.Size = new Size(50, 50);
            btnsubtracao.TabIndex = 13;
            btnsubtracao.Text = "-";
            btnsubtracao.UseVisualStyleBackColor = true;
            btnsubtracao.Click += btnsubtracao_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.Location = new Point(200, 196);
            btnmultiplicacao.Margin = new Padding(4, 3, 4, 3);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(50, 50);
            btnmultiplicacao.TabIndex = 14;
            btnmultiplicacao.Text = "X";
            btnmultiplicacao.UseVisualStyleBackColor = true;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // btndivisao
            // 
            btndivisao.Location = new Point(200, 140);
            btndivisao.Margin = new Padding(4, 3, 4, 3);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(50, 50);
            btndivisao.TabIndex = 15;
            btndivisao.Text = "/";
            btndivisao.UseVisualStyleBackColor = true;
            btndivisao.Click += btndivisao_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(200, 84);
            btnlimpar.Margin = new Padding(4, 3, 4, 3);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(50, 50);
            btnlimpar.TabIndex = 16;
            btnlimpar.Text = "C";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(13, 44);
            txtresultado.Margin = new Padding(4, 3, 4, 3);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(228, 25);
            txtresultado.TabIndex = 18;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lbloperacao
            // 
            lbloperacao.BackColor = SystemColors.Control;
            lbloperacao.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbloperacao.Location = new Point(158, 47);
            lbloperacao.Name = "lbloperacao";
            lbloperacao.Size = new Size(30, 19);
            lbloperacao.TabIndex = 19;
            // 
            // lblvalorprimario
            // 
            lblvalorprimario.AutoEllipsis = true;
            lblvalorprimario.AutoSize = true;
            lblvalorprimario.BackColor = Color.Transparent;
            lblvalorprimario.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblvalorprimario.ForeColor = Color.DimGray;
            lblvalorprimario.Location = new Point(98, 53);
            lblvalorprimario.Name = "lblvalorprimario";
            lblvalorprimario.Size = new Size(0, 13);
            lblvalorprimario.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(280, 386);
            Controls.Add(lblvalorprimario);
            Controls.Add(lbloperacao);
            Controls.Add(btnlimpar);
            Controls.Add(btndivisao);
            Controls.Add(btnmultiplicacao);
            Controls.Add(btnsubtracao);
            Controls.Add(btnadicao);
            Controls.Add(btnigual);
            Controls.Add(btnvirgula);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btnzero);
            Controls.Add(txtresultado);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnzero;
        private Button btn8;
        private Button btn7;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn9;
        private Button btnvirgula;
        private Button btnigual;
        private Button btnadicao;
        private Button btnsubtracao;
        private Button btnmultiplicacao;
        private Button btndivisao;
        private Button btnlimpar;
        private TextBox txtresultado;
        private Label lbloperacao;
        private Label lblvalorprimario;
    }
}
