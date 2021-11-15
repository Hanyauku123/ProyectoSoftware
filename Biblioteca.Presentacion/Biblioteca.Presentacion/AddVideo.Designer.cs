
namespace Biblioteca.Presentacion
{
    partial class AddVideo
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.tbduracion = new System.Windows.Forms.TextBox();
            this.tbidiomas = new System.Windows.Forms.TextBox();
            this.tbsubtitulos = new System.Windows.Forms.TextBox();
            this.tbdirector = new System.Windows.Forms.TextBox();
            this.tbubicacion = new System.Windows.Forms.TextBox();
            this.tbsinopsis = new System.Windows.Forms.TextBox();
            this.tbanio = new System.Windows.Forms.TextBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbproductora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button2.Location = new System.Drawing.Point(161, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 85);
            this.button2.TabIndex = 62;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(161, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 85);
            this.button1.TabIndex = 61;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(660, 249);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(314, 28);
            this.cbtipo.TabIndex = 60;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbmateria_SelectedIndexChanged);
            // 
            // tbduracion
            // 
            this.tbduracion.Location = new System.Drawing.Point(191, 149);
            this.tbduracion.Name = "tbduracion";
            this.tbduracion.Size = new System.Drawing.Size(284, 26);
            this.tbduracion.TabIndex = 57;
            this.tbduracion.TextChanged += new System.EventHandler(this.tbisbn_TextChanged);
            // 
            // tbidiomas
            // 
            this.tbidiomas.Location = new System.Drawing.Point(191, 201);
            this.tbidiomas.Name = "tbidiomas";
            this.tbidiomas.Size = new System.Drawing.Size(284, 26);
            this.tbidiomas.TabIndex = 56;
            this.tbidiomas.TextChanged += new System.EventHandler(this.tbnpaginas_TextChanged);
            // 
            // tbsubtitulos
            // 
            this.tbsubtitulos.Location = new System.Drawing.Point(200, 248);
            this.tbsubtitulos.Name = "tbsubtitulos";
            this.tbsubtitulos.Size = new System.Drawing.Size(275, 26);
            this.tbsubtitulos.TabIndex = 55;
            this.tbsubtitulos.TextChanged += new System.EventHandler(this.tbidioma_TextChanged);
            // 
            // tbdirector
            // 
            this.tbdirector.Location = new System.Drawing.Point(660, 97);
            this.tbdirector.Name = "tbdirector";
            this.tbdirector.Size = new System.Drawing.Size(314, 26);
            this.tbdirector.TabIndex = 51;
            this.tbdirector.TextChanged += new System.EventHandler(this.tbejemplar_TextChanged);
            // 
            // tbubicacion
            // 
            this.tbubicacion.Location = new System.Drawing.Point(676, 145);
            this.tbubicacion.Name = "tbubicacion";
            this.tbubicacion.Size = new System.Drawing.Size(298, 26);
            this.tbubicacion.TabIndex = 50;
            this.tbubicacion.TextChanged += new System.EventHandler(this.tbubicacion_TextChanged);
            // 
            // tbsinopsis
            // 
            this.tbsinopsis.Location = new System.Drawing.Point(691, 339);
            this.tbsinopsis.Multiline = true;
            this.tbsinopsis.Name = "tbsinopsis";
            this.tbsinopsis.Size = new System.Drawing.Size(319, 230);
            this.tbsinopsis.TabIndex = 49;
            this.tbsinopsis.TextChanged += new System.EventHandler(this.tbdescripcion_TextChanged);
            // 
            // tbanio
            // 
            this.tbanio.Location = new System.Drawing.Point(191, 293);
            this.tbanio.Name = "tbanio";
            this.tbanio.Size = new System.Drawing.Size(284, 26);
            this.tbanio.TabIndex = 48;
            this.tbanio.TextChanged += new System.EventHandler(this.tbautor_TextChanged);
            // 
            // tbtitulo
            // 
            this.tbtitulo.Location = new System.Drawing.Point(161, 96);
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.Size = new System.Drawing.Size(314, 26);
            this.tbtitulo.TabIndex = 47;
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbtitulo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(81, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 29);
            this.label14.TabIndex = 46;
            this.label14.Text = "Duración:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(81, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 45;
            this.label13.Text = "Idiomas:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(81, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 29);
            this.label12.TabIndex = 44;
            this.label12.Text = "Subtitulos:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(544, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "Sinopsis:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(544, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tipo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(544, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Productora:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(81, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Año:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(544, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Director:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(544, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ubicacion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(81, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Titulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbproductora
            // 
            this.tbproductora.Location = new System.Drawing.Point(687, 202);
            this.tbproductora.Name = "tbproductora";
            this.tbproductora.Size = new System.Drawing.Size(287, 26);
            this.tbproductora.TabIndex = 63;
            this.tbproductora.TextChanged += new System.EventHandler(this.tbproductora_TextChanged);
            // 
            // AddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 673);
            this.Controls.Add(this.tbproductora);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.tbduracion);
            this.Controls.Add(this.tbidiomas);
            this.Controls.Add(this.tbsubtitulos);
            this.Controls.Add(this.tbdirector);
            this.Controls.Add(this.tbubicacion);
            this.Controls.Add(this.tbsinopsis);
            this.Controls.Add(this.tbanio);
            this.Controls.Add(this.tbtitulo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddVideo";
            this.Text = "Agregar Video";
            this.Load += new System.EventHandler(this.AddVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox tbduracion;
        private System.Windows.Forms.TextBox tbidiomas;
        private System.Windows.Forms.TextBox tbsubtitulos;
        private System.Windows.Forms.TextBox tbdirector;
        private System.Windows.Forms.TextBox tbubicacion;
        private System.Windows.Forms.TextBox tbsinopsis;
        private System.Windows.Forms.TextBox tbanio;
        private System.Windows.Forms.TextBox tbtitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbproductora;
    }
}