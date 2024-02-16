namespace Lab_6
{
    partial class Type
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOUTPUT = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.tabPageINSERT = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1Insert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2Insert = new System.Windows.Forms.TextBox();
            this.tabPageUPDATE = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2Update = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3Update = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1Update = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageDELETE = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1Delete = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageOUTPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.tabPageINSERT.SuspendLayout();
            this.tabPageUPDATE.SuspendLayout();
            this.tabPageDELETE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(12, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(246, 40);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOUTPUT);
            this.tabControl1.Controls.Add(this.tabPageINSERT);
            this.tabControl1.Controls.Add(this.tabPageUPDATE);
            this.tabControl1.Controls.Add(this.tabPageDELETE);
            this.tabControl1.Location = new System.Drawing.Point(3, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 689);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPageOUTPUT
            // 
            this.tabPageOUTPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageOUTPUT.Controls.Add(this.buttonUpdate);
            this.tabPageOUTPUT.Controls.Add(this.dataGridViewOutput);
            this.tabPageOUTPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageOUTPUT.Location = new System.Drawing.Point(4, 25);
            this.tabPageOUTPUT.Name = "tabPageOUTPUT";
            this.tabPageOUTPUT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOUTPUT.Size = new System.Drawing.Size(1217, 660);
            this.tabPageOUTPUT.TabIndex = 0;
            this.tabPageOUTPUT.Text = "SELECT";
            this.tabPageOUTPUT.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdate.Location = new System.Drawing.Point(36, 580);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(1161, 53);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.AllowUserToAddRows = false;
            this.dataGridViewOutput.AllowUserToDeleteRows = false;
            this.dataGridViewOutput.AllowUserToResizeColumns = false;
            this.dataGridViewOutput.AllowUserToResizeRows = false;
            this.dataGridViewOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutput.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOutput.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewOutput.Location = new System.Drawing.Point(-1, -1);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewOutput.RowTemplate.Height = 24;
            this.dataGridViewOutput.Size = new System.Drawing.Size(1217, 566);
            this.dataGridViewOutput.TabIndex = 31;
            // 
            // tabPageINSERT
            // 
            this.tabPageINSERT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageINSERT.Controls.Add(this.buttonAdd);
            this.tabPageINSERT.Controls.Add(this.label4);
            this.tabPageINSERT.Controls.Add(this.textBox1Insert);
            this.tabPageINSERT.Controls.Add(this.label1);
            this.tabPageINSERT.Controls.Add(this.textBox2Insert);
            this.tabPageINSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageINSERT.Location = new System.Drawing.Point(4, 25);
            this.tabPageINSERT.Name = "tabPageINSERT";
            this.tabPageINSERT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageINSERT.Size = new System.Drawing.Size(1217, 660);
            this.tabPageINSERT.TabIndex = 1;
            this.tabPageINSERT.Text = "INSERT";
            this.tabPageINSERT.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(36, 580);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(1161, 53);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Введите код типа происшествия:";
            // 
            // textBox1Insert
            // 
            this.textBox1Insert.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Insert.Location = new System.Drawing.Point(708, 164);
            this.textBox1Insert.Name = "textBox1Insert";
            this.textBox1Insert.Size = new System.Drawing.Size(406, 31);
            this.textBox1Insert.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Введите название типа происшествия:\r\n";
            // 
            // textBox2Insert
            // 
            this.textBox2Insert.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Insert.Location = new System.Drawing.Point(708, 354);
            this.textBox2Insert.Name = "textBox2Insert";
            this.textBox2Insert.Size = new System.Drawing.Size(406, 31);
            this.textBox2Insert.TabIndex = 26;
            // 
            // tabPageUPDATE
            // 
            this.tabPageUPDATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageUPDATE.Controls.Add(this.label2);
            this.tabPageUPDATE.Controls.Add(this.textBox2Update);
            this.tabPageUPDATE.Controls.Add(this.label3);
            this.tabPageUPDATE.Controls.Add(this.textBox3Update);
            this.tabPageUPDATE.Controls.Add(this.label7);
            this.tabPageUPDATE.Controls.Add(this.textBox1Update);
            this.tabPageUPDATE.Controls.Add(this.buttonChange);
            this.tabPageUPDATE.Controls.Add(this.label8);
            this.tabPageUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageUPDATE.Location = new System.Drawing.Point(4, 25);
            this.tabPageUPDATE.Name = "tabPageUPDATE";
            this.tabPageUPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUPDATE.Size = new System.Drawing.Size(1217, 660);
            this.tabPageUPDATE.TabIndex = 2;
            this.tabPageUPDATE.Text = "UPDATE";
            this.tabPageUPDATE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Введите код типа происшествия:";
            // 
            // textBox2Update
            // 
            this.textBox2Update.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Update.Location = new System.Drawing.Point(716, 289);
            this.textBox2Update.Name = "textBox2Update";
            this.textBox2Update.Size = new System.Drawing.Size(406, 31);
            this.textBox2Update.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(89, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Введите название типа происшествия:\r\n";
            // 
            // textBox3Update
            // 
            this.textBox3Update.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3Update.Location = new System.Drawing.Point(716, 438);
            this.textBox3Update.Name = "textBox3Update";
            this.textBox3Update.Size = new System.Drawing.Size(406, 31);
            this.textBox3Update.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(89, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Введите исходный код типа происшествия:";
            // 
            // textBox1Update
            // 
            this.textBox1Update.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Update.Location = new System.Drawing.Point(716, 81);
            this.textBox1Update.Name = "textBox1Update";
            this.textBox1Update.Size = new System.Drawing.Size(406, 31);
            this.textBox1Update.TabIndex = 51;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonChange.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChange.Location = new System.Drawing.Point(36, 580);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(1161, 53);
            this.buttonChange.TabIndex = 50;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(470, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Введите новые данные:";
            // 
            // tabPageDELETE
            // 
            this.tabPageDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageDELETE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageDELETE.Controls.Add(this.label6);
            this.tabPageDELETE.Controls.Add(this.buttonDelete);
            this.tabPageDELETE.Controls.Add(this.textBox1Delete);
            this.tabPageDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageDELETE.Location = new System.Drawing.Point(4, 25);
            this.tabPageDELETE.Name = "tabPageDELETE";
            this.tabPageDELETE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDELETE.Size = new System.Drawing.Size(1217, 660);
            this.tabPageDELETE.TabIndex = 3;
            this.tabPageDELETE.Text = "DELETE";
            this.tabPageDELETE.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(110, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Введите код типа происшествия:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(36, 580);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(1161, 53);
            this.buttonDelete.TabIndex = 53;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1Delete
            // 
            this.textBox1Delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Delete.Location = new System.Drawing.Point(720, 259);
            this.textBox1Delete.Name = "textBox1Delete";
            this.textBox1Delete.Size = new System.Drawing.Size(406, 31);
            this.textBox1Delete.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код типа происшествия ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название типа происшествия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 762);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControl1);
            this.Name = "Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type";
            this.tabControl1.ResumeLayout(false);
            this.tabPageOUTPUT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.tabPageINSERT.ResumeLayout(false);
            this.tabPageINSERT.PerformLayout();
            this.tabPageUPDATE.ResumeLayout(false);
            this.tabPageUPDATE.PerformLayout();
            this.tabPageDELETE.ResumeLayout(false);
            this.tabPageDELETE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOUTPUT;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabPage tabPageINSERT;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2Insert;
        private System.Windows.Forms.TabPage tabPageUPDATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3Update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1Update;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageDELETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1Delete;
    }
}