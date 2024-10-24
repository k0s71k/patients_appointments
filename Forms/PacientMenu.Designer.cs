namespace TestProject.Forms
{
    partial class PacientMenu
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
            MyReceptionsList = new ListBox();
            label1 = new Label();
            SpecializationsList = new ComboBox();
            TakeReception = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // ReceptionsList
            // 
            ReceptionsList.FormattingEnabled = true;
            ReceptionsList.ItemHeight = 15;
            ReceptionsList.Location = new Point(12, 64);
            ReceptionsList.Name = "ReceptionsList";
            ReceptionsList.Size = new Size(206, 289);
            ReceptionsList.TabIndex = 0;
            // 
            // MyReceptionsList
            // 
            MyReceptionsList.FormattingEnabled = true;
            MyReceptionsList.ItemHeight = 15;
            MyReceptionsList.Location = new Point(550, 34);
            MyReceptionsList.Name = "MyReceptionsList";
            MyReceptionsList.Size = new Size(206, 319);
            MyReceptionsList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Записи на прием";
            // 
            // SpecializationsList
            // 
            SpecializationsList.FormattingEnabled = true;
            SpecializationsList.Location = new Point(12, 37);
            SpecializationsList.Name = "SpecializationsList";
            SpecializationsList.Size = new Size(206, 23);
            SpecializationsList.TabIndex = 3;
            SpecializationsList.SelectedIndexChanged += OnSpecializationChanged;
            // 
            // TakeReception
            // 
            TakeReception.Location = new Point(224, 330);
            TakeReception.Name = "TakeReception";
            TakeReception.Size = new Size(128, 23);
            TakeReception.TabIndex = 4;
            TakeReception.Text = "Записаться";
            TakeReception.UseVisualStyleBackColor = true;
            TakeReception.Click += OnTakeClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 14);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Мои записи";
            // 
            // PacientMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 362);
            Controls.Add(label2);
            Controls.Add(TakeReception);
            Controls.Add(SpecializationsList);
            Controls.Add(label1);
            Controls.Add(MyReceptionsList);
            Controls.Add(ReceptionsList);
            Name = "PacientMenu";
            Text = "PacientMenu";
            FormClosed += OnFormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ReceptionsList;
        private ListBox MyReceptionsList;
        private Label label1;
        private ComboBox SpecializationsList;
        private Button TakeReception;
        private Label label2;
    }
}