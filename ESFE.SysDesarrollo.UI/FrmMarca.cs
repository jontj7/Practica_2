using ESFE.SysDesarrollo.EN;
using ESFE.SysDesarrollo.LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESFE.SysDesarrollo.UI
{
    public partial class FrmMarca : Form
    {
        private MarcaBL _marcaBL;
        public FrmMarca()
        {
                    
            InitializeComponent();
            _marcaBL = new MarcaBL();


        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtDescripcion.Text) || !int.TryParse(TxtRDM.Text, out int regMarca))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            Marca nuevaMarca = new Marca
            {
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                RegMarca = regMarca
            };

            int resultado = _marcaBL.InsertarMarca(nuevaMarca);

            if (resultado > 0)
            {
                MessageBox.Show("Marca insertada correctamente.");
            }
            else
            {
                MessageBox.Show("Marca insertada correctamente.");
            }

            // Actualiza el DataGridView
            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            dataGridView1.DataSource = marcas;
        }

        private void BtnObtener_Click(object sender, EventArgs e)
        {
            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            dataGridView1.DataSource = marcas;

            // Mostrar el DataGridView
            dataGridView1.Visible = true;
        }

        private void BtnOPN_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            List<Marca> marcas = _marcaBL.ObtenerMarcaNombre(nombre);
            dataGridView1.DataSource = marcas;
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int idMarca) && int.TryParse(TxtRDM.Text, out int regMarca))
            {
                Marca marcaActualizada = new Marca
                {
                    IdMarca = idMarca,
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    RegMarca = regMarca
                };

                int resultado = _marcaBL.ActualizarMarca(marcaActualizada);

                if (resultado > 0)
                {
                    MessageBox.Show("No se actualiza correctamente.");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("Marca actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la marca.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores válidos para ID y RDM.");
            }

            // Actualiza el DataGridView
            List<Marca> marcas = _marcaBL.ObtenerMarcas();
            dataGridView1.DataSource = marcas;


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            // Verifica que el campo ID no esté vacío y sea un número entero válido
            if (int.TryParse(TxtID.Text, out int idMarca))
            {
                // Llama al método de eliminación en la capa de lógica de negocio
                int resultado = _marcaBL.EliminarMarca(idMarca);

                if (resultado > 0)
                {
                    MessageBox.Show("Marca eliminada correctamente.");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("No se encontró la marca para eliminar.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar la marca.");
                }

                // Actualiza el DataGridView (opcional)
                List<Marca> marcas = _marcaBL.ObtenerMarcas();
                dataGridView1.DataSource = marcas;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            // Configurar el formulario
            this.BackColor = Color.White; // Fondo blanco para el formulario

            // Configurar el DataGridView
            ConfigureDataGridView();

            // Configurar los TextBox para tener una línea azul debajo
            ConfigureTextBoxBorders();

            // Personalizar los botones manteniendo el color
            CustomizeButtons();

            // Configurar la fuente de los Label para un aspecto más profesional
            CustomizeLabels();
        }

        private void ConfigureDataGridView()
        {
            // Configurar el DataGridView
           
            dataGridView1.BackgroundColor = Color.White; // Fondo blanco para el DataGridView
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Bordes de las celdas

            // Configurar el estilo de las celdas para que coincida con la fuente de los labels
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Fuente más formal
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Color del texto

            // Ocultar el DataGridView por defecto
            dataGridView1.Visible = false;
        }

        private void ConfigureTextBoxBorders()
        {
            // Configurar el borde para los TextBox
            AddBorderToTextBox(TxtID);
            AddBorderToTextBox(TxtNombre);
            AddBorderToTextBox(TxtDescripcion);
            AddBorderToTextBox(TxtRDM);
        }

        private void AddBorderToTextBox(TextBox textBox)
        {
            textBox.BackColor = Color.White; // Fondo blanco para el TextBox
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Configurar la fuente

            // Crear un borde inferior
            var borderPanel = new Panel
            {
                BackColor = Color.Blue, // Color azul
                Height = 2, // Altura del borde
                Dock = DockStyle.Bottom
            };

            // Añadir el borde al TextBox
            textBox.Controls.Add(borderPanel);
        }

        private void CustomizeButtons()
        {
            // Personalizar todos los botones manteniendo el color
            CustomizeButton(BtnInsert);
            CustomizeButton(BtnObtener);
            CustomizeButton(BtnOPN);
            CustomizeButton(BtnAct);
            CustomizeButton(BtnBorrar);
        }

        private void CustomizeButton(Button button)
        {
            
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Arial", 12, FontStyle.Bold); // Mantener la fuente predeterminada
        }

        private void CustomizeLabels()
        {
            // Personalizar la fuente de todos los labels
            CustomizeLabel(label1);
            CustomizeLabel(label2);
            CustomizeLabel(label3);
            CustomizeLabel(label4);
            // Agregar otros labels si es necesario
        }

        private void CustomizeLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Fuente más formal
            label.ForeColor = Color.Black; // Color del texto

        }
    }
}
