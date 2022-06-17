namespace Interfaz_CARINOR_2._0
{
    partial class FPedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DTGMostrarp = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Boton_Mostarpendiente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Boton_PedidosE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NobreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Pagar_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGMostrarp)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DTGMostrarp
            // 
            this.DTGMostrarp.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DTGMostrarp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGMostrarp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGMostrarp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGMostrarp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTGMostrarp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGMostrarp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTGMostrarp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGMostrarp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NobreCliente,
            this.Cantidad_Pedido,
            this.Cantidad_Pagar_P});
            this.DTGMostrarp.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DTGMostrarp.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTGMostrarp.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DTGMostrarp.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DTGMostrarp.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DTGMostrarp.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DTGMostrarp.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DTGMostrarp.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DTGMostrarp.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DTGMostrarp.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTGMostrarp.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DTGMostrarp.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DTGMostrarp.CurrentTheme.Name = null;
            this.DTGMostrarp.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTGMostrarp.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTGMostrarp.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DTGMostrarp.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DTGMostrarp.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGMostrarp.DefaultCellStyle = dataGridViewCellStyle4;
            this.DTGMostrarp.EnableHeadersVisualStyles = false;
            this.DTGMostrarp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DTGMostrarp.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DTGMostrarp.HeaderBgColor = System.Drawing.Color.Empty;
            this.DTGMostrarp.HeaderForeColor = System.Drawing.Color.White;
            this.DTGMostrarp.Location = new System.Drawing.Point(43, 102);
            this.DTGMostrarp.Name = "DTGMostrarp";
            this.DTGMostrarp.RowHeadersVisible = false;
            this.DTGMostrarp.RowTemplate.Height = 40;
            this.DTGMostrarp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGMostrarp.Size = new System.Drawing.Size(427, 429);
            this.DTGMostrarp.TabIndex = 1;
            this.DTGMostrarp.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Boton_Mostarpendiente
            // 
            this.Boton_Mostarpendiente.ActiveBorderThickness = 1;
            this.Boton_Mostarpendiente.ActiveCornerRadius = 20;
            this.Boton_Mostarpendiente.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Boton_Mostarpendiente.ActiveForecolor = System.Drawing.Color.White;
            this.Boton_Mostarpendiente.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Boton_Mostarpendiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Boton_Mostarpendiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_Mostarpendiente.BackgroundImage")));
            this.Boton_Mostarpendiente.ButtonText = "Pendientes";
            this.Boton_Mostarpendiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Mostarpendiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Mostarpendiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Boton_Mostarpendiente.IdleBorderThickness = 1;
            this.Boton_Mostarpendiente.IdleCornerRadius = 10;
            this.Boton_Mostarpendiente.IdleFillColor = System.Drawing.Color.White;
            this.Boton_Mostarpendiente.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Boton_Mostarpendiente.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Boton_Mostarpendiente.Location = new System.Drawing.Point(43, 53);
            this.Boton_Mostarpendiente.Margin = new System.Windows.Forms.Padding(5);
            this.Boton_Mostarpendiente.Name = "Boton_Mostarpendiente";
            this.Boton_Mostarpendiente.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Boton_Mostarpendiente.Size = new System.Drawing.Size(120, 41);
            this.Boton_Mostarpendiente.TabIndex = 2;
            this.Boton_Mostarpendiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_PedidosE
            // 
            this.Boton_PedidosE.ActiveBorderThickness = 1;
            this.Boton_PedidosE.ActiveCornerRadius = 20;
            this.Boton_PedidosE.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Boton_PedidosE.ActiveForecolor = System.Drawing.Color.White;
            this.Boton_PedidosE.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Boton_PedidosE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Boton_PedidosE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_PedidosE.BackgroundImage")));
            this.Boton_PedidosE.ButtonText = "Entregados";
            this.Boton_PedidosE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_PedidosE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_PedidosE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Boton_PedidosE.IdleBorderThickness = 1;
            this.Boton_PedidosE.IdleCornerRadius = 10;
            this.Boton_PedidosE.IdleFillColor = System.Drawing.Color.White;
            this.Boton_PedidosE.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Boton_PedidosE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Boton_PedidosE.Location = new System.Drawing.Point(163, 53);
            this.Boton_PedidosE.Margin = new System.Windows.Forms.Padding(5);
            this.Boton_PedidosE.Name = "Boton_PedidosE";
            this.Boton_PedidosE.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Boton_PedidosE.Size = new System.Drawing.Size(120, 41);
            this.Boton_PedidosE.TabIndex = 3;
            this.Boton_PedidosE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NobreCliente
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.NobreCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.NobreCliente.DividerWidth = 1;
            this.NobreCliente.HeaderText = "Cliente";
            this.NobreCliente.Name = "NobreCliente";
            this.NobreCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NobreCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad_Pedido
            // 
            this.Cantidad_Pedido.DividerWidth = 1;
            this.Cantidad_Pedido.HeaderText = "Cantidad";
            this.Cantidad_Pedido.Name = "Cantidad_Pedido";
            // 
            // Cantidad_Pagar_P
            // 
            this.Cantidad_Pagar_P.HeaderText = "Pendiente";
            this.Cantidad_Pagar_P.Name = "Cantidad_Pagar_P";
            // 
            // FPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 588);
            this.Controls.Add(this.Boton_PedidosE);
            this.Controls.Add(this.Boton_Mostarpendiente);
            this.Controls.Add(this.DTGMostrarp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPedidos";
            this.Text = "FPedidos";
            this.Load += new System.EventHandler(this.FPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGMostrarp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 Boton_PedidosE;
        private Bunifu.Framework.UI.BunifuThinButton2 Boton_Mostarpendiente;
        private Bunifu.UI.WinForms.BunifuDataGridView DTGMostrarp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NobreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Pagar_P;
    }
}