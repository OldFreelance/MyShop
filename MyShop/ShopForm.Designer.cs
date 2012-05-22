namespace MyShop
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCashs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUnservised = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblReceipts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimeStep = new System.Windows.Forms.Label();
            this.lblByersInEvening = new System.Windows.Forms.Label();
            this.lblByersInDay = new System.Windows.Forms.Label();
            this.lblByersInMorning = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCashs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewCashs
            // 
            this.dataGridViewCashs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewCashs, 2);
            this.dataGridViewCashs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCashs.Location = new System.Drawing.Point(3, 123);
            this.dataGridViewCashs.Name = "dataGridViewCashs";
            this.dataGridViewCashs.ReadOnly = true;
            this.dataGridViewCashs.Size = new System.Drawing.Size(678, 336);
            this.dataGridViewCashs.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUnservised);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblReceipts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее";
            // 
            // lblUnservised
            // 
            this.lblUnservised.AutoSize = true;
            this.lblUnservised.Location = new System.Drawing.Point(109, 60);
            this.lblUnservised.Name = "lblUnservised";
            this.lblUnservised.Size = new System.Drawing.Size(13, 13);
            this.lblUnservised.TabIndex = 5;
            this.lblUnservised.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Необслуженные";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(109, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "0";
            // 
            // lblReceipts
            // 
            this.lblReceipts.AutoSize = true;
            this.lblReceipts.Location = new System.Drawing.Point(109, 40);
            this.lblReceipts.Name = "lblReceipts";
            this.lblReceipts.Size = new System.Drawing.Size(13, 13);
            this.lblReceipts.TabIndex = 2;
            this.lblReceipts.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выручка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTimeStep);
            this.groupBox2.Controls.Add(this.lblByersInEvening);
            this.groupBox2.Controls.Add(this.lblByersInDay);
            this.groupBox2.Controls.Add(this.lblByersInMorning);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(228, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // lblTimeStep
            // 
            this.lblTimeStep.AutoSize = true;
            this.lblTimeStep.Location = new System.Drawing.Point(88, 19);
            this.lblTimeStep.Name = "lblTimeStep";
            this.lblTimeStep.Size = new System.Drawing.Size(41, 13);
            this.lblTimeStep.TabIndex = 8;
            this.lblTimeStep.Text = "label12";
            // 
            // lblByersInEvening
            // 
            this.lblByersInEvening.AutoSize = true;
            this.lblByersInEvening.Location = new System.Drawing.Point(286, 60);
            this.lblByersInEvening.Name = "lblByersInEvening";
            this.lblByersInEvening.Size = new System.Drawing.Size(41, 13);
            this.lblByersInEvening.TabIndex = 7;
            this.lblByersInEvening.Text = "label11";
            // 
            // lblByersInDay
            // 
            this.lblByersInDay.AutoSize = true;
            this.lblByersInDay.Location = new System.Drawing.Point(286, 40);
            this.lblByersInDay.Name = "lblByersInDay";
            this.lblByersInDay.Size = new System.Drawing.Size(41, 13);
            this.lblByersInDay.TabIndex = 6;
            this.lblByersInDay.Text = "label10";
            // 
            // lblByersInMorning
            // 
            this.lblByersInMorning.AutoSize = true;
            this.lblByersInMorning.Location = new System.Drawing.Point(286, 20);
            this.lblByersInMorning.Name = "lblByersInMorning";
            this.lblByersInMorning.Size = new System.Drawing.Size(35, 13);
            this.lblByersInMorning.TabIndex = 5;
            this.lblByersInMorning.Text = "label9";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(369, 65);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Клиенты вечерм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Клиенты днем";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Клиенты утром";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Шаг времени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кассы:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "Имя";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StateName";
            this.Column1.HeaderText = "Состояние";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "QueryLength";
            this.Column2.HeaderText = "Длина очереди";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Receipts";
            this.Column3.HeaderText = "Выручка";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewCashs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblReceipts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblUnservised;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimeStep;
        private System.Windows.Forms.Label lblByersInEvening;
        private System.Windows.Forms.Label lblByersInDay;
        private System.Windows.Forms.Label lblByersInMorning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

