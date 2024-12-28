using System;
using System.Windows.Forms;
using Tyuiu.DyakovMS.Sprint7.Project.V15.Lib;

namespace Tyuiu.DyakovMS.Sprint7.Project.V15
{
    public partial class AddEditForm : Form
    {
        public Contract NewContract { get; private set; }

        public AddEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                NewContract = new Contract
                {
                    ContractCode = textBoxContractCode_DMS.Text,
                    OrganizationName = textBoxOrganizationName_DMS.Text,
                    ExecutionPeriod = textBoxExecutionPeriod_DMS.Text,
                    ContractAmount = decimal.Parse(textBoxContractAmount_DMS.Text),
                    Notes = textBoxNotes_DMS.Text,
                    ContractType = textBoxContractType_DMS.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}