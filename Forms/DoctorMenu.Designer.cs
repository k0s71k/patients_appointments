namespace TestProject.Forms
{
    partial class DoctorMenu
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
            label1 = new Label();
            ReceptionsList = new ListBox();
            ReceptionInfo = new Label();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Активные записи";
            // 
            // ReceptionsList
            // 
            ReceptionsList.FormattingEnabled = true;
            ReceptionsList.ItemHeight = 15;
            ReceptionsList.Location = new Point(12, 37);
            ReceptionsList.Name = "ReceptionsList";
            ReceptionsList.Size = new Size(163, 319);
            ReceptionsList.TabIndex = 1;
            ReceptionsList.SelectedIndexChanged += ReceptionsList_SelectedIndexChanged;
            // 
            // ReceptionInfo
            // 
            ReceptionInfo.AutoSize = true;
            ReceptionInfo.Location = new Point(181, 37);
            ReceptionInfo.Name = "ReceptionInfo";
            ReceptionInfo.Size = new Size(135, 15);
            ReceptionInfo.TabIndex = 2;
            ReceptionInfo.Text = "Информация о записи:";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(181, 333);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(175, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отменить запись";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelReception;
            // 
            // DoctorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 373);
            Controls.Add(CancelButton);
            Controls.Add(ReceptionInfo);
            Controls.Add(ReceptionsList);
            Controls.Add(label1);
            Name = "DoctorMenu";
            Text = "DoctorMenu";
            FormClosed += OnFormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ReceptionsList;
        private Label ReceptionInfo;
        private Button CancelButton;
    }
}