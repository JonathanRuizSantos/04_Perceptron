namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBProblemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lBResultados = new System.Windows.Forms.ListBox();
            this.dGVTablaVerdad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTablaVerdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cBProblemas
            // 
            this.cBProblemas.FormattingEnabled = true;
            this.cBProblemas.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "Mayoria Simple",
            "Paridad",
            "Ejercicio"});
            this.cBProblemas.Location = new System.Drawing.Point(131, 39);
            this.cBProblemas.Name = "cBProblemas";
            this.cBProblemas.Size = new System.Drawing.Size(121, 23);
            this.cBProblemas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problema";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Perceptrón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBResultados
            // 
            this.lBResultados.FormattingEnabled = true;
            this.lBResultados.ItemHeight = 15;
            this.lBResultados.Location = new System.Drawing.Point(517, 61);
            this.lBResultados.Name = "lBResultados";
            this.lBResultados.Size = new System.Drawing.Size(250, 334);
            this.lBResultados.TabIndex = 3;
            // 
            // dGVTablaVerdad
            // 
            this.dGVTablaVerdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTablaVerdad.Location = new System.Drawing.Point(38, 152);
            this.dGVTablaVerdad.Name = "dGVTablaVerdad";
            this.dGVTablaVerdad.RowTemplate.Height = 25;
            this.dGVTablaVerdad.Size = new System.Drawing.Size(448, 243);
            this.dGVTablaVerdad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla de verdad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVTablaVerdad);
            this.Controls.Add(this.lBResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBProblemas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTablaVerdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cBProblemas;
        private Label label1;
        private Button button1;
        private ListBox lBResultados;
        private DataGridView dGVTablaVerdad;
        private Label label2;
        private Label label3;
    }
}