using System.Data.SqlClient;

namespace Lab2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.getRadioButton = new System.Windows.Forms.RadioButton();
            this.byDirectCheck = new System.Windows.Forms.CheckBox();
            this.byIDCheck = new System.Windows.Forms.CheckBox();
            this.execButton = new System.Windows.Forms.Button();
            this.direcButton = new System.Windows.Forms.Button();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.midNameTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.directionLabel = new System.Windows.Forms.Label();
            this.directDropDown = new System.Windows.Forms.ComboBox();
            this.artLabel = new System.Windows.Forms.Label();
            this.artclTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.queryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(40, 45);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(112, 121);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(218, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(317, 73);
            this.title.TabIndex = 1;
            this.title.Text = "Scientists";
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.deleteRadioButton);
            this.queryGroupBox.Controls.Add(this.updateRadioButton);
            this.queryGroupBox.Controls.Add(this.addRadioButton);
            this.queryGroupBox.Controls.Add(this.getRadioButton);
            this.queryGroupBox.Location = new System.Drawing.Point(40, 197);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(161, 134);
            this.queryGroupBox.TabIndex = 2;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Text = "Тип запиту";
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(7, 89);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(128, 17);
            this.deleteRadioButton.TabIndex = 3;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Вилучення науковця";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(7, 66);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(131, 17);
            this.updateRadioButton.TabIndex = 2;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Оновлення науковця";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(6, 43);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(132, 17);
            this.addRadioButton.TabIndex = 1;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Додавання науковця";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // getRadioButton
            // 
            this.getRadioButton.AutoSize = true;
            this.getRadioButton.Location = new System.Drawing.Point(7, 20);
            this.getRadioButton.Name = "getRadioButton";
            this.getRadioButton.Size = new System.Drawing.Size(132, 17);
            this.getRadioButton.TabIndex = 0;
            this.getRadioButton.TabStop = true;
            this.getRadioButton.Text = "Отримання науковця";
            this.getRadioButton.UseVisualStyleBackColor = true;
            this.getRadioButton.CheckedChanged += new System.EventHandler(this.GetRadioButton_CheckedChanged);
            // 
            // byDirectCheck
            // 
            this.byDirectCheck.AutoSize = true;
            this.byDirectCheck.Location = new System.Drawing.Point(47, 338);
            this.byDirectCheck.Name = "byDirectCheck";
            this.byDirectCheck.Size = new System.Drawing.Size(154, 17);
            this.byDirectCheck.TabIndex = 3;
            this.byDirectCheck.Text = "за напрямом досліджень";
            this.byDirectCheck.UseVisualStyleBackColor = true;
            this.byDirectCheck.CheckedChanged += new System.EventHandler(this.ByDirectCheck_CheckedChanged);
            // 
            // byIDCheck
            // 
            this.byIDCheck.AutoSize = true;
            this.byIDCheck.Location = new System.Drawing.Point(46, 361);
            this.byIDCheck.Name = "byIDCheck";
            this.byIDCheck.Size = new System.Drawing.Size(102, 17);
            this.byIDCheck.TabIndex = 4;
            this.byIDCheck.Text = "за ID науковця";
            this.byIDCheck.UseVisualStyleBackColor = true;
            this.byIDCheck.CheckedChanged += new System.EventHandler(this.ByIDCheck_CheckedChanged);
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(40, 407);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(161, 44);
            this.execButton.TabIndex = 5;
            this.execButton.Text = "Виконати запит";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // direcButton
            // 
            this.direcButton.Location = new System.Drawing.Point(40, 457);
            this.direcButton.Name = "direcButton";
            this.direcButton.Size = new System.Drawing.Size(161, 53);
            this.direcButton.TabIndex = 6;
            this.direcButton.Text = "Напрямки досліджень";
            this.direcButton.UseVisualStyleBackColor = true;
            this.direcButton.Click += new System.EventHandler(this.DirecButton_Click);
            // 
            // IDtextbox
            // 
            this.IDtextbox.Location = new System.Drawing.Point(231, 138);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(32, 20);
            this.IDtextbox.TabIndex = 7;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(153, 23);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 8;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(228, 121);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 9;
            this.IDlabel.Text = "ID";
            // 
            // midNameTextbox
            // 
            this.midNameTextbox.Location = new System.Drawing.Point(294, 23);
            this.midNameTextbox.Name = "midNameTextbox";
            this.midNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.midNameTextbox.TabIndex = 13;
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(17, 23);
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextbox.TabIndex = 14;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(708, 121);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(114, 13);
            this.directionLabel.TabIndex = 15;
            this.directionLabel.Text = "Напрям дослідження";
            // 
            // directDropDown
            // 
            this.directDropDown.FormattingEnabled = true;
            this.directDropDown.Location = new System.Drawing.Point(701, 137);
            this.directDropDown.Name = "directDropDown";
            this.directDropDown.Size = new System.Drawing.Size(146, 21);
            this.directDropDown.TabIndex = 16;
            this.directDropDown.Click += new System.EventHandler(this.DirectDropDown_Click);
            // 
            // artLabel
            // 
            this.artLabel.AutoSize = true;
            this.artLabel.Location = new System.Drawing.Point(863, 95);
            this.artLabel.Name = "artLabel";
            this.artLabel.Size = new System.Drawing.Size(56, 39);
            this.artLabel.TabIndex = 17;
            this.artLabel.Text = "Кількість \r\nнаукових\r\n статтей";
            // 
            // artclTextbox
            // 
            this.artclTextbox.Location = new System.Drawing.Point(853, 137);
            this.artclTextbox.Name = "artclTextbox";
            this.artclTextbox.Size = new System.Drawing.Size(78, 20);
            this.artclTextbox.TabIndex = 18;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(245, 197);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(599, 313);
            this.dataGridView.TabIndex = 19;
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.midNameTextbox);
            this.nameGroupBox.Controls.Add(this.nameTextbox);
            this.nameGroupBox.Controls.Add(this.surnameTextbox);
            this.nameGroupBox.Location = new System.Drawing.Point(269, 115);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(426, 51);
            this.nameGroupBox.TabIndex = 20;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "ПІБ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(948, 533);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.artclTextbox);
            this.Controls.Add(this.artLabel);
            this.Controls.Add(this.directDropDown);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.IDtextbox);
            this.Controls.Add(this.direcButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.byIDCheck);
            this.Controls.Add(this.byDirectCheck);
            this.Controls.Add(this.queryGroupBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.Name = "MainForm";
            this.Text = "Scientists [MySQL Version]";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.queryGroupBox.ResumeLayout(false);
            this.queryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton getRadioButton;
        private System.Windows.Forms.CheckBox byDirectCheck;
        private System.Windows.Forms.CheckBox byIDCheck;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button direcButton;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox midNameTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.ComboBox directDropDown;
        private System.Windows.Forms.Label artLabel;
        private System.Windows.Forms.TextBox artclTextbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox nameGroupBox;
    }
}

