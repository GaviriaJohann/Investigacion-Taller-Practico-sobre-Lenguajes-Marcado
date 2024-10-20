using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace C__XML_JSON_CRUD
{
    public partial class FrmJson : Form
    {
        public FrmJson()
        {
            InitializeComponent();
        }

        private string jsonFilePath = "archivos/Productos.json";

        private void FrmJson_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Cargar el contenido actual del archivo JSON
                var jsonData = LoadJson();
                var products = jsonData["productos"].ToObject<List<Product>>();

                // Crear un nuevo producto
                var newProduct = new Product
                {
                    IdProducto = products.Count > 0 ? products.Max(p => p.IdProducto) + 1 : 101,
                    StrNombre = TxtInput.Text,
                    StrCodigo = "NEW-CODE", // Aquí deberías definir cómo generar el código
                    NumPrecioCompra = 0.0, // Asigna un precio de compra por defecto
                    NumPrecioVenta = 0.0, // Asigna un precio de venta por defecto
                    IdCategoria = 0, // Asigna la categoría por defecto
                    StrDetalle = "Nuevo producto",
                    strFoto = "default.jpg", // Asigna una foto por defecto
                    NumStock = 0, // Asigna un stock por defecto
                    DtmFechaModifica = DateTime.Now,
                    StrUsuarioModifica = "admin"
                };

                products.Add(newProduct);

                // Guardar los cambios en el archivo JSON
                SaveJson(products);
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
                // Cargar el contenido actual del archivo JSON
                var jsonData = LoadJson();
                var products = jsonData["productos"].ToObject<List<Product>>();

                var selectedRecord = ListBoxRecords.SelectedItem as string;
                if (selectedRecord == null)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.");
                    return;
                }

                // Obtener el Id del producto seleccionado
                var recordId = int.Parse(selectedRecord.Split(':')[0]);
                var product = products.FirstOrDefault(p => p.IdProducto == recordId);

                if (product != null)
                {
                    product.StrNombre = TxtInput.Text; // Actualiza otros campos según sea necesario
                    product.DtmFechaModifica = DateTime.Now;

                    // Guardar los cambios en el archivo JSON
                    SaveJson(products);
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
                // Cargar el contenido actual del archivo JSON
                var jsonData = LoadJson();
                var products = jsonData["productos"].ToObject<List<Product>>();

                var selectedRecord = ListBoxRecords.SelectedItem as string;
                if (selectedRecord == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                    return;
                }

                // Obtener el Id del producto seleccionado
                var recordId = int.Parse(selectedRecord.Split(':')[0]);
                var product = products.FirstOrDefault(p => p.IdProducto == recordId);

                if (product != null)
                {
                    products.Remove(product); // Elimina el producto

                    // Guardar los cambios en el archivo JSON
                    SaveJson(products);
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
                var jsonData = LoadJson();
                var products = jsonData["productos"].ToObject<List<Product>>();

                ListBoxRecords.DataSource = products.Select(p => $"{p.IdProducto}: {p.StrNombre}").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar registros: " + ex.Message);
            }
        }

        private JObject LoadJson()
        {
            if (!File.Exists(jsonFilePath))
            {
                var initialData = new JObject(new JProperty("productos", new JArray()));
                File.WriteAllText(jsonFilePath, initialData.ToString());
            }

            return JObject.Parse(File.ReadAllText(jsonFilePath));
        }

        private void SaveJson(List<Product> products)
        {
            var jsonData = new JObject(new JProperty("productos", JToken.FromObject(products)));
            File.WriteAllText(jsonFilePath, jsonData.ToString());
        }
    }

    public class Product
    {
        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public double NumPrecioCompra { get; set; }
        public double NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string strFoto { get; set; }
        public int NumStock { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }
    }
}
