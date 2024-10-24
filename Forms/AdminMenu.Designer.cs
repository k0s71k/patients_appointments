namespace TestProject.Forms
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            ReceptionsList = new ListBox();
            ReceptionInfo = new Label();
            ActiveReceptions = new CheckBox();
            DoctorCombo = new ComboBox();
            SpecializationCombo = new ComboBox();
            label1 = new Label();
            AddButton = new Button();
            DateTimeSelect = new DateTimePicker();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // ReceptionsList
            // 
            ReceptionsList.FormattingEnabled = true;
            ReceptionsList.ItemHeight = 15;
            ReceptionsList.Location = new Point(12, 31);
            ReceptionsList.Name = "ReceptionsList";
            ReceptionsList.Size = new Size(209, 319);
            ReceptionsList.TabIndex = 0;
            ReceptionsList.SelectedIndexChanged += ReceptionsList_SelectedIndexChanged;
            // 
            // ReceptionInfo
            // 
            ReceptionInfo.AutoSize = true;
            ReceptionInfo.Location = new Point(227, 31);
            ReceptionInfo.Name = "ReceptionInfo";
            ReceptionInfo.Size = new Size(0, 15);
            ReceptionInfo.TabIndex = 2;
            // 
            // ActiveReceptions
            // 
            ActiveReceptions.AutoSize = true;
            ActiveReceptions.Location = new Point(12, 6);
            ActiveReceptions.Name = "ActiveReceptions";
            ActiveReceptions.Size = new Size(120, 19);
            ActiveReceptions.TabIndex = 3;
            ActiveReceptions.Text = "Только активные";
            ActiveReceptions.UseVisualStyleBackColor = true;
            ActiveReceptions.CheckedChanged += ActiveReceptions_CheckedChanged;
            // 
            // DoctorCombo
            // 
            DoctorCombo.FormattingEnabled = true;
            DoctorCombo.Location = new Point(579, 31);
            DoctorCombo.Name = "DoctorCombo";
            DoctorCombo.Size = new Size(168, 23);
            DoctorCombo.TabIndex = 4;
            // 
            // SpecializationCombo
            // 
            SpecializationCombo.FormattingEnabled = true;
            SpecializationCombo.Location = new Point(579, 60);
            SpecializationCombo.Name = "SpecializationCombo";
            SpecializationCombo.Size = new Size(168, 23);
            SpecializationCombo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 7;
            label1.Text = "Добавление новой записи";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(579, 127);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(168, 23);
            AddButton.TabIndex = 8;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddReception;
            // 
            // DateTimeSelect
            // 
            DateTimeSelect.Location = new Point(579, 89);
            DateTimeSelect.Name = "DateTimeSelect";
            DateTimeSelect.Size = new Size(168, 23);
            DateTimeSelect.TabIndex = 9;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(227, 327);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 23);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteReception;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 362);
            Controls.Add(DeleteButton);
            Controls.Add(DateTimeSelect);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(SpecializationCombo);
            Controls.Add(DoctorCombo);
            Controls.Add(ActiveReceptions);
            Controls.Add(ReceptionInfo);
            Controls.Add(ReceptionsList);
            Name = "AdminMenu";
            Text = "AdminMenu";
            FormClosed += OnFormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ReceptionsList;
        private Label ReceptionInfo;
        private CheckBox ActiveReceptions;
        private ComboBox DoctorCombo;
        private ComboBox SpecializationCombo;
        private Label label1;
        private Button AddButton;
        private DateTimePicker DateTimeSelect;
        private Button DeleteButton;
    }
}