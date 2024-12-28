namespace Tyuiu.DyakovMS.Sprint7.Project.V15
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip_DMS = new MenuStrip();
            ToolStripFile_DMS = new ToolStripMenuItem();
            ToolStripOpen_DMS = new ToolStripMenuItem();
            ToolStripSave_DMS = new ToolStripMenuItem();
            ToolStripExit_DMS = new ToolStripMenuItem();
            ToolStripHelp_DMS = new ToolStripMenuItem();
            ToolStripAbout_DMS = new ToolStripMenuItem();
            toolStrip_DMS = new ToolStrip();
            buttonAdd_DMS = new ToolStripButton();
            buttonDelete_DMS = new ToolStripButton();
            buttonSearch_DMS = new ToolStripButton();
            buttonStats_DMS = new ToolStripButton();
            buttonSort_DMS = new ToolStripButton();
            buttonFilter_DMS = new ToolStripButton();
            dataGridView_DMS = new DataGridView();
            groupBoxStatistics_DMS = new GroupBox();
            labelAvgStats_DMS = new Label();
            labelMaxStats_DMS = new Label();
            labelMinStats_DMS = new Label();
            labelSumStats_DMS = new Label();
            labelCountStats_DMS = new Label();
            labelCount_DMS = new Label();
            labelSum_DMS = new Label();
            labelMin_DMS = new Label();
            labelMax_DMS = new Label();
            labelAvg_DMS = new Label();
            chartStatistics_DMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip_DMS.SuspendLayout();
            toolStrip_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStatistics_DMS).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_DMS
            // 
            menuStrip_DMS.Items.AddRange(new ToolStripItem[] { ToolStripFile_DMS, ToolStripHelp_DMS });
            menuStrip_DMS.Location = new Point(0, 0);
            menuStrip_DMS.Name = "menuStrip_DMS";
            menuStrip_DMS.Size = new Size(759, 24);
            menuStrip_DMS.TabIndex = 0;
            // 
            // ToolStripFile_DMS
            // 
            ToolStripFile_DMS.DropDownItems.AddRange(new ToolStripItem[] { ToolStripOpen_DMS, ToolStripSave_DMS, ToolStripExit_DMS });
            ToolStripFile_DMS.Name = "ToolStripFile_DMS";
            ToolStripFile_DMS.Size = new Size(48, 20);
            ToolStripFile_DMS.Text = "Файл";
            // 
            // ToolStripOpen_DMS
            // 
            ToolStripOpen_DMS.Name = "ToolStripOpen_DMS";
            ToolStripOpen_DMS.Size = new Size(133, 22);
            ToolStripOpen_DMS.Text = "Открыть";
            // 
            // ToolStripSave_DMS
            // 
            ToolStripSave_DMS.Name = "ToolStripSave_DMS";
            ToolStripSave_DMS.Size = new Size(133, 22);
            ToolStripSave_DMS.Text = "Сохранить";
            // 
            // ToolStripExit_DMS
            // 
            ToolStripExit_DMS.Name = "ToolStripExit_DMS";
            ToolStripExit_DMS.Size = new Size(133, 22);
            ToolStripExit_DMS.Text = "Выход";
            // 
            // ToolStripHelp_DMS
            // 
            ToolStripHelp_DMS.DropDownItems.AddRange(new ToolStripItem[] { ToolStripAbout_DMS });
            ToolStripHelp_DMS.Name = "ToolStripHelp_DMS";
            ToolStripHelp_DMS.Size = new Size(65, 20);
            ToolStripHelp_DMS.Text = "Справка";
            // 
            // ToolStripAbout_DMS
            // 
            ToolStripAbout_DMS.Name = "ToolStripAbout_DMS";
            ToolStripAbout_DMS.Size = new Size(180, 22);
            ToolStripAbout_DMS.Text = "О программе";
            // 
            // toolStrip_DMS
            // 
            toolStrip_DMS.Items.AddRange(new ToolStripItem[] { buttonAdd_DMS, buttonDelete_DMS, buttonSearch_DMS, buttonStats_DMS, buttonSort_DMS, buttonFilter_DMS });
            toolStrip_DMS.Location = new Point(0, 24);
            toolStrip_DMS.Name = "toolStrip_DMS";
            toolStrip_DMS.Size = new Size(759, 25);
            toolStrip_DMS.TabIndex = 1;
            // 
            // buttonAdd_DMS
            // 
            buttonAdd_DMS.Name = "buttonAdd_DMS";
            buttonAdd_DMS.Size = new Size(63, 22);
            buttonAdd_DMS.Text = "Добавить";
            // 
            // buttonDelete_DMS
            // 
            buttonDelete_DMS.Name = "buttonDelete_DMS";
            buttonDelete_DMS.Size = new Size(55, 22);
            buttonDelete_DMS.Text = "Удалить";
            // 
            // buttonSearch_DMS
            // 
            buttonSearch_DMS.Name = "buttonSearch_DMS";
            buttonSearch_DMS.Size = new Size(46, 22);
            buttonSearch_DMS.Text = "Поиск";
            // 
            // buttonStats_DMS
            // 
            buttonStats_DMS.Name = "buttonStats_DMS";
            buttonStats_DMS.Size = new Size(72, 22);
            buttonStats_DMS.Text = "Статистика";
            // 
            // buttonSort_DMS
            // 
            buttonSort_DMS.Name = "buttonSort_DMS";
            buttonSort_DMS.Size = new Size(77, 22);
            buttonSort_DMS.Text = "Сортировка";
            // 
            // buttonFilter_DMS
            // 
            buttonFilter_DMS.Name = "buttonFilter_DMS";
            buttonFilter_DMS.Size = new Size(52, 22);
            buttonFilter_DMS.Text = "Фильтр";
            // 
            // dataGridView_DMS
            // 
            dataGridView_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DMS.Dock = DockStyle.Fill;
            dataGridView_DMS.Location = new Point(0, 49);
            dataGridView_DMS.Name = "dataGridView_DMS";
            dataGridView_DMS.Size = new Size(759, 401);
            dataGridView_DMS.TabIndex = 0;
            // 
            // groupBoxStatistics_DMS
            // 
            groupBoxStatistics_DMS.Location = new Point(0, 0);
            groupBoxStatistics_DMS.Name = "groupBoxStatistics_DMS";
            groupBoxStatistics_DMS.Size = new Size(200, 100);
            groupBoxStatistics_DMS.TabIndex = 2;
            groupBoxStatistics_DMS.TabStop = false;
            // 
            // labelAvgStats_DMS
            // 
            labelAvgStats_DMS.Location = new Point(0, 0);
            labelAvgStats_DMS.Name = "labelAvgStats_DMS";
            labelAvgStats_DMS.Size = new Size(100, 23);
            labelAvgStats_DMS.TabIndex = 0;
            // 
            // labelMaxStats_DMS
            // 
            labelMaxStats_DMS.Location = new Point(0, 0);
            labelMaxStats_DMS.Name = "labelMaxStats_DMS";
            labelMaxStats_DMS.Size = new Size(100, 23);
            labelMaxStats_DMS.TabIndex = 0;
            // 
            // labelMinStats_DMS
            // 
            labelMinStats_DMS.Location = new Point(0, 0);
            labelMinStats_DMS.Name = "labelMinStats_DMS";
            labelMinStats_DMS.Size = new Size(100, 23);
            labelMinStats_DMS.TabIndex = 0;
            // 
            // labelSumStats_DMS
            // 
            labelSumStats_DMS.Location = new Point(0, 0);
            labelSumStats_DMS.Name = "labelSumStats_DMS";
            labelSumStats_DMS.Size = new Size(100, 23);
            labelSumStats_DMS.TabIndex = 0;
            // 
            // labelCountStats_DMS
            // 
            labelCountStats_DMS.Location = new Point(0, 0);
            labelCountStats_DMS.Name = "labelCountStats_DMS";
            labelCountStats_DMS.Size = new Size(100, 23);
            labelCountStats_DMS.TabIndex = 0;
            // 
            // labelCount_DMS
            // 
            labelCount_DMS.Location = new Point(10, 32);
            labelCount_DMS.Name = "labelCount_DMS";
            labelCount_DMS.Size = new Size(100, 23);
            labelCount_DMS.TabIndex = 0;
            // 
            // labelSum_DMS
            // 
            labelSum_DMS.Location = new Point(10, 68);
            labelSum_DMS.Name = "labelSum_DMS";
            labelSum_DMS.Size = new Size(100, 23);
            labelSum_DMS.TabIndex = 1;
            // 
            // labelMin_DMS
            // 
            labelMin_DMS.Location = new Point(200, 32);
            labelMin_DMS.Name = "labelMin_DMS";
            labelMin_DMS.Size = new Size(100, 23);
            labelMin_DMS.TabIndex = 2;
            // 
            // labelMax_DMS
            // 
            labelMax_DMS.Location = new Point(200, 68);
            labelMax_DMS.Name = "labelMax_DMS";
            labelMax_DMS.Size = new Size(100, 23);
            labelMax_DMS.TabIndex = 3;
            labelMax_DMS.Click += labelMax_Click;
            // 
            // labelAvg_DMS
            // 
            labelAvg_DMS.Location = new Point(398, 32);
            labelAvg_DMS.Name = "labelAvg_DMS";
            labelAvg_DMS.Size = new Size(100, 23);
            labelAvg_DMS.TabIndex = 4;
            labelAvg_DMS.Click += labelAvg_Click;
            // 
            // chartStatistics_DMS
            // 
            chartArea1.Name = "ChartArea1";
            chartStatistics_DMS.ChartAreas.Add(chartArea1);
            chartStatistics_DMS.Dock = DockStyle.Right;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartStatistics_DMS.Legends.Add(legend1);
            chartStatistics_DMS.Location = new Point(759, 0);
            chartStatistics_DMS.Name = "chartStatistics_DMS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStatistics_DMS.Series.Add(series1);
            chartStatistics_DMS.Size = new Size(400, 450);
            chartStatistics_DMS.TabIndex = 3;
            // 
            // FormMain
            // 
            ClientSize = new Size(1159, 450);
            Controls.Add(dataGridView_DMS);
            Controls.Add(toolStrip_DMS);
            Controls.Add(menuStrip_DMS);
            Controls.Add(groupBoxStatistics_DMS);
            Controls.Add(chartStatistics_DMS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление договорами организации";
            menuStrip_DMS.ResumeLayout(false);
            menuStrip_DMS.PerformLayout();
            toolStrip_DMS.ResumeLayout(false);
            toolStrip_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStatistics_DMS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFile_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripHelp_DMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAbout_DMS;
        private System.Windows.Forms.ToolStrip toolStrip_DMS;
        private System.Windows.Forms.ToolStripButton buttonAdd_DMS;
        private System.Windows.Forms.ToolStripButton buttonDelete_DMS;
        private System.Windows.Forms.ToolStripButton buttonSearch_DMS;
        private System.Windows.Forms.ToolStripButton buttonStats_DMS;
        private System.Windows.Forms.DataGridView dataGridView_DMS;
        private System.Windows.Forms.ToolStripButton buttonSort_DMS;
        private System.Windows.Forms.ToolStripButton buttonFilter_DMS;
        private System.Windows.Forms.GroupBox groupBoxStatistics_DMS;
        private System.Windows.Forms.Label labelCount_DMS;
        private System.Windows.Forms.Label labelSum_DMS;
        private System.Windows.Forms.Label labelMin_DMS;
        private System.Windows.Forms.Label labelMax_DMS;
        private System.Windows.Forms.Label labelAvg_DMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics_DMS;
        private Label labelMinStats_DMS;
        private Label labelSumStats_DMS;
        private Label labelCountStats_DMS;
        private Label labelMaxStats_DMS;
        private Label labelAvgStats_DMS;
    }
}