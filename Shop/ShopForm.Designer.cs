namespace Shop
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInShop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInCashers = new System.Windows.Forms.Label();
            this.labelInCaffe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dtpOpen = new System.Windows.Forms.DateTimePicker();
            this.dtpClose = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxShopTime = new System.Windows.Forms.TextBox();
            this.tbxCasher = new System.Windows.Forms.TextBox();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.tbxCaffe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxProbability = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbxMaxCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(93, 218);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "В зале";
            // 
            // labelInShop
            // 
            this.labelInShop.AutoSize = true;
            this.labelInShop.Location = new System.Drawing.Point(289, 24);
            this.labelInShop.Name = "labelInShop";
            this.labelInShop.Size = new System.Drawing.Size(35, 13);
            this.labelInShop.TabIndex = 2;
            this.labelInShop.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "На кассе";
            // 
            // labelInCashers
            // 
            this.labelInCashers.AutoSize = true;
            this.labelInCashers.Location = new System.Drawing.Point(289, 46);
            this.labelInCashers.Name = "labelInCashers";
            this.labelInCashers.Size = new System.Drawing.Size(35, 13);
            this.labelInCashers.TabIndex = 4;
            this.labelInCashers.Text = "label4";
            // 
            // labelInCaffe
            // 
            this.labelInCaffe.AutoSize = true;
            this.labelInCaffe.Location = new System.Drawing.Point(289, 69);
            this.labelInCaffe.Name = "labelInCaffe";
            this.labelInCaffe.Size = new System.Drawing.Size(35, 13);
            this.labelInCaffe.TabIndex = 6;
            this.labelInCaffe.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "В кафе";
            // 
            // timer
            // 
            this.timer.Interval = 350;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dtpOpen
            // 
            this.dtpOpen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOpen.Location = new System.Drawing.Point(94, 5);
            this.dtpOpen.Name = "dtpOpen";
            this.dtpOpen.Size = new System.Drawing.Size(99, 20);
            this.dtpOpen.TabIndex = 8;
            this.dtpOpen.Value = new System.DateTime(2016, 5, 26, 8, 0, 0, 0);
            // 
            // dtpClose
            // 
            this.dtpClose.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClose.Location = new System.Drawing.Point(94, 31);
            this.dtpClose.Name = "dtpClose";
            this.dtpClose.Size = new System.Drawing.Size(99, 20);
            this.dtpClose.TabIndex = 9;
            this.dtpClose.Value = new System.DateTime(2016, 5, 26, 22, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Открытие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Закрытие";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Время на кассе";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Кол-во касс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Время покупки";
            // 
            // tbxShopTime
            // 
            this.tbxShopTime.Location = new System.Drawing.Point(94, 57);
            this.tbxShopTime.Name = "tbxShopTime";
            this.tbxShopTime.Size = new System.Drawing.Size(100, 20);
            this.tbxShopTime.TabIndex = 13;
            // 
            // tbxCasher
            // 
            this.tbxCasher.Location = new System.Drawing.Point(94, 83);
            this.tbxCasher.Name = "tbxCasher";
            this.tbxCasher.Size = new System.Drawing.Size(100, 20);
            this.tbxCasher.TabIndex = 14;
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(94, 109);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxCount.TabIndex = 15;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.label11);
            this.panelSettings.Controls.Add(this.tbxMaxCount);
            this.panelSettings.Controls.Add(this.tbxCaffe);
            this.panelSettings.Controls.Add(this.label10);
            this.panelSettings.Controls.Add(this.tbxProbability);
            this.panelSettings.Controls.Add(this.label9);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.tbxCount);
            this.panelSettings.Controls.Add(this.label5);
            this.panelSettings.Controls.Add(this.tbxCasher);
            this.panelSettings.Controls.Add(this.dtpOpen);
            this.panelSettings.Controls.Add(this.tbxShopTime);
            this.panelSettings.Controls.Add(this.dtpClose);
            this.panelSettings.Controls.Add(this.label8);
            this.panelSettings.Controls.Add(this.btnStart);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.label7);
            this.panelSettings.Location = new System.Drawing.Point(12, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(203, 251);
            this.panelSettings.TabIndex = 16;
            // 
            // tbxCaffe
            // 
            this.tbxCaffe.Location = new System.Drawing.Point(94, 161);
            this.tbxCaffe.Name = "tbxCaffe";
            this.tbxCaffe.Size = new System.Drawing.Size(100, 20);
            this.tbxCaffe.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Время в кафе";
            // 
            // tbxProbability
            // 
            this.tbxProbability.Location = new System.Drawing.Point(94, 135);
            this.tbxProbability.Name = "tbxProbability";
            this.tbxProbability.Size = new System.Drawing.Size(100, 20);
            this.tbxProbability.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Вероятность";
            // 
            // trackBarTime
            // 
            this.trackBarTime.Location = new System.Drawing.Point(9, 308);
            this.trackBarTime.Maximum = 1000;
            this.trackBarTime.Minimum = 100;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(203, 45);
            this.trackBarTime.SmallChange = 100;
            this.trackBarTime.TabIndex = 7;
            this.trackBarTime.TickFrequency = 100;
            this.trackBarTime.Value = 100;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(105, 279);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbxMaxCount
            // 
            this.tbxMaxCount.Location = new System.Drawing.Point(94, 187);
            this.tbxMaxCount.Name = "tbxMaxCount";
            this.tbxMaxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxMaxCount.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Макс. кол-во";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 354);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.labelInCaffe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelInCashers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInShop);
            this.Controls.Add(this.label1);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInCashers;
        private System.Windows.Forms.Label labelInCaffe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker dtpOpen;
        private System.Windows.Forms.DateTimePicker dtpClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxShopTime;
        private System.Windows.Forms.TextBox tbxCasher;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbxProbability;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxCaffe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxMaxCount;
    }
}

