namespace Lab2
{
    partial class ChildForm
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.getRadioButton = new System.Windows.Forms.RadioButton();
            this.execButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.queryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(43, 54);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(111, 118);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(215, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 13);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.deleteRadioButton);
            this.queryGroupBox.Controls.Add(this.updateRadioButton);
            this.queryGroupBox.Controls.Add(this.addRadioButton);
            this.queryGroupBox.Controls.Add(this.getRadioButton);
            this.queryGroupBox.Location = new System.Drawing.Point(43, 222);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(140, 127);
            this.queryGroupBox.TabIndex = 2;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Text = "groupBox1";
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(6, 89);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(67, 17);
            this.deleteRadioButton.TabIndex = 3;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "DELETE";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(7, 66);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(69, 17);
            this.updateRadioButton.TabIndex = 2;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "UPDATE";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(6, 43);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(65, 17);
            this.addRadioButton.TabIndex = 1;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "INSERT";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // getRadioButton
            // 
            this.getRadioButton.AutoSize = true;
            this.getRadioButton.Location = new System.Drawing.Point(7, 20);
            this.getRadioButton.Name = "getRadioButton";
            this.getRadioButton.Size = new System.Drawing.Size(66, 17);
            this.getRadioButton.TabIndex = 0;
            this.getRadioButton.TabStop = true;
            this.getRadioButton.Text = "SELECT";
            this.getRadioButton.UseVisualStyleBackColor = true;
            this.getRadioButton.CheckedChanged += new System.EventHandler(this.GetRadioButton_CheckedChanged);
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(43, 383);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(140, 49);
            this.execButton.TabIndex = 3;
            this.execButton.Text = "Excute";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(43, 456);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 45);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to Main";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(243, 159);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 5;
            this.IDlabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(348, 159);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(460, 159);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(60, 13);
            this.descLabel.TabIndex = 7;
            this.descLabel.Text = "Description";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(209, 184);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(315, 184);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(428, 184);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(100, 20);
            this.descTextBox.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(209, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(460, 279);
            this.dataGridView.TabIndex = 11;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 513);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.queryGroupBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChildFrom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.queryGroupBox.ResumeLayout(false);
            this.queryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}