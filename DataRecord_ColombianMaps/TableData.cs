using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;
using System.IO;

namespace DataRecord_ColombianMaps
{
    public partial class TableData : Form
    {
        //An array used to load the Departaments.
        string[] list_departaments;



        public TableData()
        {
            InitializeComponent();

            //Save all the departaments in a string and then I put them in the array using the split funtion.
            string list = Properties.Resources.Departamentos.ToString();
            list_departaments = list.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

        }

        //This method allows to put each departament in the comboBox.
        private void TableData_Load(object sender, EventArgs e)
        {
            loadDepartaments();

            //Data for the Diagram
            string[] regions = { "Región Eje Cafetero - Antioquia", "Región Centro Oriente", "Región Caribe", "Región Llano", "Región Centro Sur", "Región Pacífico" };
            int[] q_municipalities = { 178, 367, 197, 78, 124, 179 };

            Diagram.Palette = ChartColorPalette.SeaGreen;
            Diagram.Titles.Add("Municipalities by Regions");

            for (int i = 0; i < regions.Length; i++)
            {
                Series serie = Diagram.Series.Add(regions[i]);
                serie.Label = q_municipalities[i].ToString();
                serie.Points.Add(q_municipalities[i]);
            }

        }

        //Load all the departaments in a ComboBox
        private void loadDepartaments()
        {
            for (int i = 0; i < list_departaments.Length; i++)
            {
                listDepartaments.Items.Add(list_departaments[i]);
            }
        }

        //This method is used to search a departament.
        private void Filt_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataView)DataMap.DataSource).Table;
            dt.DefaultView.RowFilter = string.Format("DEPARTAMENTO = '{0}'", listDepartaments.Text);

        }

        //This methods are used to avoid an incorrect use of the "Filter" button.
        private void control_buttons()
        {
            if (listDepartaments.Text.Trim() != string.Empty)
            {
                Filt.Enabled = true;
            }
        }

        private void listDepartaments_TextChanged(object sender, EventArgs e)
        {
            control_buttons();
        }



        //Notes for Teemacia: This method allows to create a connection between the form and the file System Manager using OleDb.
        DataView ImportData(String fileName)
        {


            string title = "Colombian Regions";

            DataSet ds = new DataSet();


            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("REGIÓN");
            ds.Tables[title].Columns.Add("CODIGO DANE");
            ds.Tables[title].Columns.Add("DEPARTAMENTO");
            ds.Tables[title].Columns.Add("CODIGO DANE MUNICIPIO");
            ds.Tables[title].Columns.Add("MUNICIPIO");



            string[] lineas = File.ReadAllLines(fileName);


            for (int i = 0; i < lineas.Length; i++)
            {
                string[] celdas = lineas[i].Split(',');

                int value = celdas.Length;

                switch (value)
                {
                    case 5:
                        ds.Tables[title].Rows.Add(celdas);
                        break;
                    case 6:
                        string r = celdas[0];
                        string cd = celdas[1];
                        string d = "Archipiélago de San Andrés, Providencia y Santa Catalina";
                        string cdm = celdas[4];
                        string m = celdas[5];

                        string[] replace = { r, cd, d, cdm, m };

                        ds.Tables[title].Rows.Add(replace);
                        break;

                }

            }

            return ds.Tables[0].DefaultView;

        }

        private void importData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Used like a filter: xlx; xlxs



                Title = "Seleccionar Archivo"
            };

            //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataMap.DataSource = ImportData(openFileDialog.FileName);
            }

            Filter.Visible = true;
            listDepartaments.Visible = true;
            listDepartaments.Enabled = true;
            Filt.Visible = true;
            Diagram.Visible = true;
        }
    }
        
}




