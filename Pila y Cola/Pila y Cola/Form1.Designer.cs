namespace Pila_y_Cola
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbpila = new System.Windows.Forms.ListBox();
            this.lbcola = new System.Windows.Forms.ListBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.nquitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.label4lbturnofila = new System.Windows.Forms.Label();
            this.lbturnocola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbpila
            // 
            this.lbpila.FormattingEnabled = true;
            this.lbpila.Location = new System.Drawing.Point(30, 48);
            this.lbpila.Name = "lbpila";
            this.lbpila.Size = new System.Drawing.Size(131, 225);
            this.lbpila.TabIndex = 0;
            // 
            // lbcola
            // 
            this.lbcola.FormattingEnabled = true;
            this.lbcola.Location = new System.Drawing.Point(186, 48);
            this.lbcola.Name = "lbcola";
            this.lbcola.Size = new System.Drawing.Size(131, 225);
            this.lbcola.TabIndex = 1;
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(353, 48);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(154, 20);
            this.txtitem.TabIndex = 2;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(537, 41);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(65, 32);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // nquitar
            // 
            this.nquitar.Location = new System.Drawing.Point(114, 319);
            this.nquitar.Name = "nquitar";
            this.nquitar.Size = new System.Drawing.Size(65, 32);
            this.nquitar.TabIndex = 4;
            this.nquitar.Text = "Quitar";
            this.nquitar.UseVisualStyleBackColor = true;
            this.nquitar.Click += new System.EventHandler(this.nquitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cola";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(379, 111);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(56, 13);
            this.cantidad.TabIndex = 7;
            this.cantidad.Text = "Elementos";
            // 
            // label4lbturnofila
            // 
            this.label4lbturnofila.AutoSize = true;
            this.label4lbturnofila.Location = new System.Drawing.Point(75, 293);
            this.label4lbturnofila.Name = "label4lbturnofila";
            this.label4lbturnofila.Size = new System.Drawing.Size(38, 13);
            this.label4lbturnofila.TabIndex = 8;
            this.label4lbturnofila.Text = "Turno:";
            // 
            // lbturnocola
            // 
            this.lbturnocola.AutoSize = true;
            this.lbturnocola.Location = new System.Drawing.Point(229, 293);
            this.lbturnocola.Name = "lbturnocola";
            this.lbturnocola.Size = new System.Drawing.Size(38, 13);
            this.lbturnocola.TabIndex = 9;
            this.lbturnocola.Text = "Turno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.lbturnocola);
            this.Controls.Add(this.label4lbturnofila);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.lbcola);
            this.Controls.Add(this.lbpila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbpila;
        private System.Windows.Forms.ListBox lbcola;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button nquitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Label label4lbturnofila;
        private System.Windows.Forms.Label lbturnocola;
    }
}

