namespace Perceptron
{
    public partial class Form1 : Form
    {
        int entradas;
        double filas;
        double aux_ceros = 1;
        double aux_ceros2 = 1;
        int avanzaCelda;
        int valor1;
        string valor2;
        double salida_Y = 0;
        double valor2_double;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                limpia();

                if (cBProblemas.Text == "AND") 
                {
                    entradas = 2;
                    filas = Math.Pow(2, entradas);
                    TablaDeVerdad(entradas, filas);
                    LlenarTabla(entradas, filas);
                    Y_esperada(1,entradas,1);
                }
                else if (cBProblemas.Text == "OR")
                {
                    entradas = 2;
                    filas = Math.Pow(2, entradas);
                    TablaDeVerdad(entradas, filas);
                    LlenarTabla(entradas, filas);
                    Y_esperada(0, entradas, 1);
                }
                else if (cBProblemas.Text == "XOR")
                {
                    entradas = 2;
                    filas = Math.Pow(2, entradas);
                    TablaDeVerdad(entradas, filas);
                    LlenarTabla(entradas, filas);
                    Y_esperada(1, entradas, 1);
                }
                else if (cBProblemas.Text == "Mayoria Simple")
                {
                    entradas = 3;
                    filas = Math.Pow(2, entradas);
                    TablaDeVerdad(entradas, filas);
                    LlenarTabla(entradas, filas);
                }
                else if (cBProblemas.Text == "Paridad")
                {
                    entradas = 4;
                    filas = Math.Pow(2, entradas);
                    TablaDeVerdad(entradas, filas);
                    LlenarTabla(entradas, filas);
                }
                else if (cBProblemas.Text == "Ejercicio")
                {
                
                }
                else 
                {
                    MessageBox.Show("Opcion no valida");
                }
            }
            catch
            {

            }
        }

        private void pesosUmbral()
        {
            Random umbral = new Random();
            Random pesos = new Random();
            var valorUmbral = umbral.NextDouble();
            var valorPesos = 0;

            int[] pesos_array = new int[entradas];

            for(int i = 0; i < pesos_array.Length; i++)
            {
                valorPesos = pesos.Next(0, 2);
                pesos_array[i] = valorPesos;
            }
        }

        public void TablaDeVerdad(int entradas, double filas)
        {
            for (int i = 0; i < entradas; i++)
            {
                dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "X" + (i + 1).ToString() });
            }

            for (int j = 1; j < filas; j++)
            {
                j = dGVTablaVerdad.Rows.Add(new DataGridViewRow());
            }

            dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Yesperada" });
            dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ycalculada" });
        }

        public void LlenarTabla(int entradas, double filas)
        {
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
        public void limpia()
        {
            dGVTablaVerdad.Rows.Clear();
            dGVTablaVerdad.Columns.Clear();
            lBResultados.Items.Clear();
            aux_ceros = 1;
            aux_ceros2 = 1;

        }

        public void Y_esperada(double umbral, int entradas, int peso1)
        {
            int ultimoRenglon = entradas;

            
            // Este ciclo recorre las filas
            for (int a = 0; a < filas; a++)
            {
                // Este ciclo recorre las columnas
                for (int i = 0; i < entradas; i++)
                {
                    // Obtencion de los valores del datagrid de Pesos
                    valor1 = peso1;
                    valor2 = (string)dGVTablaVerdad.Rows[a].Cells[i].Value;
                    valor2_double = double.Parse(valor2);
                    // Obtencion del valor de la suma por renglon
                    salida_Y = salida_Y + (valor1 * valor2_double);
                }
                
                // Evalua el estado del umbral
                if (salida_Y > umbral)
                {
                    dGVTablaVerdad.Rows[a].Cells[ultimoRenglon].Value = "1";
                    salida_Y = 0;
                }
                else
                {
                    dGVTablaVerdad.Rows[a].Cells[ultimoRenglon].Value = "0";
                    salida_Y = 0;
                }
            }   
        }
    }
}