namespace Presentacion
{
    partial class CambioDivisa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbRecibes = new System.Windows.Forms.TextBox();
            this.tbEnvias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDivisaDestino = new System.Windows.Forms.ComboBox();
            this.bsDivisaDestino = new System.Windows.Forms.BindingSource(this.components);
            this.cbDivisaOrigen = new System.Windows.Forms.ComboBox();
            this.bsDivisaOrigen = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCompra = new System.Windows.Forms.RadioButton();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDivisaDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDivisaOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.tbRecibes);
            this.groupBox1.Controls.Add(this.tbEnvias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDivisaDestino);
            this.groupBox1.Controls.Add(this.cbDivisaOrigen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(166, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(49, 36);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "→";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbRecibes
            // 
            this.tbRecibes.Enabled = false;
            this.tbRecibes.Location = new System.Drawing.Point(221, 111);
            this.tbRecibes.Name = "tbRecibes";
            this.tbRecibes.Size = new System.Drawing.Size(151, 20);
            this.tbRecibes.TabIndex = 7;
            // 
            // tbEnvias
            // 
            this.tbEnvias.Location = new System.Drawing.Point(9, 111);
            this.tbEnvias.Name = "tbEnvias";
            this.tbEnvias.Size = new System.Drawing.Size(151, 20);
            this.tbEnvias.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "RECIBES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ENVIAS";
            // 
            // cbDivisaDestino
            // 
            this.cbDivisaDestino.DataSource = this.bsDivisaDestino;
            this.cbDivisaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivisaDestino.FormattingEnabled = true;
            this.cbDivisaDestino.Location = new System.Drawing.Point(221, 47);
            this.cbDivisaDestino.Name = "cbDivisaDestino";
            this.cbDivisaDestino.Size = new System.Drawing.Size(151, 21);
            this.cbDivisaDestino.TabIndex = 3;
            // 
            // bsDivisaDestino
            // 
            this.bsDivisaDestino.DataSource = typeof(Presentacion.Dominio.Divisa);
            // 
            // cbDivisaOrigen
            // 
            this.cbDivisaOrigen.DataSource = this.bsDivisaOrigen;
            this.cbDivisaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivisaOrigen.FormattingEnabled = true;
            this.cbDivisaOrigen.Location = new System.Drawing.Point(9, 47);
            this.cbDivisaOrigen.Name = "cbDivisaOrigen";
            this.cbDivisaOrigen.Size = new System.Drawing.Size(151, 21);
            this.cbDivisaOrigen.TabIndex = 2;
            // 
            // bsDivisaOrigen
            // 
            this.bsDivisaOrigen.DataSource = typeof(Presentacion.Dominio.Divisa);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DIVISA DESTINO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIVISA ORIGEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPERACIÓN";
            // 
            // rbCompra
            // 
            this.rbCompra.AutoSize = true;
            this.rbCompra.Checked = true;
            this.rbCompra.Location = new System.Drawing.Point(21, 31);
            this.rbCompra.Name = "rbCompra";
            this.rbCompra.Size = new System.Drawing.Size(71, 17);
            this.rbCompra.TabIndex = 2;
            this.rbCompra.TabStop = true;
            this.rbCompra.Text = "COMPRA";
            this.rbCompra.UseVisualStyleBackColor = true;
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Location = new System.Drawing.Point(111, 31);
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Size = new System.Drawing.Size(61, 17);
            this.rbVenta.TabIndex = 3;
            this.rbVenta.Text = "VENTA";
            this.rbVenta.UseVisualStyleBackColor = true;
            // 
            // CambioDivisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 225);
            this.Controls.Add(this.rbVenta);
            this.Controls.Add(this.rbCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CambioDivisa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CambioDivisa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDivisaDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDivisaOrigen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDivisaDestino;
        private System.Windows.Forms.ComboBox cbDivisaOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCompra;
        private System.Windows.Forms.RadioButton rbVenta;
        private System.Windows.Forms.TextBox tbRecibes;
        private System.Windows.Forms.TextBox tbEnvias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsDivisaOrigen;
        private System.Windows.Forms.BindingSource bsDivisaDestino;
        private System.Windows.Forms.Button btnCalcular;
    }
}

