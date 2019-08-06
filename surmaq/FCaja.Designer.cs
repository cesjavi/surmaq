namespace surmaq
{
    partial class FCaja
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
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panAbajo = new System.Windows.Forms.Panel();
            this.panArriba = new System.Windows.Forms.Panel();
            this.panItems = new System.Windows.Forms.Panel();
            this.panBusqueda = new System.Windows.Forms.Panel();
            this.panMonto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SUBTOTAL = new System.Windows.Forms.Label();
            this.panPrincipal.SuspendLayout();
            this.panArriba.SuspendLayout();
            this.panMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.panAbajo);
            this.panPrincipal.Controls.Add(this.panArriba);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(888, 495);
            this.panPrincipal.TabIndex = 0;
            // 
            // panAbajo
            // 
            this.panAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panAbajo.Location = new System.Drawing.Point(0, 333);
            this.panAbajo.Name = "panAbajo";
            this.panAbajo.Size = new System.Drawing.Size(888, 162);
            this.panAbajo.TabIndex = 1;
            // 
            // panArriba
            // 
            this.panArriba.Controls.Add(this.panItems);
            this.panArriba.Controls.Add(this.panBusqueda);
            this.panArriba.Controls.Add(this.panMonto);
            this.panArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panArriba.Location = new System.Drawing.Point(0, 0);
            this.panArriba.Name = "panArriba";
            this.panArriba.Size = new System.Drawing.Size(888, 334);
            this.panArriba.TabIndex = 0;
            // 
            // panItems
            // 
            this.panItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panItems.Location = new System.Drawing.Point(0, 48);
            this.panItems.Name = "panItems";
            this.panItems.Size = new System.Drawing.Size(584, 205);
            this.panItems.TabIndex = 2;
            // 
            // panBusqueda
            // 
            this.panBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panBusqueda.Name = "panBusqueda";
            this.panBusqueda.Size = new System.Drawing.Size(584, 48);
            this.panBusqueda.TabIndex = 1;
            // 
            // panMonto
            // 
            this.panMonto.Controls.Add(this.label1);
            this.panMonto.Controls.Add(this.label2);
            this.panMonto.Controls.Add(this.SUBTOTAL);
            this.panMonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMonto.Location = new System.Drawing.Point(584, 0);
            this.panMonto.Name = "panMonto";
            this.panMonto.Size = new System.Drawing.Size(304, 334);
            this.panMonto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCUENTO/RECARGO";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSize = true;
            this.SUBTOTAL.Location = new System.Drawing.Point(6, 19);
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Size = new System.Drawing.Size(64, 13);
            this.SUBTOTAL.TabIndex = 0;
            this.SUBTOTAL.Text = "SUBTOTAL";
            // 
            // FCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 495);
            this.Controls.Add(this.panPrincipal);
            this.Name = "FCaja";
            this.Text = "Caja";
            this.panPrincipal.ResumeLayout(false);
            this.panArriba.ResumeLayout(false);
            this.panMonto.ResumeLayout(false);
            this.panMonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Panel panArriba;
        private System.Windows.Forms.Panel panAbajo;
        private System.Windows.Forms.Panel panBusqueda;
        private System.Windows.Forms.Panel panMonto;
        private System.Windows.Forms.Panel panItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SUBTOTAL;
    }
}