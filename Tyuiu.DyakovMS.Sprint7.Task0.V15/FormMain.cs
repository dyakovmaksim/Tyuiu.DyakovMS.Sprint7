using System;
using System.Windows.Forms;
using Tyuiu.DyakovMS.Sprint7.Project.V15.Lib;

namespace Tyuiu.DyakovMS.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        private DataService dataService;

        public FormMain()
        {
            InitializeComponent();
            CustomizeUI();
            dataService = new DataService();
        }

        private void OpenFile_DMS_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Открыть файл данных"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataService.LoadFromCsv(openFileDialog.FileName);
                RefreshDataGrid();
                MessageBox.Show("Данные успешно загружены!", "Открытие файла");
            }
        }

        private void SaveFile_DMS_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Сохранить файл данных"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataService.SaveToCsv(saveFileDialog.FileName);
                MessageBox.Show("Данные успешно сохранены!", "Сохранение файла");
            }
        }

        private void Exit_DMS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для управления договорами организации.\nВам предлагается работа с базой данных:\n-Добавление договора\n-Редактирование договора\n-Сохранение информации\n-Поиск\n-Фильтрация\n-Просмотр статистики\nВы можете осуществить добавление договора, заполнив\nнеобходимые данные\nРазработчик: Дьяков М.С.\nГруппа: ИИПб-24-1\nПрограмма разработана в рамках изучения языка C#\nТюменский Индустриальный Университет (с) 2024\nВысшая Школа Цифровых Технологий (с) 2024\nВнутреннее имя: Tyuiu.DyakovMS.Sprint7.Project.V15", "О программе");
        }

        private void AddRecord_DMS_Click(object sender, EventArgs e)
        {
            var form = new AddEditForm(); 
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataService.Contracts.Add(form.NewContract);
                RefreshDataGrid();
                MessageBox.Show("Запись успешно добавлена!", "Добавление");
            }
        }


        private void DeleteRecord_DMS_Click(object sender, EventArgs e)
        {
            if (dataGridView_DMS.CurrentRow != null)
            {
                var index = dataGridView_DMS.CurrentRow.Index;
                dataService.Contracts.RemoveAt(index);
                RefreshDataGrid();
                MessageBox.Show("Запись успешно удалена!", "Удаление");
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Ошибка");
            }
        }


        private void SearchRecord_DMS_Click(object sender, EventArgs e)
        {
            var query = Microsoft.VisualBasic.Interaction.InputBox("Введите название организации для поиска:", "Поиск");
            if (!string.IsNullOrEmpty(query))
            {
                var results = dataService.Search(query);
                dataGridView_DMS.DataSource = results;

                MessageBox.Show($"Найдено записей: {results.Count}", "Результаты поиска");
            }
        }

        private void ShowStatistics_DMS_Click(object sender, EventArgs e)
        {
            var stats = dataService.GetStatistics();

            MessageBox.Show($"Количество договоров: {dataService.Contracts.Count}\n" +
                            $"Общая сумма договоров: {stats.Sum}\n" +
                            $"Минимальная сумма: {stats.Min}\n" +
                            $"Максимальная сумма: {stats.Max}\n" +
                            $"Средняя сумма: {stats.Avg:F2}",
                            "Статистика");
        }

        private void ShowStatisticsChart_DMS()
        {
            var form = new Form
            {
                Text = "Статистика",
                Width = 800,
                Height = 600
            };

            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart
            {
                Dock = DockStyle.Fill
            };

            chart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("HistogramArea"));

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Contracts",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                ChartArea = "HistogramArea"
            };

            foreach (var contract in dataService.Contracts)
            {
                series.Points.AddXY(contract.OrganizationName, contract.ContractAmount);
            }

            chart.Series.Add(series);

            form.Controls.Add(chart);
            form.ShowDialog();
        }
        private void RefreshDataGrid()
        {
            dataGridView_DMS.DataSource = null;
            dataGridView_DMS.DataSource = dataService.Contracts;

            dataGridView_DMS.Columns["ContractCode"].HeaderText = "Шифр договора";
            dataGridView_DMS.Columns["OrganizationName"].HeaderText = "Наименование организации";
            dataGridView_DMS.Columns["ExecutionPeriod"].HeaderText = "Срок выполнения";
            dataGridView_DMS.Columns["ContractAmount"].HeaderText = "Сумма договора";
            dataGridView_DMS.Columns["Notes"].HeaderText = "Примечания";
            dataGridView_DMS.Columns["ContractType"].HeaderText = "Тип договора";

            dataGridView_DMS.Columns["ContractCode"].Width = 120;
            dataGridView_DMS.Columns["OrganizationName"].Width = 120;
            dataGridView_DMS.Columns["ExecutionPeriod"].Width = 135;
            dataGridView_DMS.Columns["ContractAmount"].Width = 125;
            dataGridView_DMS.Columns["Notes"].Width = 120;
            dataGridView_DMS.Columns["ContractType"].Width = 120;

            UpdateStatistics();
        }

        private void SortRecords_Click(object sender, EventArgs e)
        {
            var column = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите имя колонки для сортировки (Шифр договора, Наименование организации, Сумма договора):",
                "Сортировка");

            var direction = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите направление сортировки (Возрастание/Убывание):",
                "Сортировка");

            if (!string.IsNullOrEmpty(column) && (direction == "Возрастание" || direction == "Убывание"))
            {
                var sortedContracts = direction == "Возрастание"
                    ? dataService.Contracts.OrderBy(c => GetPropertyValue(c, column)).ToList()
                    : dataService.Contracts.OrderByDescending(c => GetPropertyValue(c, column)).ToList();

                dataGridView_DMS.DataSource = null;
                dataGridView_DMS.DataSource = sortedContracts;
            }
            else
            {
                MessageBox.Show("Некорректные данные для сортировки.", "Ошибка");
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }

        private void FilterRecords_Click(object sender, EventArgs e)
        {
            var filterCriteria = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите минимальную сумму договора для фильтрации:",
                "Фильтрация");

            if (decimal.TryParse(filterCriteria, out var minAmount))
            {
                var filteredContracts = dataService.Contracts
                    .Where(c => c.ContractAmount >= minAmount)
                    .ToList();

                dataGridView_DMS.DataSource = null;
                dataGridView_DMS.DataSource = filteredContracts;

                MessageBox.Show($"Найдено записей: {filteredContracts.Count}", "Фильтрация");
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение.", "Ошибка");
            }
        }

        private void CustomizeUI()
        {
            this.Text = "Управление договорами организации";

            buttonAdd_DMS.ToolTipText = "Добавить новую запись о договоре";
            buttonDelete_DMS.ToolTipText = "Удалить выбранную запись";
            buttonSearch_DMS.ToolTipText = "Поиск записей по организации";
            buttonStats_DMS.ToolTipText = "Показать статистику по данным";

            dataGridView_DMS.AllowUserToAddRows = false;
            dataGridView_DMS.ReadOnly = true;

            ToolStripOpen_DMS.Click += OpenFile_DMS_Click;
            ToolStripSave_DMS.Click += SaveFile_DMS_Click;
            ToolStripExit_DMS.Click += Exit_DMS_Click;
            ToolStripAbout_DMS.Click += About_DMS_Click;

            buttonAdd_DMS.Click += AddRecord_DMS_Click;
            buttonDelete_DMS.Click += DeleteRecord_DMS_Click;
            buttonSearch_DMS.Click += SearchRecord_DMS_Click;
            buttonStats_DMS.Click += ShowStatistics_DMS_Click;
            buttonSort_DMS.Click += SortRecords_Click;
            buttonFilter_DMS.Click += FilterRecords_Click;
        }

        private void UpdateStatistics()
        {
            var stats = dataService.GetStatistics();

            labelCount_DMS.Text = dataService.Contracts.Count.ToString();
            labelSum_DMS.Text = stats.Sum.ToString();
            labelMin_DMS.Text = stats.Min.ToString();
            labelMax_DMS.Text = stats.Max.ToString();
            labelAvg_DMS.Text = stats.Avg.ToString("F2");

            chartStatistics_DMS.Series["Series1"].Points.Clear();

            var organizationGroups = dataService.Contracts
                .GroupBy(c => c.OrganizationName)
                .Select(g => new { Organization = g.Key, Count = g.Count() })
                .ToList();

            foreach (var group in organizationGroups)
            {
                chartStatistics_DMS.Series["Series1"].Points.AddXY(group.Organization, group.Count);
            }
        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }

        private void labelAvg_Click(object sender, EventArgs e)
        {

        }
    }
}