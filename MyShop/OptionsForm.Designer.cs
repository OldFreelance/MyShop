namespace MyShop
{
    partial class OptionsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbTimeStep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatienceTimeTo = new System.Windows.Forms.TextBox();
            this.txtPatienceTimeFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHandlingTimeTo = new System.Windows.Forms.TextBox();
            this.txtHandlingTimeFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtByersInEvening = new System.Windows.Forms.TextBox();
            this.txtByersInDay = new System.Windows.Forms.TextBox();
            this.txtByersInMorning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDiscountDay = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 208);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbTimeStep
            // 
            this.cmbTimeStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeStep.FormattingEnabled = true;
            this.cmbTimeStep.Items.AddRange(new object[] {
            "1",
            "10",
            "30",
            "60"});
            this.cmbTimeStep.Location = new System.Drawing.Point(151, 12);
            this.cmbTimeStep.Name = "cmbTimeStep";
            this.cmbTimeStep.Size = new System.Drawing.Size(121, 21);
            this.cmbTimeStep.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шаг работы програмы:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPatienceTimeTo);
            this.groupBox1.Controls.Add(this.txtPatienceTimeFrom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHandlingTimeTo);
            this.groupBox1.Controls.Add(this.txtHandlingTimeFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtByersInEvening);
            this.groupBox1.Controls.Add(this.txtByersInDay);
            this.groupBox1.Controls.Add(this.txtByersInMorning);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Покупатели";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "в мин";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "в мин";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "в мин";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "с";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "с";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Макс ожидание от";
            this.toolTip1.SetToolTip(this.label8, "Сколько времени покупатель может отстоять в очереди");
            // 
            // txtPatienceTimeTo
            // 
            this.txtPatienceTimeTo.Location = new System.Drawing.Point(204, 129);
            this.txtPatienceTimeTo.Name = "txtPatienceTimeTo";
            this.txtPatienceTimeTo.Size = new System.Drawing.Size(64, 20);
            this.txtPatienceTimeTo.TabIndex = 8;
            this.txtPatienceTimeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatienceTimeTo_KeyPress);
            // 
            // txtPatienceTimeFrom
            // 
            this.txtPatienceTimeFrom.Location = new System.Drawing.Point(112, 129);
            this.txtPatienceTimeFrom.Name = "txtPatienceTimeFrom";
            this.txtPatienceTimeFrom.Size = new System.Drawing.Size(61, 20);
            this.txtPatienceTimeFrom.TabIndex = 7;
            this.txtPatienceTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatienceTimeFrom_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "до";
            // 
            // txtHandlingTimeTo
            // 
            this.txtHandlingTimeTo.Location = new System.Drawing.Point(204, 102);
            this.txtHandlingTimeTo.Name = "txtHandlingTimeTo";
            this.txtHandlingTimeTo.Size = new System.Drawing.Size(64, 20);
            this.txtHandlingTimeTo.TabIndex = 6;
            this.txtHandlingTimeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandlingTimeTo_KeyPress);
            // 
            // txtHandlingTimeFrom
            // 
            this.txtHandlingTimeFrom.Location = new System.Drawing.Point(112, 102);
            this.txtHandlingTimeFrom.Name = "txtHandlingTimeFrom";
            this.txtHandlingTimeFrom.Size = new System.Drawing.Size(61, 20);
            this.txtHandlingTimeFrom.TabIndex = 5;
            this.txtHandlingTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandlingTimeFrom_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Обслуживание от ";
            // 
            // txtByersInEvening
            // 
            this.txtByersInEvening.Location = new System.Drawing.Point(112, 75);
            this.txtByersInEvening.Name = "txtByersInEvening";
            this.txtByersInEvening.Size = new System.Drawing.Size(61, 20);
            this.txtByersInEvening.TabIndex = 4;
            this.txtByersInEvening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByersInEvening_KeyPress);
            // 
            // txtByersInDay
            // 
            this.txtByersInDay.Location = new System.Drawing.Point(112, 45);
            this.txtByersInDay.Name = "txtByersInDay";
            this.txtByersInDay.Size = new System.Drawing.Size(61, 20);
            this.txtByersInDay.TabIndex = 3;
            this.txtByersInDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByersInDay_KeyPress);
            // 
            // txtByersInMorning
            // 
            this.txtByersInMorning.Location = new System.Drawing.Point(112, 17);
            this.txtByersInMorning.Name = "txtByersInMorning";
            this.txtByersInMorning.Size = new System.Drawing.Size(61, 20);
            this.txtByersInMorning.TabIndex = 2;
            this.txtByersInMorning.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByersInMorning_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вечером:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Днем:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Утром:";
            // 
            // chkDiscountDay
            // 
            this.chkDiscountDay.AutoSize = true;
            this.chkDiscountDay.Location = new System.Drawing.Point(12, 212);
            this.chkDiscountDay.Name = "chkDiscountDay";
            this.chkDiscountDay.Size = new System.Drawing.Size(92, 17);
            this.chkDiscountDay.TabIndex = 9;
            this.chkDiscountDay.Text = "День скидок";
            this.chkDiscountDay.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(279, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "в сек";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 238);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkDiscountDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTimeStep);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbTimeStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtByersInEvening;
        private System.Windows.Forms.TextBox txtByersInDay;
        private System.Windows.Forms.TextBox txtByersInMorning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHandlingTimeFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHandlingTimeTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatienceTimeTo;
        private System.Windows.Forms.TextBox txtPatienceTimeFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkDiscountDay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}