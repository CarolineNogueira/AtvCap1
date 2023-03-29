
namespace RestoDeUmaDivisão
{
    partial class frmRestoDeDivisao
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
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtRestoDaDivisao = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnRealizarDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(200, 23);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(55, 17);
            this.lblDivisor.TabIndex = 0;
            this.lblDivisor.Text = "Divisor:";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(206, 70);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(49, 17);
            this.lblResto.TabIndex = 1;
            this.lblResto.Text = "Resto:";
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(13, 23);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(75, 17);
            this.lblDividendo.TabIndex = 2;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(94, 18);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 22);
            this.txtDividendo.TabIndex = 3;
            // 
            // txtRestoDaDivisao
            // 
            this.txtRestoDaDivisao.Location = new System.Drawing.Point(261, 67);
            this.txtRestoDaDivisao.Name = "txtRestoDaDivisao";
            this.txtRestoDaDivisao.Size = new System.Drawing.Size(100, 22);
            this.txtRestoDaDivisao.TabIndex = 4;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(258, 20);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 22);
            this.txtDivisor.TabIndex = 5;
            // 
            // btnRealizarDiv
            // 
            this.btnRealizarDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRealizarDiv.Location = new System.Drawing.Point(30, 60);
            this.btnRealizarDiv.Name = "btnRealizarDiv";
            this.btnRealizarDiv.Size = new System.Drawing.Size(148, 36);
            this.btnRealizarDiv.TabIndex = 6;
            this.btnRealizarDiv.Text = "Realizar Divisão";
            this.btnRealizarDiv.UseVisualStyleBackColor = true;
            this.btnRealizarDiv.Click += new System.EventHandler(this.btnRealizarDiv_Click);
            // 
            // frmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 111);
            this.Controls.Add(this.btnRealizarDiv);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtRestoDaDivisao);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblDivisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRestoDeDivisao";
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtRestoDaDivisao;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnRealizarDiv;
    }
}

