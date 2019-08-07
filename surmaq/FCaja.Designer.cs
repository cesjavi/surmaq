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
            this.panMontos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecargoDescuento = new System.Windows.Forms.Label();
            this.SUBTOTAL = new System.Windows.Forms.Label();
            this.mtbSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbDR = new System.Windows.Forms.MaskedTextBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panPrincipal.SuspendLayout();
            this.panArriba.SuspendLayout();
            this.panItems.SuspendLayout();
            this.panMonto.SuspendLayout();
            this.panMontos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panItems.Controls.Add(this.dataGridView1);
            this.panItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panItems.Location = new System.Drawing.Point(0, 48);
            this.panItems.Name = "panItems";
            this.panItems.Size = new System.Drawing.Size(474, 205);
            this.panItems.TabIndex = 2;
            // 
            // panBusqueda
            // 
            this.panBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panBusqueda.Name = "panBusqueda";
            this.panBusqueda.Size = new System.Drawing.Size(474, 48);
            this.panBusqueda.TabIndex = 1;
            // 
            // panMonto
            // 
            this.panMonto.Controls.Add(this.panMontos);
            this.panMonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMonto.Location = new System.Drawing.Point(474, 0);
            this.panMonto.Name = "panMonto";
            this.panMonto.Size = new System.Drawing.Size(414, 334);
            this.panMonto.TabIndex = 0;
            // 
            // panMontos
            // 
            this.panMontos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panMontos.Controls.Add(this.mtbTotal);
            this.panMontos.Controls.Add(this.mtbDR);
            this.panMontos.Controls.Add(this.mtbSubtotal);
            this.panMontos.Controls.Add(this.label1);
            this.panMontos.Controls.Add(this.lblRecargoDescuento);
            this.panMontos.Controls.Add(this.SUBTOTAL);
            this.panMontos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMontos.Location = new System.Drawing.Point(0, 0);
            this.panMontos.Name = "panMontos";
            this.panMontos.Size = new System.Drawing.Size(414, 170);
            this.panMontos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL ............................";
            // 
            // lblRecargoDescuento
            // 
            this.lblRecargoDescuento.AutoSize = true;
            this.lblRecargoDescuento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecargoDescuento.Location = new System.Drawing.Point(6, 60);
            this.lblRecargoDescuento.Name = "lblRecargoDescuento";
            this.lblRecargoDescuento.Size = new System.Drawing.Size(201, 18);
            this.lblRecargoDescuento.TabIndex = 4;
            this.lblRecargoDescuento.Text = "D/R..........................";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSize = true;
            this.SUBTOTAL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTOTAL.Location = new System.Drawing.Point(6, 22);
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Size = new System.Drawing.Size(212, 18);
            this.SUBTOTAL.TabIndex = 3;
            this.SUBTOTAL.Text = "SUBTOTAL..................";
            // 
            // mtbSubtotal
            // 
            this.mtbSubtotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSubtotal.Location = new System.Drawing.Point(148, 7);
            this.mtbSubtotal.Mask = "$ 99999.00";
            this.mtbSubtotal.Name = "mtbSubtotal";
            this.mtbSubtotal.PromptChar = ' ';
            this.mtbSubtotal.Size = new System.Drawing.Size(153, 31);
            this.mtbSubtotal.TabIndex = 6;
            this.mtbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbDR
            // 
            this.mtbDR.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.mtbDR.Location = new System.Drawing.Point(148, 46);
            this.mtbDR.Mask = "$ 99999.00";
            this.mtbDR.Name = "mtbDR";
            this.mtbDR.PromptChar = '0';
            this.mtbDR.Size = new System.Drawing.Size(153, 31);
            this.mtbDR.TabIndex = 7;
            this.mtbDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbTotal
            // 
            this.mtbTotal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTotal.Location = new System.Drawing.Point(81, 103);
            this.mtbTotal.Mask = "$ 9999999.00";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.PromptChar = '0';
            this.mtbTotal.Size = new System.Drawing.Size(220, 40);
            this.mtbTotal.TabIndex = 8;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Unitario,
            this.Importe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(474, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "N°";
            this.ID.MinimumWidth = 3;
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 44;
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 65;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 88;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Unitario
            // 
            this.Unitario.HeaderText = "Unitario";
            this.Unitario.Name = "Unitario";
            this.Unitario.Width = 68;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 67;
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
            this.panItems.ResumeLayout(false);
            this.panMonto.ResumeLayout(false);
            this.panMontos.ResumeLayout(false);
            this.panMontos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Panel panArriba;
        private System.Windows.Forms.Panel panAbajo;
        private System.Windows.Forms.Panel panBusqueda;
        private System.Windows.Forms.Panel panMonto;
        private System.Windows.Forms.Panel panItems;
        private System.Windows.Forms.Panel panMontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecargoDescuento;
        private System.Windows.Forms.Label SUBTOTAL;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.MaskedTextBox mtbDR;
        private System.Windows.Forms.MaskedTextBox mtbSubtotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}