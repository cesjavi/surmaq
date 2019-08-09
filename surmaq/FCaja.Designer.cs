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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panBusqueda = new System.Windows.Forms.Panel();
            this.panMonto = new System.Windows.Forms.Panel();
            this.panMontos = new System.Windows.Forms.Panel();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbDR = new System.Windows.Forms.MaskedTextBox();
            this.mtbSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecargoDescuento = new System.Windows.Forms.Label();
            this.SUBTOTAL = new System.Windows.Forms.Label();
            this.mtbCodigoProducto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCantidadProducto = new System.Windows.Forms.MaskedTextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnMostrarPrecio = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnRecargos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panPrincipal.SuspendLayout();
            this.panAbajo.SuspendLayout();
            this.panArriba.SuspendLayout();
            this.panItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panBusqueda.SuspendLayout();
            this.panMonto.SuspendLayout();
            this.panMontos.SuspendLayout();
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
            this.panAbajo.Controls.Add(this.label4);
            this.panAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panAbajo.Location = new System.Drawing.Point(0, 302);
            this.panAbajo.Name = "panAbajo";
            this.panAbajo.Size = new System.Drawing.Size(888, 193);
            this.panAbajo.TabIndex = 1;
            // 
            // panArriba
            // 
            this.panArriba.Controls.Add(this.btnRecargos);
            this.panArriba.Controls.Add(this.btnDescuentos);
            this.panArriba.Controls.Add(this.btnEliminar);
            this.panArriba.Controls.Add(this.panItems);
            this.panArriba.Controls.Add(this.panBusqueda);
            this.panArriba.Controls.Add(this.panMonto);
            this.panArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panArriba.Location = new System.Drawing.Point(0, 0);
            this.panArriba.Name = "panArriba";
            this.panArriba.Size = new System.Drawing.Size(888, 304);
            this.panArriba.TabIndex = 0;
            // 
            // panItems
            // 
            this.panItems.Controls.Add(this.dgvCompras);
            this.panItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panItems.Location = new System.Drawing.Point(0, 48);
            this.panItems.Name = "panItems";
            this.panItems.Size = new System.Drawing.Size(526, 205);
            this.panItems.TabIndex = 2;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Unitario,
            this.Importe});
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.Enabled = false;
            this.dgvCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.ShowCellErrors = false;
            this.dgvCompras.ShowCellToolTips = false;
            this.dgvCompras.ShowEditingIcon = false;
            this.dgvCompras.ShowRowErrors = false;
            this.dgvCompras.Size = new System.Drawing.Size(526, 205);
            this.dgvCompras.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "N°";
            this.ID.MinimumWidth = 3;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 44;
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            this.Unitario.ReadOnly = true;
            this.Unitario.Width = 68;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 67;
            // 
            // panBusqueda
            // 
            this.panBusqueda.Controls.Add(this.mtbCantidadProducto);
            this.panBusqueda.Controls.Add(this.label3);
            this.panBusqueda.Controls.Add(this.label2);
            this.panBusqueda.Controls.Add(this.mtbCodigoProducto);
            this.panBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panBusqueda.Name = "panBusqueda";
            this.panBusqueda.Size = new System.Drawing.Size(526, 48);
            this.panBusqueda.TabIndex = 1;
            // 
            // panMonto
            // 
            this.panMonto.Controls.Add(this.btnMostrarPrecio);
            this.panMonto.Controls.Add(this.btnNuevaVenta);
            this.panMonto.Controls.Add(this.btnCobrar);
            this.panMonto.Controls.Add(this.panMontos);
            this.panMonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMonto.Location = new System.Drawing.Point(526, 0);
            this.panMonto.Name = "panMonto";
            this.panMonto.Size = new System.Drawing.Size(362, 304);
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
            this.panMontos.Size = new System.Drawing.Size(362, 170);
            this.panMontos.TabIndex = 4;
            // 
            // mtbTotal
            // 
            this.mtbTotal.Enabled = false;
            this.mtbTotal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTotal.Location = new System.Drawing.Point(135, 104);
            this.mtbTotal.Mask = "$ 9999999.00";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.PromptChar = '0';
            this.mtbTotal.Size = new System.Drawing.Size(220, 40);
            this.mtbTotal.TabIndex = 8;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbDR
            // 
            this.mtbDR.Enabled = false;
            this.mtbDR.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.mtbDR.Location = new System.Drawing.Point(202, 47);
            this.mtbDR.Mask = "$ 99999.00";
            this.mtbDR.Name = "mtbDR";
            this.mtbDR.PromptChar = '0';
            this.mtbDR.Size = new System.Drawing.Size(153, 31);
            this.mtbDR.TabIndex = 7;
            this.mtbDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbSubtotal
            // 
            this.mtbSubtotal.Enabled = false;
            this.mtbSubtotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSubtotal.Location = new System.Drawing.Point(202, 9);
            this.mtbSubtotal.Mask = "$ 99999.00";
            this.mtbSubtotal.Name = "mtbSubtotal";
            this.mtbSubtotal.PromptChar = ' ';
            this.mtbSubtotal.Size = new System.Drawing.Size(153, 31);
            this.mtbSubtotal.TabIndex = 6;
            this.mtbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL ............................";
            // 
            // lblRecargoDescuento
            // 
            this.lblRecargoDescuento.AutoSize = true;
            this.lblRecargoDescuento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecargoDescuento.Location = new System.Drawing.Point(10, 60);
            this.lblRecargoDescuento.Name = "lblRecargoDescuento";
            this.lblRecargoDescuento.Size = new System.Drawing.Size(201, 18);
            this.lblRecargoDescuento.TabIndex = 4;
            this.lblRecargoDescuento.Text = "D/R..........................";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSize = true;
            this.SUBTOTAL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTOTAL.Location = new System.Drawing.Point(10, 22);
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Size = new System.Drawing.Size(212, 18);
            this.SUBTOTAL.TabIndex = 3;
            this.SUBTOTAL.Text = "SUBTOTAL..................";
            // 
            // mtbCodigoProducto
            // 
            this.mtbCodigoProducto.Location = new System.Drawing.Point(129, 19);
            this.mtbCodigoProducto.Name = "mtbCodigoProducto";
            this.mtbCodigoProducto.Size = new System.Drawing.Size(166, 20);
            this.mtbCodigoProducto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // mtbCantidadProducto
            // 
            this.mtbCantidadProducto.Location = new System.Drawing.Point(443, 22);
            this.mtbCantidadProducto.Name = "mtbCantidadProducto";
            this.mtbCantidadProducto.Size = new System.Drawing.Size(61, 20);
            this.mtbCantidadProducto.TabIndex = 3;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(77, 177);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(199, 57);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(13, 240);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(108, 56);
            this.btnNuevaVenta.TabIndex = 6;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPrecio
            // 
            this.btnMostrarPrecio.Location = new System.Drawing.Point(229, 240);
            this.btnMostrarPrecio.Name = "btnMostrarPrecio";
            this.btnMostrarPrecio.Size = new System.Drawing.Size(108, 56);
            this.btnMostrarPrecio.TabIndex = 7;
            this.btnMostrarPrecio.Text = "Mostrar Precio";
            this.btnMostrarPrecio.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Location = new System.Drawing.Point(93, 257);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(75, 23);
            this.btnDescuentos.TabIndex = 4;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.UseVisualStyleBackColor = true;
            // 
            // btnRecargos
            // 
            this.btnRecargos.Location = new System.Drawing.Point(174, 257);
            this.btnRecargos.Name = "btnRecargos";
            this.btnRecargos.Size = new System.Drawing.Size(75, 23);
            this.btnRecargos.TabIndex = 5;
            this.btnRecargos.Text = "Recargos";
            this.btnRecargos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
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
            this.panAbajo.ResumeLayout(false);
            this.panAbajo.PerformLayout();
            this.panArriba.ResumeLayout(false);
            this.panItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panBusqueda.ResumeLayout(false);
            this.panBusqueda.PerformLayout();
            this.panMonto.ResumeLayout(false);
            this.panMontos.ResumeLayout(false);
            this.panMontos.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.MaskedTextBox mtbCantidadProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCodigoProducto;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnMostrarPrecio;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnRecargos;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
    }
}