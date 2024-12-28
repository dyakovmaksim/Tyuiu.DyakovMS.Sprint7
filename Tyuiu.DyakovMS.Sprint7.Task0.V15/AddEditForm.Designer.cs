namespace Tyuiu.DyakovMS.Sprint7.Project.V15
{
    partial class AddEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxContractCode_DMS;
        private System.Windows.Forms.TextBox textBoxOrganizationName_DMS;
        private System.Windows.Forms.TextBox textBoxExecutionPeriod_DMS;
        private System.Windows.Forms.TextBox textBoxContractAmount_DMS;
        private System.Windows.Forms.TextBox textBoxNotes_DMS;
        private System.Windows.Forms.TextBox textBoxContractType_DMS;
        private System.Windows.Forms.Button buttonSaveEdit_DMS;
        private System.Windows.Forms.Label lableContractCode_DMS;
        private System.Windows.Forms.Label lableOrganizationName_DMS;
        private System.Windows.Forms.Label lableExecutionPeriod_DMS;
        private System.Windows.Forms.Label lableContractAmount_DMS;
        private System.Windows.Forms.Label lableNotes_DMS;
        private System.Windows.Forms.Label lableContractType_DMS;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxContractCode_DMS = new TextBox();
            textBoxOrganizationName_DMS = new TextBox();
            textBoxExecutionPeriod_DMS = new TextBox();
            textBoxContractAmount_DMS = new TextBox();
            textBoxNotes_DMS = new TextBox();
            textBoxContractType_DMS = new TextBox();
            buttonSaveEdit_DMS = new Button();
            lableContractCode_DMS = new Label();
            lableOrganizationName_DMS = new Label();
            lableExecutionPeriod_DMS = new Label();
            lableContractAmount_DMS = new Label();
            lableNotes_DMS = new Label();
            lableContractType_DMS = new Label();
            SuspendLayout();
            // 
            // textBoxContractCode_DMS
            // 
            textBoxContractCode_DMS.Location = new Point(150, 27);
            textBoxContractCode_DMS.Name = "textBoxContractCode_DMS";
            textBoxContractCode_DMS.Size = new Size(200, 23);
            textBoxContractCode_DMS.TabIndex = 1;
            // 
            // textBoxOrganizationName_DMS
            // 
            textBoxOrganizationName_DMS.Location = new Point(150, 67);
            textBoxOrganizationName_DMS.Name = "textBoxOrganizationName_DMS";
            textBoxOrganizationName_DMS.Size = new Size(200, 23);
            textBoxOrganizationName_DMS.TabIndex = 3;
            // 
            // textBoxExecutionPeriod_DMS
            // 
            textBoxExecutionPeriod_DMS.Location = new Point(150, 107);
            textBoxExecutionPeriod_DMS.Name = "textBoxExecutionPeriod_DMS";
            textBoxExecutionPeriod_DMS.Size = new Size(200, 23);
            textBoxExecutionPeriod_DMS.TabIndex = 5;
            // 
            // textBoxContractAmount_DMS
            // 
            textBoxContractAmount_DMS.Location = new Point(150, 147);
            textBoxContractAmount_DMS.Name = "textBoxContractAmount_DMS";
            textBoxContractAmount_DMS.Size = new Size(200, 23);
            textBoxContractAmount_DMS.TabIndex = 7;
            // 
            // textBoxNotes_DMS
            // 
            textBoxNotes_DMS.Location = new Point(150, 187);
            textBoxNotes_DMS.Name = "textBoxNotes_DMS";
            textBoxNotes_DMS.Size = new Size(200, 23);
            textBoxNotes_DMS.TabIndex = 9;
            // 
            // textBoxContractType_DMS
            // 
            textBoxContractType_DMS.Location = new Point(150, 227);
            textBoxContractType_DMS.Name = "textBoxContractType_DMS";
            textBoxContractType_DMS.Size = new Size(200, 23);
            textBoxContractType_DMS.TabIndex = 11;
            // 
            // buttonSaveEdit_DMS
            // 
            buttonSaveEdit_DMS.Location = new Point(150, 270);
            buttonSaveEdit_DMS.Name = "buttonSaveEdit_DMS";
            buttonSaveEdit_DMS.Size = new Size(100, 30);
            buttonSaveEdit_DMS.TabIndex = 12;
            buttonSaveEdit_DMS.Text = "Сохранить";
            buttonSaveEdit_DMS.UseVisualStyleBackColor = true;
            buttonSaveEdit_DMS.Click += btnSave_Click;
            // 
            // lableContractCode_DMS
            // 
            lableContractCode_DMS.AutoSize = true;
            lableContractCode_DMS.Location = new Point(30, 30);
            lableContractCode_DMS.Name = "lableContractCode_DMS";
            lableContractCode_DMS.Size = new Size(98, 15);
            lableContractCode_DMS.TabIndex = 0;
            lableContractCode_DMS.Text = "Шифр договора:";
            // 
            // lableOrganizationName_DMS
            // 
            lableOrganizationName_DMS.AutoSize = true;
            lableOrganizationName_DMS.Location = new Point(30, 70);
            lableOrganizationName_DMS.Name = "lableOrganizationName_DMS";
            lableOrganizationName_DMS.Size = new Size(118, 15);
            lableOrganizationName_DMS.TabIndex = 2;
            lableOrganizationName_DMS.Text = "Наименование орг.:";
            // 
            // lableExecutionPeriod_DMS
            // 
            lableExecutionPeriod_DMS.AutoSize = true;
            lableExecutionPeriod_DMS.Location = new Point(30, 110);
            lableExecutionPeriod_DMS.Name = "lableExecutionPeriod_DMS";
            lableExecutionPeriod_DMS.Size = new Size(110, 15);
            lableExecutionPeriod_DMS.TabIndex = 4;
            lableExecutionPeriod_DMS.Text = "Срок выполнения:";
            // 
            // lableContractAmount_DMS
            // 
            lableContractAmount_DMS.AutoSize = true;
            lableContractAmount_DMS.Location = new Point(30, 150);
            lableContractAmount_DMS.Name = "lableContractAmount_DMS";
            lableContractAmount_DMS.Size = new Size(102, 15);
            lableContractAmount_DMS.TabIndex = 6;
            lableContractAmount_DMS.Text = "Сумма договора:";
            // 
            // lableNotes_DMS
            // 
            lableNotes_DMS.AutoSize = true;
            lableNotes_DMS.Location = new Point(30, 190);
            lableNotes_DMS.Name = "lableNotes_DMS";
            lableNotes_DMS.Size = new Size(81, 15);
            lableNotes_DMS.TabIndex = 8;
            lableNotes_DMS.Text = "Примечания:";
            // 
            // lableContractType_DMS
            // 
            lableContractType_DMS.AutoSize = true;
            lableContractType_DMS.Location = new Point(30, 230);
            lableContractType_DMS.Name = "lableContractType_DMS";
            lableContractType_DMS.Size = new Size(84, 15);
            lableContractType_DMS.TabIndex = 10;
            lableContractType_DMS.Text = "Тип договора:";
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(textBoxContractCode_DMS);
            Controls.Add(textBoxOrganizationName_DMS);
            Controls.Add(textBoxExecutionPeriod_DMS);
            Controls.Add(textBoxContractAmount_DMS);
            Controls.Add(textBoxNotes_DMS);
            Controls.Add(textBoxContractType_DMS);
            Controls.Add(buttonSaveEdit_DMS);
            Controls.Add(lableContractCode_DMS);
            Controls.Add(lableOrganizationName_DMS);
            Controls.Add(lableExecutionPeriod_DMS);
            Controls.Add(lableContractAmount_DMS);
            Controls.Add(lableNotes_DMS);
            Controls.Add(lableContractType_DMS);
            Name = "AddEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить/Редактировать договор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}