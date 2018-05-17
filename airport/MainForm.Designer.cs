namespace airport
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyCompanyPanel = new System.Windows.Forms.GroupBox();
            this.BtnOpenPlaneShop = new System.Windows.Forms.Button();
            this.BtnReturnPlane = new System.Windows.Forms.Button();
            this.BtnOpenFlightList = new System.Windows.Forms.Button();
            this.BtnSellPlane = new System.Windows.Forms.Button();
            this.TextPlaneFlight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridMyPlanes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ShopPanel = new System.Windows.Forms.GroupBox();
            this.BtnCanselBuy = new System.Windows.Forms.Button();
            this.GridPlaneInfo = new System.Windows.Forms.DataGridView();
            this.BtnLeasingPlane = new System.Windows.Forms.Button();
            this.BtnLeasePlane = new System.Windows.Forms.Button();
            this.BtnBuyPlane = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GridAvaliablePlanes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.FlightPanel = new System.Windows.Forms.GroupBox();
            this.GridFlightInfo = new System.Windows.Forms.DataGridView();
            this.BtnCanselSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSelectFlight = new System.Windows.Forms.Button();
            this.GridAvaliableFlights = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnXXRun = new System.Windows.Forms.Button();
            this.BtnXRun = new System.Windows.Forms.Button();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextHours = new System.Windows.Forms.TextBox();
            this.TextMinutes = new System.Windows.Forms.TextBox();
            this.TextDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MyCompanyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMyPlanes)).BeginInit();
            this.ShopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPlaneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvaliablePlanes)).BeginInit();
            this.FlightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFlightInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvaliableFlights)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyCompanyPanel
            // 
            this.MyCompanyPanel.Controls.Add(this.BtnOpenPlaneShop);
            this.MyCompanyPanel.Controls.Add(this.BtnReturnPlane);
            this.MyCompanyPanel.Controls.Add(this.BtnOpenFlightList);
            this.MyCompanyPanel.Controls.Add(this.BtnSellPlane);
            this.MyCompanyPanel.Controls.Add(this.TextPlaneFlight);
            this.MyCompanyPanel.Controls.Add(this.label2);
            this.MyCompanyPanel.Controls.Add(this.GridMyPlanes);
            this.MyCompanyPanel.Controls.Add(this.label1);
            this.MyCompanyPanel.Enabled = false;
            this.MyCompanyPanel.Location = new System.Drawing.Point(349, 111);
            this.MyCompanyPanel.Name = "MyCompanyPanel";
            this.MyCompanyPanel.Size = new System.Drawing.Size(638, 465);
            this.MyCompanyPanel.TabIndex = 0;
            this.MyCompanyPanel.TabStop = false;
            this.MyCompanyPanel.Text = "Моя компания";
            // 
            // BtnOpenPlaneShop
            // 
            this.BtnOpenPlaneShop.Location = new System.Drawing.Point(6, 29);
            this.BtnOpenPlaneShop.Name = "BtnOpenPlaneShop";
            this.BtnOpenPlaneShop.Size = new System.Drawing.Size(155, 37);
            this.BtnOpenPlaneShop.TabIndex = 6;
            this.BtnOpenPlaneShop.Text = "Купить/арендовать самолет";
            this.BtnOpenPlaneShop.UseVisualStyleBackColor = true;
            // 
            // BtnReturnPlane
            // 
            this.BtnReturnPlane.Location = new System.Drawing.Point(6, 115);
            this.BtnReturnPlane.Name = "BtnReturnPlane";
            this.BtnReturnPlane.Size = new System.Drawing.Size(155, 37);
            this.BtnReturnPlane.TabIndex = 5;
            this.BtnReturnPlane.Text = "Вернуть самолет";
            this.BtnReturnPlane.UseVisualStyleBackColor = true;
            // 
            // BtnOpenFlightList
            // 
            this.BtnOpenFlightList.Location = new System.Drawing.Point(167, 29);
            this.BtnOpenFlightList.Name = "BtnOpenFlightList";
            this.BtnOpenFlightList.Size = new System.Drawing.Size(155, 37);
            this.BtnOpenFlightList.TabIndex = 4;
            this.BtnOpenFlightList.Text = "Назначить рейс";
            this.BtnOpenFlightList.UseVisualStyleBackColor = true;
            // 
            // BtnSellPlane
            // 
            this.BtnSellPlane.Location = new System.Drawing.Point(6, 72);
            this.BtnSellPlane.Name = "BtnSellPlane";
            this.BtnSellPlane.Size = new System.Drawing.Size(155, 37);
            this.BtnSellPlane.TabIndex = 3;
            this.BtnSellPlane.Text = "Продать самолет";
            this.BtnSellPlane.UseVisualStyleBackColor = true;
            // 
            // TextPlaneFlight
            // 
            this.TextPlaneFlight.Location = new System.Drawing.Point(6, 174);
            this.TextPlaneFlight.Multiline = true;
            this.TextPlaneFlight.Name = "TextPlaneFlight";
            this.TextPlaneFlight.Size = new System.Drawing.Size(316, 284);
            this.TextPlaneFlight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание связанных рейсов";
            // 
            // GridMyPlanes
            // 
            this.GridMyPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMyPlanes.Location = new System.Drawing.Point(328, 29);
            this.GridMyPlanes.Name = "GridMyPlanes";
            this.GridMyPlanes.Size = new System.Drawing.Size(304, 429);
            this.GridMyPlanes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои самолеты";
            // 
            // ShopPanel
            // 
            this.ShopPanel.Controls.Add(this.BtnCanselBuy);
            this.ShopPanel.Controls.Add(this.GridPlaneInfo);
            this.ShopPanel.Controls.Add(this.BtnLeasingPlane);
            this.ShopPanel.Controls.Add(this.BtnLeasePlane);
            this.ShopPanel.Controls.Add(this.BtnBuyPlane);
            this.ShopPanel.Controls.Add(this.label5);
            this.ShopPanel.Controls.Add(this.GridAvaliablePlanes);
            this.ShopPanel.Controls.Add(this.label4);
            this.ShopPanel.Enabled = false;
            this.ShopPanel.Location = new System.Drawing.Point(12, 12);
            this.ShopPanel.Name = "ShopPanel";
            this.ShopPanel.Size = new System.Drawing.Size(331, 564);
            this.ShopPanel.TabIndex = 1;
            this.ShopPanel.TabStop = false;
            this.ShopPanel.Text = "Покупка самолетов";
            // 
            // BtnCanselBuy
            // 
            this.BtnCanselBuy.Location = new System.Drawing.Point(168, 521);
            this.BtnCanselBuy.Name = "BtnCanselBuy";
            this.BtnCanselBuy.Size = new System.Drawing.Size(157, 37);
            this.BtnCanselBuy.TabIndex = 8;
            this.BtnCanselBuy.Text = "Отмена";
            this.BtnCanselBuy.UseVisualStyleBackColor = true;
            // 
            // GridPlaneInfo
            // 
            this.GridPlaneInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPlaneInfo.Location = new System.Drawing.Point(6, 290);
            this.GridPlaneInfo.Name = "GridPlaneInfo";
            this.GridPlaneInfo.Size = new System.Drawing.Size(319, 184);
            this.GridPlaneInfo.TabIndex = 7;
            // 
            // BtnLeasingPlane
            // 
            this.BtnLeasingPlane.Location = new System.Drawing.Point(168, 480);
            this.BtnLeasingPlane.Name = "BtnLeasingPlane";
            this.BtnLeasingPlane.Size = new System.Drawing.Size(157, 37);
            this.BtnLeasingPlane.TabIndex = 6;
            this.BtnLeasingPlane.Text = "Лизинг";
            this.BtnLeasingPlane.UseVisualStyleBackColor = true;
            // 
            // BtnLeasePlane
            // 
            this.BtnLeasePlane.Location = new System.Drawing.Point(6, 480);
            this.BtnLeasePlane.Name = "BtnLeasePlane";
            this.BtnLeasePlane.Size = new System.Drawing.Size(157, 37);
            this.BtnLeasePlane.TabIndex = 5;
            this.BtnLeasePlane.Text = "Аренда";
            this.BtnLeasePlane.UseVisualStyleBackColor = true;
            // 
            // BtnBuyPlane
            // 
            this.BtnBuyPlane.Location = new System.Drawing.Point(6, 521);
            this.BtnBuyPlane.Name = "BtnBuyPlane";
            this.BtnBuyPlane.Size = new System.Drawing.Size(157, 37);
            this.BtnBuyPlane.TabIndex = 4;
            this.BtnBuyPlane.Text = "Купить";
            this.BtnBuyPlane.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Характеристика";
            // 
            // GridAvaliablePlanes
            // 
            this.GridAvaliablePlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAvaliablePlanes.Location = new System.Drawing.Point(6, 32);
            this.GridAvaliablePlanes.Name = "GridAvaliablePlanes";
            this.GridAvaliablePlanes.Size = new System.Drawing.Size(319, 239);
            this.GridAvaliablePlanes.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Самолёты";
            // 
            // FlightPanel
            // 
            this.FlightPanel.Controls.Add(this.GridFlightInfo);
            this.FlightPanel.Controls.Add(this.BtnCanselSelect);
            this.FlightPanel.Controls.Add(this.label7);
            this.FlightPanel.Controls.Add(this.BtnSelectFlight);
            this.FlightPanel.Controls.Add(this.GridAvaliableFlights);
            this.FlightPanel.Controls.Add(this.label6);
            this.FlightPanel.Enabled = false;
            this.FlightPanel.Location = new System.Drawing.Point(993, 12);
            this.FlightPanel.Name = "FlightPanel";
            this.FlightPanel.Size = new System.Drawing.Size(331, 564);
            this.FlightPanel.TabIndex = 2;
            this.FlightPanel.TabStop = false;
            this.FlightPanel.Text = "Назначение рейсов";
            // 
            // GridFlightInfo
            // 
            this.GridFlightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFlightInfo.Location = new System.Drawing.Point(6, 331);
            this.GridFlightInfo.Name = "GridFlightInfo";
            this.GridFlightInfo.Size = new System.Drawing.Size(319, 184);
            this.GridFlightInfo.TabIndex = 7;
            // 
            // BtnCanselSelect
            // 
            this.BtnCanselSelect.Location = new System.Drawing.Point(170, 521);
            this.BtnCanselSelect.Name = "BtnCanselSelect";
            this.BtnCanselSelect.Size = new System.Drawing.Size(155, 37);
            this.BtnCanselSelect.TabIndex = 6;
            this.BtnCanselSelect.Text = "Отмена";
            this.BtnCanselSelect.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Описание рейса";
            // 
            // BtnSelectFlight
            // 
            this.BtnSelectFlight.Location = new System.Drawing.Point(6, 521);
            this.BtnSelectFlight.Name = "BtnSelectFlight";
            this.BtnSelectFlight.Size = new System.Drawing.Size(155, 37);
            this.BtnSelectFlight.TabIndex = 3;
            this.BtnSelectFlight.Text = "Назначить рейс выбранному самолету";
            this.BtnSelectFlight.UseVisualStyleBackColor = true;
            // 
            // GridAvaliableFlights
            // 
            this.GridAvaliableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAvaliableFlights.Location = new System.Drawing.Point(6, 32);
            this.GridAvaliableFlights.Name = "GridAvaliableFlights";
            this.GridAvaliableFlights.Size = new System.Drawing.Size(319, 280);
            this.GridAvaliableFlights.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Доступные рейсы";
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnExit);
            this.MainPanel.Controls.Add(this.BtnHelp);
            this.MainPanel.Controls.Add(this.BtnRestart);
            this.MainPanel.Controls.Add(this.BtnStartGame);
            this.MainPanel.Controls.Add(this.BtnXXRun);
            this.MainPanel.Controls.Add(this.BtnXRun);
            this.MainPanel.Controls.Add(this.BtnRun);
            this.MainPanel.Controls.Add(this.BtnPause);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.TextHours);
            this.MainPanel.Controls.Add(this.TextMinutes);
            this.MainPanel.Controls.Add(this.TextDays);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.TextMoney);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Location = new System.Drawing.Point(349, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(637, 112);
            this.MainPanel.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Enabled = false;
            this.BtnExit.Location = new System.Drawing.Point(483, 8);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(155, 37);
            this.BtnExit.TabIndex = 35;
            this.BtnExit.Text = "Завершить игру";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(322, 8);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(155, 37);
            this.BtnHelp.TabIndex = 22;
            this.BtnHelp.Text = "Помощь";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnRestart
            // 
            this.BtnRestart.Enabled = false;
            this.BtnRestart.Location = new System.Drawing.Point(161, 8);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(155, 37);
            this.BtnRestart.TabIndex = 24;
            this.BtnRestart.Text = "Перезапустить игру";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Location = new System.Drawing.Point(0, 8);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(155, 37);
            this.BtnStartGame.TabIndex = 34;
            this.BtnStartGame.Text = "Начать игру";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnXXRun
            // 
            this.BtnXXRun.Enabled = false;
            this.BtnXXRun.Location = new System.Drawing.Point(571, 57);
            this.BtnXXRun.Name = "BtnXXRun";
            this.BtnXXRun.Size = new System.Drawing.Size(48, 48);
            this.BtnXXRun.TabIndex = 33;
            this.BtnXXRun.Text = "button8";
            this.BtnXXRun.UseVisualStyleBackColor = true;
            this.BtnXXRun.Click += new System.EventHandler(this.BtnXXRun_Click);
            // 
            // BtnXRun
            // 
            this.BtnXRun.Enabled = false;
            this.BtnXRun.Location = new System.Drawing.Point(517, 57);
            this.BtnXRun.Name = "BtnXRun";
            this.BtnXRun.Size = new System.Drawing.Size(48, 48);
            this.BtnXRun.TabIndex = 32;
            this.BtnXRun.Text = "button7";
            this.BtnXRun.UseVisualStyleBackColor = true;
            this.BtnXRun.Click += new System.EventHandler(this.BtnXRun_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Enabled = false;
            this.BtnRun.Location = new System.Drawing.Point(464, 57);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(48, 48);
            this.BtnRun.TabIndex = 31;
            this.BtnRun.Text = "button6";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Enabled = false;
            this.BtnPause.Location = new System.Drawing.Point(410, 57);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(48, 48);
            this.BtnPause.TabIndex = 30;
            this.BtnPause.Text = "Пауза";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(372, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "М.";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(291, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ч.";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(210, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Д.";
            // 
            // TextHours
            // 
            this.TextHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextHours.Location = new System.Drawing.Point(248, 64);
            this.TextHours.Name = "TextHours";
            this.TextHours.Size = new System.Drawing.Size(37, 38);
            this.TextHours.TabIndex = 26;
            this.TextHours.Text = "00";
            this.TextHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMinutes
            // 
            this.TextMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextMinutes.Location = new System.Drawing.Point(329, 64);
            this.TextMinutes.Name = "TextMinutes";
            this.TextMinutes.Size = new System.Drawing.Size(37, 38);
            this.TextMinutes.TabIndex = 25;
            this.TextMinutes.Text = "00";
            this.TextMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextDays
            // 
            this.TextDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextDays.Location = new System.Drawing.Point(167, 64);
            this.TextDays.Name = "TextDays";
            this.TextDays.Size = new System.Drawing.Size(37, 38);
            this.TextDays.TabIndex = 23;
            this.TextDays.Text = "00";
            this.TextDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Время";
            // 
            // TextMoney
            // 
            this.TextMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextMoney.Location = new System.Drawing.Point(6, 64);
            this.TextMoney.Name = "TextMoney";
            this.TextMoney.Size = new System.Drawing.Size(141, 23);
            this.TextMoney.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Текущие средства:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 588);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FlightPanel);
            this.Controls.Add(this.ShopPanel);
            this.Controls.Add(this.MyCompanyPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Аэрофлот";
            this.MyCompanyPanel.ResumeLayout(false);
            this.MyCompanyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMyPlanes)).EndInit();
            this.ShopPanel.ResumeLayout(false);
            this.ShopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPlaneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvaliablePlanes)).EndInit();
            this.FlightPanel.ResumeLayout(false);
            this.FlightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFlightInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvaliableFlights)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MyCompanyPanel;
        private System.Windows.Forms.Button BtnSellPlane;
        private System.Windows.Forms.TextBox TextPlaneFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridMyPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ShopPanel;
        private System.Windows.Forms.Button BtnLeasingPlane;
        private System.Windows.Forms.Button BtnLeasePlane;
        private System.Windows.Forms.Button BtnBuyPlane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridAvaliablePlanes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnOpenFlightList;
        private System.Windows.Forms.GroupBox FlightPanel;
        private System.Windows.Forms.Button BtnSelectFlight;
        private System.Windows.Forms.DataGridView GridAvaliableFlights;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GridPlaneInfo;
        private System.Windows.Forms.DataGridView GridFlightInfo;
        private System.Windows.Forms.Button BtnCanselSelect;
        private System.Windows.Forms.Button BtnOpenPlaneShop;
        private System.Windows.Forms.Button BtnReturnPlane;
        private System.Windows.Forms.Button BtnCanselBuy;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnXXRun;
        private System.Windows.Forms.Button BtnXRun;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextHours;
        private System.Windows.Forms.TextBox TextMinutes;
        private System.Windows.Forms.TextBox TextDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextMoney;
        private System.Windows.Forms.Label label3;
    }
}

