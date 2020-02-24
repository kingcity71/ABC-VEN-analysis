using System;
using System.ComponentModel;
using System.Windows.Forms;
using ABCVEN.Interfaces;
using ABCVEN.Models;
using System.Linq;
using System.Collections.Generic;

namespace ABCVEN
{
    public partial class Form1 : Form
    {
        private readonly IFileUploadService fileUploadService;
        private readonly ICrudService crudService;
        private readonly ICalculationService calculationService;
        private readonly IViewService viewService;

        public Form1(IFileUploadService fileUploadService, ICrudService crudService,
            ICalculationService calculationService, IViewService viewService)
        {
            this.fileUploadService = fileUploadService;
            this.crudService = crudService;
            this.calculationService = calculationService;
            this.viewService = viewService;
            InitializeComponent();

        }
        private void SetInitialValues()
        {
            SetComboBoxes();
            SetDatePickerBorders();
            var viewList = viewService.GetSalesViewModels().Select(x => (object)x).ToList();
            SetDataGridView(viewList);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialValues();
        }
        private void SetDataGridView(List<object> list)
        {
            var binder = new BindingSource();
            binder.DataSource = list;
            dataGridView1.DataSource = binder;
        }
        private void SetComboBoxes()
        {
            List<string> GetComboBoxList(List<string> list)
            {
                var result = new List<string>() { "Все" };
                result.AddRange(list);
                return result;
            }
            
            accountingTypeComboBox.DataSource = GetComboBoxList(crudService.GetAllAccountingTypes().ToList());
            storeComboBox.DataSource = GetComboBoxList(crudService.GetAllStores().ToList());
            finSourceComboBox.DataSource = GetComboBoxList(crudService.GetAllFinSources().ToList());
            producerComboBox.DataSource = GetComboBoxList(crudService.GetAllProducers().ToList());
        }
        private void SetDatePickerBorders()
        {
            var borders = viewService.GetTimeBorders();
            dateFromDP.Value = borders.Item1;
            dateToDP.Value = borders.Item2;
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
