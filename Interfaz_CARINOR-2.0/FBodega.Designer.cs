
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
            this.DGTBodega = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1guardar = new System.Windows.Forms.Button();
            this.tbxCADUCIDAD = new System.Windows.Forms.TextBox();
            this.tbxPRECIO = new System.Windows.Forms.TextBox();
            this.tbxPRODUCTO = new System.Windows.Forms.TextBox();
            this.tbxMARCA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6pedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CIDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // DGTBodega
            // 
            this.DGTBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGTBodega.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGTBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDPedido,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGTBodega.Location = new System.Drawing.Point(45, 47);
            this.DGTBodega.Name = "DGTBodega";
            this.DGTBodega.Size = new System.Drawing.Size(441, 469);
            this.DGTBodega.TabIndex = 18;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1guardar);
            this.groupBox1.Controls.Add(this.tbxCADUCIDAD);
            this.groupBox1.Controls.Add(this.tbxPRECIO);
            this.groupBox1.Controls.Add(this.tbxPRODUCTO);
            this.groupBox1.Controls.Add(this.tbxMARCA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6pedido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 336);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTOS QUE ENTRAN A LA BODEGA";
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
            this.button1guardar.Click += new System.EventHandler(this.button1guardar_Click);
            // 
            // tbxCADUCIDAD
            // 
            this.tbxCADUCIDAD.Location = new System.Drawing.Point(173, 174);
            this.tbxCADUCIDAD.Name = "tbxCADUCIDAD";
            this.tbxCADUCIDAD.Size = new System.Drawing.Size(129, 22);
            this.tbxCADUCIDAD.TabIndex = 1;
            // 
            // tbxPRECIO
            // 
            this.tbxPRECIO.Location = new System.Drawing.Point(173, 127);
            this.tbxPRECIO.Name = "tbxPRECIO";
            this.tbxPRECIO.Size = new System.Drawing.Size(129, 22);
            this.tbxPRECIO.TabIndex = 1;
            // 
            // tbxPRODUCTO
            // 
            this.tbxPRODUCTO.Location = new System.Drawing.Point(173, 45);
            this.tbxPRODUCTO.Name = "tbxPRODUCTO";
            this.tbxPRODUCTO.Size = new System.Drawing.Size(129, 22);
            this.tbxPRODUCTO.TabIndex = 1;
            // 
            // tbxMARCA
            // 
            this.tbxMARCA.Location = new System.Drawing.Point(173, 87);
            this.tbxMARCA.Name = "tbxMARCA";
            this.tbxMARCA.Size = new System.Drawing.Size(129, 22);
            this.tbxMARCA.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CADUCIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PRECIO";
            // 
            // label6pedido
            // 
            this.label6pedido.AutoSize = true;
            this.label6pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6pedido.Location = new System.Drawing.Point(33, 46);
            this.label6pedido.Name = "label6pedido";
            this.label6pedido.Size = new System.Drawing.Size(93, 16);
            this.label6pedido.TabIndex = 0;
            this.label6pedido.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARCA";
            // 
            // CIDPedido
            // 
            this.CIDPedido.HeaderText = "PRODUCTO";
            this.CIDPedido.Name = "CIDPedido";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MARCA";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRECIO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CADUCIDAD";
            this.Column3.Name = "Column3";
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
        private System.Windows.Forms.DataGridView DGTBodega;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1guardar;
        private System.Windows.Forms.TextBox tbxCADUCIDAD;
        private System.Windows.Forms.TextBox tbxPRECIO;
        private System.Windows.Forms.TextBox tbxPRODUCTO;
        private System.Windows.Forms.TextBox tbxMARCA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}