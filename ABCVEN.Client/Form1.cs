using System;
using System.Data;

using System.ComponentModel;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;
using ABCVEN.Interfaces;
//using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Collections.Generic;

namespace ABCVEN
{
    public partial class Form1 : Form
    {
        private readonly IFileUploadService fileUploadService;
        private readonly ICrudService crudService;

        public Form1(IFileUploadService fileUploadService, ICrudService crudService)
        {
            this.fileUploadService = fileUploadService;
            this.crudService = crudService;
            InitializeComponent();
            
        }
        private void SetInitialValues()
        {
            accountingTypeComboBox.DataSource
                = crudService.GetAllAccountingTypes().ToList();
            storeComboBox.DataSource
                = crudService.GetAllStores().ToList();
            finSourceComboBox.DataSource
                = crudService.GetAllFinSources().ToList();
            producerComboBox.DataSource
                = crudService.GetAllProducers().ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialValues();
            //SetDataGridView(list);
            
        }
        private void SetDataGridView(List<object> list)
        {
            var binder = new BindingSource();
            binder.DataSource = list;
            dataGridView1.DataSource = binder;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void PurchasesUploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            var data = fileUploadService.ReadFile(fileName);
            crudService.SetPurchases(data);
            MessageBox.Show("Данные успешно загружены");
            
        }
        private void SalesUploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            var data = fileUploadService.ReadFile(fileName);
            crudService.SetSales(data);
            MessageBox.Show("Данные успешно загружены");
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
