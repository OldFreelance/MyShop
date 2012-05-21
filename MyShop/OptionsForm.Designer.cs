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
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtByerReceiptsTo = new System.Windows.Forms.TextBox();
            this.txtByerReceiptsFrom = new System.Windows.Forms.TextBox();
            this.txtPatienceTimeTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaxQueryLength = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(189, 260);
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
            this.cmbTimeStep.Location = new System.Drawing.Point(143, 11);
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
            this.toolTip1.SetToolTip(this.label1, "Во сколько раз время программы течет быстрее реального времени");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtByerReceiptsTo);
            this.groupBox1.Controls.Add(this.txtByerReceiptsFrom);
            this.groupBox1.Controls.Add(this.txtPatienceTimeTo);
            this.groupBox1.Controls.Add(this.label16);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Покупатели";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "в мин";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "в мин";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "в мин";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(294, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "руб";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "с";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "с";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Выручка от";
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
            // txtByerReceiptsTo
            // 
            this.txtByerReceiptsTo.Location = new System.Drawing.Point(223, 155);
            this.txtByerReceiptsTo.Name = "txtByerReceiptsTo";
            this.txtByerReceiptsTo.Size = new System.Drawing.Size(64, 20);
            this.txtByerReceiptsTo.TabIndex = 8;
            this.txtByerReceiptsTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtByerReceiptsFrom
            // 
            this.txtByerReceiptsFrom.Location = new System.Drawing.Point(131, 155);
            this.txtByerReceiptsFrom.Name = "txtByerReceiptsFrom";
            this.txtByerReceiptsFrom.Size = new System.Drawing.Size(61, 20);
            this.txtByerReceiptsFrom.TabIndex = 7;
            this.txtByerReceiptsFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtPatienceTimeTo
            // 
            this.txtPatienceTimeTo.Location = new System.Drawing.Point(223, 129);
            this.txtPatienceTimeTo.Name = "txtPatienceTimeTo";
            this.txtPatienceTimeTo.Size = new System.Drawing.Size(64, 20);
            this.txtPatienceTimeTo.TabIndex = 8;
            this.txtPatienceTimeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "до";
            // 
            // txtPatienceTimeFrom
            // 
            this.txtPatienceTimeFrom.Location = new System.Drawing.Point(131, 129);
            this.txtPatienceTimeFrom.Name = "txtPatienceTimeFrom";
            this.txtPatienceTimeFrom.Size = new System.Drawing.Size(61, 20);
            this.txtPatienceTimeFrom.TabIndex = 7;
            this.txtPatienceTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "до";
            // 
            // txtHandlingTimeTo
            // 
            this.txtHandlingTimeTo.Location = new System.Drawing.Point(223, 102);
            this.txtHandlingTimeTo.Name = "txtHandlingTimeTo";
            this.txtHandlingTimeTo.Size = new System.Drawing.Size(64, 20);
            this.txtHandlingTimeTo.TabIndex = 6;
            this.txtHandlingTimeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtHandlingTimeFrom
            // 
            this.txtHandlingTimeFrom.Location = new System.Drawing.Point(131, 102);
            this.txtHandlingTimeFrom.Name = "txtHandlingTimeFrom";
            this.txtHandlingTimeFrom.Size = new System.Drawing.Size(61, 20);
            this.txtHandlingTimeFrom.TabIndex = 5;
            this.txtHandlingTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
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
            this.txtByersInEvening.Location = new System.Drawing.Point(131, 75);
            this.txtByersInEvening.Name = "txtByersInEvening";
            this.txtByersInEvening.Size = new System.Drawing.Size(61, 20);
            this.txtByersInEvening.TabIndex = 4;
            this.txtByersInEvening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtByersInDay
            // 
            this.txtByersInDay.Location = new System.Drawing.Point(131, 45);
            this.txtByersInDay.Name = "txtByersInDay";
            this.txtByersInDay.Size = new System.Drawing.Size(61, 20);
            this.txtByersInDay.TabIndex = 3;
            this.txtByersInDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtByersInMorning
            // 
            this.txtByersInMorning.Location = new System.Drawing.Point(131, 17);
            this.txtByersInMorning.Name = "txtByersInMorning";
            this.txtByersInMorning.Size = new System.Drawing.Size(61, 20);
            this.txtByersInMorning.TabIndex = 2;
            this.txtByersInMorning.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
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
            this.chkDiscountDay.Location = new System.Drawing.Point(12, 266);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Макс длина очереди:";
            this.toolTip1.SetToolTip(this.label15, "Если все очереди привысят эту длину, будут открыта новая касса");
            // 
            // txtMaxQueryLength
            // 
            this.txtMaxQueryLength.Location = new System.Drawing.Point(143, 43);
            this.txtMaxQueryLength.Name = "txtMaxQueryLength";
            this.txtMaxQueryLength.Size = new System.Drawing.Size(61, 20);
            this.txtMaxQueryLength.TabIndex = 14;
            this.txtMaxQueryLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 287);
            this.Controls.Add(this.txtMaxQueryLength);
            this.Controls.Add(this.label15);
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaxQueryLength;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtByerReceiptsTo;
        private System.Windows.Forms.TextBox txtByerReceiptsFrom;
        private System.Windows.Forms.Label label16;
    }
}