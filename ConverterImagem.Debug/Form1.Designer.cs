
namespace ConverterImagem.Debug
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(12, 25);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(505, 20);
            this.txtCaminhoArquivo.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(12, 51);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(143, 23);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter Imagem";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Location = new System.Drawing.Point(12, 9);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(465, 13);
            this.lblDica.TabIndex = 2;
            this.lblDica.Text = "Cole abaixo o caminho da imagem para testar a conversão, depois clique em \"conver" +
    "ter imagem\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Obs: a imagem é salva no mesmo local sobrescrevendo a imagem original.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 97);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label label1;
    }
}

