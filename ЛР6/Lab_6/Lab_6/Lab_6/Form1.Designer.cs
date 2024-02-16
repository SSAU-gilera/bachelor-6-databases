namespace Lab_6
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
            this.buttonIncident = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParticipant = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonAttitude = new System.Windows.Forms.Button();
            this.buttonDecision = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIncident
            // 
            this.buttonIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonIncident.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIncident.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIncident.Location = new System.Drawing.Point(171, 110);
            this.buttonIncident.Name = "buttonIncident";
            this.buttonIncident.Size = new System.Drawing.Size(865, 74);
            this.buttonIncident.TabIndex = 8;
            this.buttonIncident.Text = "Происшествие";
            this.buttonIncident.UseVisualStyleBackColor = false;
            this.buttonIncident.Click += new System.EventHandler(this.buttonIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(165, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите таблицу базы данных \"Регистрация происшествий\":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonParticipant
            // 
            this.buttonParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonParticipant.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonParticipant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonParticipant.Location = new System.Drawing.Point(171, 214);
            this.buttonParticipant.Name = "buttonParticipant";
            this.buttonParticipant.Size = new System.Drawing.Size(865, 74);
            this.buttonParticipant.TabIndex = 9;
            this.buttonParticipant.Text = "Участник происшествия";
            this.buttonParticipant.UseVisualStyleBackColor = false;
            this.buttonParticipant.Click += new System.EventHandler(this.buttonParticipant_Click);
            // 
            // buttonPI
            // 
            this.buttonPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPI.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPI.Location = new System.Drawing.Point(171, 325);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(865, 74);
            this.buttonPI.TabIndex = 10;
            this.buttonPI.Text = "Участник происшествия - происшествие";
            this.buttonPI.UseVisualStyleBackColor = false;
            this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // buttonAttitude
            // 
            this.buttonAttitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAttitude.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAttitude.ForeColor = System.Drawing.Color.Black;
            this.buttonAttitude.Location = new System.Drawing.Point(171, 436);
            this.buttonAttitude.Name = "buttonAttitude";
            this.buttonAttitude.Size = new System.Drawing.Size(865, 74);
            this.buttonAttitude.TabIndex = 11;
            this.buttonAttitude.Text = "Отношение участника к происшествию";
            this.buttonAttitude.UseVisualStyleBackColor = false;
            this.buttonAttitude.Click += new System.EventHandler(this.buttonAttitude_Click);
            // 
            // buttonDecision
            // 
            this.buttonDecision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDecision.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDecision.Location = new System.Drawing.Point(171, 545);
            this.buttonDecision.Name = "buttonDecision";
            this.buttonDecision.Size = new System.Drawing.Size(865, 74);
            this.buttonDecision.TabIndex = 12;
            this.buttonDecision.Text = "Решение по происшествию";
            this.buttonDecision.UseVisualStyleBackColor = false;
            this.buttonDecision.Click += new System.EventHandler(this.buttonDecision_Click);
            // 
            // buttonType
            // 
            this.buttonType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonType.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonType.Location = new System.Drawing.Point(171, 650);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(865, 74);
            this.buttonType.TabIndex = 13;
            this.buttonType.Text = "Тип происшествия";
            this.buttonType.UseVisualStyleBackColor = false;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 762);
            this.Controls.Add(this.buttonType);
            this.Controls.Add(this.buttonDecision);
            this.Controls.Add(this.buttonAttitude);
            this.Controls.Add(this.buttonPI);
            this.Controls.Add(this.buttonParticipant);
            this.Controls.Add(this.buttonIncident);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParticipant;
        private System.Windows.Forms.Button buttonPI;
        private System.Windows.Forms.Button buttonAttitude;
        private System.Windows.Forms.Button buttonDecision;
        private System.Windows.Forms.Button buttonType;
    }
}

