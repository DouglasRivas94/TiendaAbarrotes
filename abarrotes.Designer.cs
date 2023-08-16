namespace TiendaAbarrotes
{
    partial class abarrotes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            txtquantity = new TextBox();
            txtprice = new TextBox();
            label4 = new Label();
            btncalculate = new Button();
            btnClear = new Button();
            btnexit = new Button();
            lstv = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 61);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio Unitario";
            // 
            // txtname
            // 
            txtname.Location = new Point(131, 58);
            txtname.Name = "txtname";
            txtname.Size = new Size(144, 23);
            txtname.TabIndex = 3;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(342, 58);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(100, 23);
            txtquantity.TabIndex = 4;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(538, 58);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(100, 23);
            txtprice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(176, 9);
            label4.Name = "label4";
            label4.Size = new Size(373, 32);
            label4.TabIndex = 6;
            label4.Text = "Calculo De Precio por Cantidad";
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(304, 98);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(75, 23);
            btncalculate.TabIndex = 7;
            btncalculate.Text = "Calcular";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(623, 301);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 9;
            btnexit.Text = "cerrar";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // lstv
            // 
            lstv.Location = new Point(12, 136);
            lstv.Name = "lstv";
            lstv.Size = new Size(686, 159);
            lstv.TabIndex = 10;
            lstv.UseCompatibleStateImageBehavior = false;
            lstv.View = View.List;
            // 
            // abarrotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 336);
            Controls.Add(lstv);
            Controls.Add(btnexit);
            Controls.Add(btnClear);
            Controls.Add(btncalculate);
            Controls.Add(label4);
            Controls.Add(txtprice);
            Controls.Add(txtquantity);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "abarrotes";
            Text = "abarrotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private TextBox txtquantity;
        private TextBox txtprice;
        private Label label4;
        private Button btncalculate;
        private Button btnClear;
        private Button btnexit;
        private ListView lstv;
    }
}