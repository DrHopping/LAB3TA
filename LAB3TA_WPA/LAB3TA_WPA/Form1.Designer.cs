namespace LAB3TA_WPA
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddKeyText = new System.Windows.Forms.TextBox();
            this.AddValueText = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveKeyText = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditKeyText = new System.Windows.Forms.TextBox();
            this.EditValueText = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindKeyText = new System.Windows.Forms.TextBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(356, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.Size = new System.Drawing.Size(302, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 50;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 250;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddKeyText
            // 
            this.AddKeyText.Location = new System.Drawing.Point(93, 41);
            this.AddKeyText.Name = "AddKeyText";
            this.AddKeyText.Size = new System.Drawing.Size(100, 20);
            this.AddKeyText.TabIndex = 2;
            // 
            // AddValueText
            // 
            this.AddValueText.Location = new System.Drawing.Point(199, 41);
            this.AddValueText.Name = "AddValueText";
            this.AddValueText.Size = new System.Drawing.Size(100, 20);
            this.AddValueText.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 154);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveKeyText
            // 
            this.RemoveKeyText.Location = new System.Drawing.Point(93, 156);
            this.RemoveKeyText.Name = "RemoveKeyText";
            this.RemoveKeyText.Size = new System.Drawing.Size(100, 20);
            this.RemoveKeyText.TabIndex = 5;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(130, 9);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(25, 13);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "Key";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(232, 9);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 8;
            this.ValueLabel.Text = "Value";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 96);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditKeyText
            // 
            this.EditKeyText.Location = new System.Drawing.Point(93, 98);
            this.EditKeyText.Name = "EditKeyText";
            this.EditKeyText.Size = new System.Drawing.Size(100, 20);
            this.EditKeyText.TabIndex = 10;
            // 
            // EditValueText
            // 
            this.EditValueText.Location = new System.Drawing.Point(199, 98);
            this.EditValueText.Name = "EditValueText";
            this.EditValueText.Size = new System.Drawing.Size(100, 20);
            this.EditValueText.TabIndex = 11;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(12, 212);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 12;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindKeyText
            // 
            this.FindKeyText.Location = new System.Drawing.Point(93, 214);
            this.FindKeyText.Name = "FindKeyText";
            this.FindKeyText.Size = new System.Drawing.Size(100, 20);
            this.FindKeyText.TabIndex = 13;
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(12, 265);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(287, 23);
            this.RandomButton.TabIndex = 14;
            this.RandomButton.Text = "Random(10)";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 295);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(287, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 325);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(287, 23);
            this.LoadButton.TabIndex = 16;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 362);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.FindKeyText);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.EditValueText);
            this.Controls.Add(this.EditKeyText);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.RemoveKeyText);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddValueText);
            this.Controls.Add(this.AddKeyText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TextBox AddKeyText;
        private System.Windows.Forms.TextBox AddValueText;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox RemoveKeyText;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox EditKeyText;
        private System.Windows.Forms.TextBox EditValueText;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindKeyText;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

