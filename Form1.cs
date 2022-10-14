namespace Perceptron
{
    public partial class Form1 : Form
    {
        double aux_ceros = 1;
        double aux_ceros2 = 1;
        int avanzaCelda;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBProblemas.Text == "AND") 
                { 
                    TablaDeVerdad(2, 4);
                    LlenarTabla(4);
                }
                else if (cBProblemas.Text == "OR") {  }
                else if (cBProblemas.Text == "XOR") {  }
                else if (cBProblemas.Text == "Mayoria Simple") {  }
                else if (cBProblemas.Text == "Paridad") {  }
                else if (cBProblemas.Text == "Ejercicio") {  }
                else { }
            }
            catch
            {

            }
        }

        private void pesosUmbral()
        {
            Random umbral = new Random();
            Random pesos = new Random();
            //random.Next(0, 1);
            //lBResultados.(random);
            var valorUmbral = umbral.NextDouble();
            var valorPesos = pesos.Next(0, 2);
            MessageBox.Show(valorPesos.ToString());
        }

        public void TablaDeVerdad(double n, double filas)
        {
            for (int i = 0; i < n; i++)
            {
                dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "X" + (i + 1).ToString() });
            }

            for (int j = 1; j < filas; j++)
            {
                j = dGVTablaVerdad.Rows.Add(new DataGridViewRow());
            }

            dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Y" });
        }



        public void LlenarTabla(int entradas)
        {
            double filas;
            filas = Math.Pow(2, entradas);
            avanzaCelda = entradas - 1;

            for (int i = 0; i < filas; i++)
            {
                // Ciclo que pone 0 en el Datagrid de la tabla de verad
                for (int j = 0; j < aux_ceros; j++)
                {
                    dGVTablaVerdad.Rows[i].Cells[avanzaCelda].Value = "0";
                    i++;
                }

                // Ciclo que pone 1 en el Datagrid de la tabla de verdad
                for (int b = 0; b < aux_ceros; b++)
                {

                    dGVTablaVerdad.Rows[i].Cells[avanzaCelda].Value = "1";
                    i++;
                }

                i--;

                if (i == filas - 1 && avanzaCelda != 0)
                {
                    i = -1;
                    avanzaCelda--;
                    aux_ceros = Math.Pow(2, aux_ceros2);
                    aux_ceros2++;
                }
            }
        }
    }
}