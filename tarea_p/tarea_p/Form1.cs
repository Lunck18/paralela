using System;
using System.Diagnostics; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_p
{
    public partial class Form1 : Form
     {
        public Form1()
         {
            InitializeComponent();
            UpdateP();
   
        }
        private void UpdateP()
        {
            listBoxProcesos.Items.Clear();
            listBoxPid.Items.Clear();
            listBoxMR.Items.Clear();
            int n = 1;
            foreach (Process p in Process.GetProcesses())
            {
                listBoxProcesos.Items.Add(n + "::" + p.ProcessName);//muestra el nombre de los procesos
                listBoxPid.Items.Add(n + ":: " + p.Id);// muestra el PID
                listBoxMR.Items.Add(n + "::" + p.WorkingSet64);//muestra la memoria ram que estan utilizando los procesos
                listBoxCPU.Items.Add(n + "::" + p.SessionId);//muestra los nucleos usados de los procesos
                n = n + 1;
            }
            PA.Text = "Procesos ejecutando se: " + listBoxProcesos.Items.Count.ToString();// Nos muestra la cantidad de procesos ejecutando se
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach ( Process p in Process.GetProcesses())
                {
                    string arr = listBoxProcesos.SelectedItem.ToString();
                    string[] proceso = arr.Split(':');

                    if (p.ProcessName == proceso[1])
                    {
                        p.Kill();//Elimina procesos
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("No se ah seleccionado ningun proceso" + x, "Error", MessageBoxButtons.OK);

            }


        }

        private void botonC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonA_Click(object sender, EventArgs e)
        {
            UpdateP();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateP();
        }
    }
}
