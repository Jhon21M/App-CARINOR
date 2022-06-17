
namespace Interfaz_CARINOR_2._0
{
    partial class FBodega
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DGTBodega = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CIDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1guardar = new System.Windows.Forms.Button();
            this.textBox1destino = new System.Windows.Forms.TextBox();
            this.textBox3cliente = new System.Windows.Forms.TextBox();
            this.textBox2precio = new System.Windows.Forms.TextBox();
            this.textBox1Idpedido = new System.Windows.Forms.TextBox();
            this.textBox1cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6pedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGTBodega)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bodega";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(867, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(867, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(867, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DGTBodega
            // 
            this.DGTBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGTBodega.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGTBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDPedido});
            this.DGTBodega.Location = new System.Drawing.Point(45, 47);
            this.DGTBodega.Name = "DGTBodega";
            this.DGTBodega.Size = new System.Drawing.Size(415, 469);
            this.DGTBodega.TabIndex = 18;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CIDPedido
            // 
            this.CIDPedido.HeaderText = "ID";
            this.CIDPedido.Name = "CIDPedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1guardar);
            this.groupBox1.Controls.Add(this.textBox1destino);
            this.groupBox1.Controls.Add(this.textBox3cliente);
            this.groupBox1.Controls.Add(this.textBox2precio);
            this.groupBox1.Controls.Add(this.textBox1Idpedido);
            this.groupBox1.Controls.Add(this.textBox1cantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6pedido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(533, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 336);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEDIDOS";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(186, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1guardar
            // 
            this.button1guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1guardar.Location = new System.Drawing.Point(63, 239);
            this.button1guardar.Name = "button1guardar";
            this.button1guardar.Size = new System.Drawing.Size(74, 39);
            this.button1guardar.TabIndex = 2;
            this.button1guardar.Text = "Guardar";
            this.button1guardar.UseVisualStyleBackColor = false;
            // 
            // textBox1destino
            // 
            this.textBox1destino.Location = new System.Drawing.Point(173, 182);
            this.textBox1destino.Name = "textBox1destino";
            this.textBox1destino.Size = new System.Drawing.Size(129, 20);
            this.textBox1destino.TabIndex = 1;
            // 
            // textBox3cliente
            // 
            this.textBox3cliente.Location = new System.Drawing.Point(173, 144);
            this.textBox3cliente.Name = "textBox3cliente";
            this.textBox3cliente.Size = new System.Drawing.Size(129, 20);
            this.textBox3cliente.TabIndex = 1;
            // 
            // textBox2precio
            // 
            this.textBox2precio.Location = new System.Drawing.Point(173, 110);
            this.textBox2precio.Name = "textBox2precio";
            this.textBox2precio.Size = new System.Drawing.Size(129, 20);
            this.textBox2precio.TabIndex = 1;
            // 
            // textBox1Idpedido
            // 
            this.textBox1Idpedido.Location = new System.Drawing.Point(173, 45);
            this.textBox1Idpedido.Name = "textBox1Idpedido";
            this.textBox1Idpedido.Size = new System.Drawing.Size(129, 20);
            this.textBox1Idpedido.TabIndex = 1;
            // 
            // textBox1cantidad
            // 
            this.textBox1cantidad.Location = new System.Drawing.Point(173, 75);
            this.textBox1cantidad.Name = "textBox1cantidad";
            this.textBox1cantidad.Size = new System.Drawing.Size(129, 20);
            this.textBox1cantidad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // label6pedido
            // 
            this.label6pedido.AutoSize = true;
            this.label6pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6pedido.Location = new System.Drawing.Point(33, 46);
            this.label6pedido.Name = "label6pedido";
            this.label6pedido.Size = new System.Drawing.Size(73, 16);
            this.label6pedido.TabIndex = 0;
            this.label6pedido.Text = "Id pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            // 
            // FBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGTBodega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBodega";
            this.Text = "FBodega";
            this.Load += new System.EventHandler(this.FBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTBodega)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGTBodega;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1guardar;
        private System.Windows.Forms.TextBox textBox1destino;
        private System.Windows.Forms.TextBox textBox3cliente;
        private System.Windows.Forms.TextBox textBox2precio;
        private System.Windows.Forms.TextBox textBox1Idpedido;
        private System.Windows.Forms.TextBox textBox1cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6pedido;
        private System.Windows.Forms.Label label2;
    }
}