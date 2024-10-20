using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__XML_JSON_CRUD
{
    public partial class FrmXml : Form
    {
        public FrmXml()
        {
            InitializeComponent();
        }

        private string xmlFilePath = "archivos/Empleados.xml";

        private void FrmXml_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                XElement root = XElement.Load(xmlFilePath);
                XElement newEmployee = new XElement("Empleado",
                    new XElement("Id", Guid.NewGuid().ToString()),
                    new XElement("Nombre", TxtInput.Text),
                    new XElement("Documento", TxtDocumento.Text),
                    new XElement("Direccion", TxtDireccion.Text),
                    new XElement("Telefono", TxtTelefono.Text),
                    new XElement("Email", TxtEmail.Text),
                    new XElement("Rol", TxtRol.Text),
                    new XElement("DatosAdicionales", TxtDatosAdicionales.Text)
                );
                root.Add(newEmployee);
                root.Save(xmlFilePath);
                MessageBox.Show("Registro creado exitosamente.");
                LoadRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear registro: " + ex.Message);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                XElement root = XElement.Load(xmlFilePath);
                var selectedRecord = ListBoxRecords.SelectedItem as string;
                if (selectedRecord == null)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.");
                    return;
                }

                var recordId = selectedRecord.Split(':')[0];
                var employee = root.Elements("Empleado").FirstOrDefault(emp => emp.Element("Id").Value == recordId);
                if (employee != null)
                {
                    employee.Element("Nombre").Value = TxtInput.Text;
                    employee.Element("Documento").Value = TxtDocumento.Text;
                    employee.Element("Direccion").Value = TxtDireccion.Text;
                    employee.Element("Telefono").Value = TxtTelefono.Text;
                    employee.Element("Email").Value = TxtEmail.Text;
                    employee.Element("Rol").Value = TxtRol.Text;
                    employee.Element("DatosAdicionales").Value = TxtDatosAdicionales.Text;

                    root.Save(xmlFilePath);
                    MessageBox.Show("Registro actualizado exitosamente.");
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar registro: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                XElement root = XElement.Load(xmlFilePath);
                var selectedRecord = ListBoxRecords.SelectedItem as string;
                if (selectedRecord == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                    return;
                }

                var recordId = selectedRecord.Split(':')[0];
                var employee = root.Elements("Empleado").FirstOrDefault(emp => emp.Element("Id").Value == recordId);
                if (employee != null)
                {
                    employee.Remove();
                    root.Save(xmlFilePath);
                    MessageBox.Show("Registro eliminado exitosamente.");
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }

        private void LoadRecords()
        {
            try
            {
                XElement root = XElement.Load(xmlFilePath);
                var employees = root.Elements("Empleado")
                    .Select(e => $"{e.Element("Id").Value}: {e.Element("Nombre").Value}")
                    .ToList();
                ListBoxRecords.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar registros: " + ex.Message);
            }
        }
    }
}
