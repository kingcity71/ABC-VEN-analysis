namespace ABCVEN
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PurchasesUploadBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFromDP = new System.Windows.Forms.DateTimePicker();
            this.dateToDP = new System.Windows.Forms.DateTimePicker();
            this.storeLabel = new System.Windows.Forms.Label();
            this.storeComboBox = new System.Windows.Forms.ComboBox();
            this.finSourceComboBox = new System.Windows.Forms.ComboBox();
            this.finSourceLabel = new System.Windows.Forms.Label();
            this.producerComboBox = new System.Windows.Forms.ComboBox();
            this.producerLabel = new System.Windows.Forms.Label();
            this.accountingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountingTypeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showDiagramm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CCheckBox = new System.Windows.Forms.CheckBox();
            this.BCheckBox = new System.Windows.Forms.CheckBox();
            this.ACheckBox = new System.Windows.Forms.CheckBox();
            this.MNNCheckBox = new System.Windows.Forms.CheckBox();
            this.TNCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MNNRadioButton = new System.Windows.Forms.RadioButton();
            this.TNRadioButton = new System.Windows.Forms.RadioButton();
            this.DefaultDataRadioButton = new System.Windows.Forms.RadioButton();
            this.SalesUploadBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PurchasesUploadBtn
            // 
            this.PurchasesUploadBtn.Location = new System.Drawing.Point(12, 12);
            this.PurchasesUploadBtn.Name = "PurchasesUploadBtn";
            this.PurchasesUploadBtn.Size = new System.Drawing.Size(145, 23);
            this.PurchasesUploadBtn.TabIndex = 0;
            this.PurchasesUploadBtn.Text = "Загрузить поставки";
            this.PurchasesUploadBtn.UseVisualStyleBackColor = true;
            this.PurchasesUploadBtn.Click += new System.EventHandler(this.PurchasesUploadBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "По";
            // 
            // dateFromDP
            // 
            this.dateFromDP.Location = new System.Drawing.Point(32, 48);
            this.dateFromDP.Name = "dateFromDP";
            this.dateFromDP.Size = new System.Drawing.Size(125, 20);
            this.dateFromDP.TabIndex = 4;
            // 
            // dateToDP
            // 
            this.dateToDP.Location = new System.Drawing.Point(32, 84);
            this.dateToDP.Name = "dateToDP";
            this.dateToDP.Size = new System.Drawing.Size(125, 20);
            this.dateToDP.TabIndex = 5;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Location = new System.Drawing.Point(202, 55);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(38, 13);
            this.storeLabel.TabIndex = 7;
            this.storeLabel.Text = "Склад";
            // 
            // storeComboBox
            // 
            this.storeComboBox.FormattingEnabled = true;
            this.storeComboBox.Location = new System.Drawing.Point(352, 52);
            this.storeComboBox.Name = "storeComboBox";
            this.storeComboBox.Size = new System.Drawing.Size(121, 21);
            this.storeComboBox.TabIndex = 8;
            // 
            // finSourceComboBox
            // 
            this.finSourceComboBox.FormattingEnabled = true;
            this.finSourceComboBox.Location = new System.Drawing.Point(352, 88);
            this.finSourceComboBox.Name = "finSourceComboBox";
            this.finSourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.finSourceComboBox.TabIndex = 10;
            // 
            // finSourceLabel
            // 
            this.finSourceLabel.AutoSize = true;
            this.finSourceLabel.Location = new System.Drawing.Point(202, 91);
            this.finSourceLabel.Name = "finSourceLabel";
            this.finSourceLabel.Size = new System.Drawing.Size(144, 13);
            this.finSourceLabel.TabIndex = 9;
            this.finSourceLabel.Text = "Источник финансирования";
            // 
            // producerComboBox
            // 
            this.producerComboBox.FormattingEnabled = true;
            this.producerComboBox.Location = new System.Drawing.Point(352, 157);
            this.producerComboBox.Name = "producerComboBox";
            this.producerComboBox.Size = new System.Drawing.Size(121, 21);
            this.producerComboBox.TabIndex = 14;
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(202, 160);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(86, 13);
            this.producerLabel.TabIndex = 13;
            this.producerLabel.Text = "Производитель";
            // 
            // accountingTypeComboBox
            // 
            this.accountingTypeComboBox.FormattingEnabled = true;
            this.accountingTypeComboBox.Location = new System.Drawing.Point(352, 121);
            this.accountingTypeComboBox.Name = "accountingTypeComboBox";
            this.accountingTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountingTypeComboBox.TabIndex = 12;
            // 
            // accountingTypeLabel
            // 
            this.accountingTypeLabel.AutoSize = true;
            this.accountingTypeLabel.Location = new System.Drawing.Point(202, 124);
            this.accountingTypeLabel.Name = "accountingTypeLabel";
            this.accountingTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.accountingTypeLabel.TabIndex = 11;
            this.accountingTypeLabel.Text = "Вид учета";
            this.accountingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showDiagramm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.CCheckBox);
            this.groupBox1.Controls.Add(this.BCheckBox);
            this.groupBox1.Controls.Add(this.ACheckBox);
            this.groupBox1.Controls.Add(this.MNNCheckBox);
            this.groupBox1.Controls.Add(this.TNCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(506, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 156);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABC-VEN анализ";
            // 
            // showDiagramm
            // 
            this.showDiagramm.Location = new System.Drawing.Point(230, 87);
            this.showDiagramm.Name = "showDiagramm";
            this.showDiagramm.Size = new System.Drawing.Size(75, 23);
            this.showDiagramm.TabIndex = 9;
            this.showDiagramm.Text = "Показать";
            this.showDiagramm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вывести на диаграмму";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(274, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "N";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(230, 121);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "E";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(187, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(33, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "V";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // CCheckBox
            // 
            this.CCheckBox.AutoSize = true;
            this.CCheckBox.Location = new System.Drawing.Point(99, 121);
            this.CCheckBox.Name = "CCheckBox";
            this.CCheckBox.Size = new System.Drawing.Size(33, 17);
            this.CCheckBox.TabIndex = 4;
            this.CCheckBox.Text = "C";
            this.CCheckBox.UseVisualStyleBackColor = true;
            // 
            // BCheckBox
            // 
            this.BCheckBox.AutoSize = true;
            this.BCheckBox.Location = new System.Drawing.Point(55, 121);
            this.BCheckBox.Name = "BCheckBox";
            this.BCheckBox.Size = new System.Drawing.Size(33, 17);
            this.BCheckBox.TabIndex = 3;
            this.BCheckBox.Text = "B";
            this.BCheckBox.UseVisualStyleBackColor = true;
            // 
            // ACheckBox
            // 
            this.ACheckBox.AutoSize = true;
            this.ACheckBox.Location = new System.Drawing.Point(12, 121);
            this.ACheckBox.Name = "ACheckBox";
            this.ACheckBox.Size = new System.Drawing.Size(33, 17);
            this.ACheckBox.TabIndex = 2;
            this.ACheckBox.Text = "A";
            this.ACheckBox.UseVisualStyleBackColor = true;
            // 
            // MNNCheckBox
            // 
            this.MNNCheckBox.AutoSize = true;
            this.MNNCheckBox.Location = new System.Drawing.Point(76, 21);
            this.MNNCheckBox.Name = "MNNCheckBox";
            this.MNNCheckBox.Size = new System.Drawing.Size(51, 17);
            this.MNNCheckBox.TabIndex = 1;
            this.MNNCheckBox.Text = "МНН";
            this.MNNCheckBox.UseVisualStyleBackColor = true;
            // 
            // TNCheckBox
            // 
            this.TNCheckBox.AutoSize = true;
            this.TNCheckBox.Location = new System.Drawing.Point(7, 20);
            this.TNCheckBox.Name = "TNCheckBox";
            this.TNCheckBox.Size = new System.Drawing.Size(41, 17);
            this.TNCheckBox.TabIndex = 0;
            this.TNCheckBox.Text = "ТН";
            this.TNCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MNNRadioButton);
            this.groupBox2.Controls.Add(this.TNRadioButton);
            this.groupBox2.Controls.Add(this.DefaultDataRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 42);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показать";
            // 
            // MNNRadioButton
            // 
            this.MNNRadioButton.AutoSize = true;
            this.MNNRadioButton.Location = new System.Drawing.Point(308, 19);
            this.MNNRadioButton.Name = "MNNRadioButton";
            this.MNNRadioButton.Size = new System.Drawing.Size(67, 17);
            this.MNNRadioButton.TabIndex = 19;
            this.MNNRadioButton.TabStop = true;
            this.MNNRadioButton.Text = "По МНН";
            this.MNNRadioButton.UseVisualStyleBackColor = true;
            // 
            // TNRadioButton
            // 
            this.TNRadioButton.AutoSize = true;
            this.TNRadioButton.Location = new System.Drawing.Point(160, 19);
            this.TNRadioButton.Name = "TNRadioButton";
            this.TNRadioButton.Size = new System.Drawing.Size(57, 17);
            this.TNRadioButton.TabIndex = 18;
            this.TNRadioButton.TabStop = true;
            this.TNRadioButton.Text = "По ТН";
            this.TNRadioButton.UseVisualStyleBackColor = true;
            // 
            // DefaultDataRadioButton
            // 
            this.DefaultDataRadioButton.AutoSize = true;
            this.DefaultDataRadioButton.Location = new System.Drawing.Point(6, 19);
            this.DefaultDataRadioButton.Name = "DefaultDataRadioButton";
            this.DefaultDataRadioButton.Size = new System.Drawing.Size(117, 17);
            this.DefaultDataRadioButton.TabIndex = 17;
            this.DefaultDataRadioButton.TabStop = true;
            this.DefaultDataRadioButton.Text = "Исходные данные";
            this.DefaultDataRadioButton.UseVisualStyleBackColor = true;
            // 
            // SalesUploadBtn
            // 
            this.SalesUploadBtn.Location = new System.Drawing.Point(201, 12);
            this.SalesUploadBtn.Name = "SalesUploadBtn";
            this.SalesUploadBtn.Size = new System.Drawing.Size(145, 23);
            this.SalesUploadBtn.TabIndex = 17;
            this.SalesUploadBtn.Text = "Загрузить продажи";
            this.SalesUploadBtn.UseVisualStyleBackColor = true;
            this.SalesUploadBtn.Click += new System.EventHandler(this.SalesUploadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 314);
            this.Controls.Add(this.SalesUploadBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.producerComboBox);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.accountingTypeComboBox);
            this.Controls.Add(this.accountingTypeLabel);
            this.Controls.Add(this.finSourceComboBox);
            this.Controls.Add(this.finSourceLabel);
            this.Controls.Add(this.storeComboBox);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.dateToDP);
            this.Controls.Add(this.dateFromDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PurchasesUploadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PurchasesUploadBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFromDP;
        private System.Windows.Forms.DateTimePicker dateToDP;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox storeComboBox;
        private System.Windows.Forms.ComboBox finSourceComboBox;
        private System.Windows.Forms.Label finSourceLabel;
        private System.Windows.Forms.ComboBox producerComboBox;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.ComboBox accountingTypeComboBox;
        private System.Windows.Forms.Label accountingTypeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox CCheckBox;
        private System.Windows.Forms.CheckBox BCheckBox;
        private System.Windows.Forms.CheckBox ACheckBox;
        private System.Windows.Forms.CheckBox MNNCheckBox;
        private System.Windows.Forms.CheckBox TNCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showDiagramm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton MNNRadioButton;
        private System.Windows.Forms.RadioButton TNRadioButton;
        private System.Windows.Forms.RadioButton DefaultDataRadioButton;
        private System.Windows.Forms.Button SalesUploadBtn;
    }
}

