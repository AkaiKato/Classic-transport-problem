namespace КТЗ
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
            this.dimensionLabel = new System.Windows.Forms.Label();
            this.getIDimensionTextBox = new System.Windows.Forms.TextBox();
            this.readyDimensionButton = new System.Windows.Forms.Button();
            this.getJDimensionTextBox = new System.Windows.Forms.TextBox();
            this.workingSpaceDataGrid = new System.Windows.Forms.DataGridView();
            this.workingSpaceLabel = new System.Windows.Forms.Label();
            this.beginDataDataGrid = new System.Windows.Forms.DataGridView();
            this.planAndPotencialDataGrid = new System.Windows.Forms.DataGridView();
            this.beginDataLabel = new System.Windows.Forms.Label();
            this.planAndPotencialLabel = new System.Windows.Forms.Label();
            this.enterBeginDataLabel = new System.Windows.Forms.Label();
            this.readyBeginDataButton = new System.Windows.Forms.Button();
            this.nopButton = new System.Windows.Forms.Button();
            this.minTransportLabel = new System.Windows.Forms.Label();
            this.minTransportButton = new System.Windows.Forms.Button();
            this.minTransportTextBox = new System.Windows.Forms.TextBox();
            this.volumeTransportingButton = new System.Windows.Forms.Button();
            this.minVolumeTransportingLabel = new System.Windows.Forms.Label();
            this.minVolumeTrasnportingTextBox = new System.Windows.Forms.TextBox();
            this.minVolumeTransportingButton = new System.Windows.Forms.Button();
            this.potentialButton = new System.Windows.Forms.Button();
            this.potentialReadyLabel = new System.Windows.Forms.Label();
            this.potentailReadyButton = new System.Windows.Forms.Button();
            this.checkOptimalButton = new System.Windows.Forms.Button();
            this.planOptimalLabel = new System.Windows.Forms.Label();
            this.planOptimalYesButton = new System.Windows.Forms.Button();
            this.planOptimalNoButton = new System.Windows.Forms.Button();
            this.defineFirstCageOfCycleButton = new System.Windows.Forms.Button();
            this.cageFindedLabel = new System.Windows.Forms.Label();
            this.cageFindedButton = new System.Windows.Forms.Button();
            this.nextCageLabel = new System.Windows.Forms.Label();
            this.nextCageButton = new System.Windows.Forms.Button();
            this.enterTettaValueLabel = new System.Windows.Forms.Label();
            this.enterTettaValueTextBox = new System.Windows.Forms.TextBox();
            this.enterTettaValueButton = new System.Windows.Forms.Button();
            this.goToTheBestPlan = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.endSecondlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workingSpaceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDataDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planAndPotencialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dimensionLabel
            // 
            this.dimensionLabel.AutoSize = true;
            this.dimensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dimensionLabel.Location = new System.Drawing.Point(12, 17);
            this.dimensionLabel.Name = "dimensionLabel";
            this.dimensionLabel.Size = new System.Drawing.Size(337, 26);
            this.dimensionLabel.TabIndex = 0;
            this.dimensionLabel.Text = "Введите размерность таблицы:";
            // 
            // getIDimensionTextBox
            // 
            this.getIDimensionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.getIDimensionTextBox.Location = new System.Drawing.Point(355, 20);
            this.getIDimensionTextBox.Name = "getIDimensionTextBox";
            this.getIDimensionTextBox.Size = new System.Drawing.Size(71, 23);
            this.getIDimensionTextBox.TabIndex = 1;
            // 
            // readyDimensionButton
            // 
            this.readyDimensionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.readyDimensionButton.Location = new System.Drawing.Point(509, 18);
            this.readyDimensionButton.Name = "readyDimensionButton";
            this.readyDimensionButton.Size = new System.Drawing.Size(131, 27);
            this.readyDimensionButton.TabIndex = 3;
            this.readyDimensionButton.Text = "Готово";
            this.readyDimensionButton.UseVisualStyleBackColor = true;
            this.readyDimensionButton.Click += new System.EventHandler(this.readyDimensionButton_Click);
            // 
            // getJDimensionTextBox
            // 
            this.getJDimensionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.getJDimensionTextBox.Location = new System.Drawing.Point(432, 20);
            this.getJDimensionTextBox.Name = "getJDimensionTextBox";
            this.getJDimensionTextBox.Size = new System.Drawing.Size(71, 23);
            this.getJDimensionTextBox.TabIndex = 4;
            // 
            // workingSpaceDataGrid
            // 
            this.workingSpaceDataGrid.AllowUserToAddRows = false;
            this.workingSpaceDataGrid.AllowUserToDeleteRows = false;
            this.workingSpaceDataGrid.AllowUserToResizeColumns = false;
            this.workingSpaceDataGrid.AllowUserToResizeRows = false;
            this.workingSpaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workingSpaceDataGrid.Location = new System.Drawing.Point(17, 111);
            this.workingSpaceDataGrid.Name = "workingSpaceDataGrid";
            this.workingSpaceDataGrid.Size = new System.Drawing.Size(443, 237);
            this.workingSpaceDataGrid.TabIndex = 5;
            this.workingSpaceDataGrid.Visible = false;
            // 
            // workingSpaceLabel
            // 
            this.workingSpaceLabel.AutoSize = true;
            this.workingSpaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.workingSpaceLabel.Location = new System.Drawing.Point(12, 82);
            this.workingSpaceLabel.Name = "workingSpaceLabel";
            this.workingSpaceLabel.Size = new System.Drawing.Size(189, 26);
            this.workingSpaceLabel.TabIndex = 8;
            this.workingSpaceLabel.Text = "Рабочая область";
            this.workingSpaceLabel.Visible = false;
            // 
            // beginDataDataGrid
            // 
            this.beginDataDataGrid.AllowUserToAddRows = false;
            this.beginDataDataGrid.AllowUserToDeleteRows = false;
            this.beginDataDataGrid.AllowUserToResizeColumns = false;
            this.beginDataDataGrid.AllowUserToResizeRows = false;
            this.beginDataDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beginDataDataGrid.Location = new System.Drawing.Point(17, 448);
            this.beginDataDataGrid.Name = "beginDataDataGrid";
            this.beginDataDataGrid.ReadOnly = true;
            this.beginDataDataGrid.Size = new System.Drawing.Size(443, 237);
            this.beginDataDataGrid.TabIndex = 9;
            this.beginDataDataGrid.Visible = false;
            // 
            // planAndPotencialDataGrid
            // 
            this.planAndPotencialDataGrid.AllowUserToAddRows = false;
            this.planAndPotencialDataGrid.AllowUserToDeleteRows = false;
            this.planAndPotencialDataGrid.AllowUserToResizeColumns = false;
            this.planAndPotencialDataGrid.AllowUserToResizeRows = false;
            this.planAndPotencialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planAndPotencialDataGrid.Location = new System.Drawing.Point(482, 448);
            this.planAndPotencialDataGrid.Name = "planAndPotencialDataGrid";
            this.planAndPotencialDataGrid.ReadOnly = true;
            this.planAndPotencialDataGrid.Size = new System.Drawing.Size(443, 237);
            this.planAndPotencialDataGrid.TabIndex = 10;
            this.planAndPotencialDataGrid.Visible = false;
            // 
            // beginDataLabel
            // 
            this.beginDataLabel.AutoSize = true;
            this.beginDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.beginDataLabel.Location = new System.Drawing.Point(12, 423);
            this.beginDataLabel.Name = "beginDataLabel";
            this.beginDataLabel.Size = new System.Drawing.Size(174, 22);
            this.beginDataLabel.TabIndex = 11;
            this.beginDataLabel.Text = "Начальные данные";
            this.beginDataLabel.Visible = false;
            // 
            // planAndPotencialLabel
            // 
            this.planAndPotencialLabel.AutoSize = true;
            this.planAndPotencialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.planAndPotencialLabel.Location = new System.Drawing.Point(478, 423);
            this.planAndPotencialLabel.Name = "planAndPotencialLabel";
            this.planAndPotencialLabel.Size = new System.Drawing.Size(330, 22);
            this.planAndPotencialLabel.TabIndex = 12;
            this.planAndPotencialLabel.Text = "Текущий опорный план и потенциалы";
            this.planAndPotencialLabel.Visible = false;
            // 
            // enterBeginDataLabel
            // 
            this.enterBeginDataLabel.AutoSize = true;
            this.enterBeginDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.enterBeginDataLabel.Location = new System.Drawing.Point(12, 17);
            this.enterBeginDataLabel.Name = "enterBeginDataLabel";
            this.enterBeginDataLabel.Size = new System.Drawing.Size(442, 26);
            this.enterBeginDataLabel.TabIndex = 13;
            this.enterBeginDataLabel.Text = "Введите ваши данные в рабочую область";
            this.enterBeginDataLabel.Visible = false;
            // 
            // readyBeginDataButton
            // 
            this.readyBeginDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.readyBeginDataButton.Location = new System.Drawing.Point(460, 18);
            this.readyBeginDataButton.Name = "readyBeginDataButton";
            this.readyBeginDataButton.Size = new System.Drawing.Size(131, 27);
            this.readyBeginDataButton.TabIndex = 14;
            this.readyBeginDataButton.Text = "Готово";
            this.readyBeginDataButton.UseVisualStyleBackColor = true;
            this.readyBeginDataButton.Visible = false;
            this.readyBeginDataButton.Click += new System.EventHandler(this.readyBeginDataButton_Click);
            // 
            // nopButton
            // 
            this.nopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nopButton.Location = new System.Drawing.Point(482, 111);
            this.nopButton.Name = "nopButton";
            this.nopButton.Size = new System.Drawing.Size(443, 27);
            this.nopButton.TabIndex = 15;
            this.nopButton.Text = "Определение НОП";
            this.nopButton.UseVisualStyleBackColor = true;
            this.nopButton.Visible = false;
            this.nopButton.Click += new System.EventHandler(this.nopButton_Click);
            // 
            // minTransportLabel
            // 
            this.minTransportLabel.AutoSize = true;
            this.minTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.minTransportLabel.Location = new System.Drawing.Point(12, 17);
            this.minTransportLabel.Name = "minTransportLabel";
            this.minTransportLabel.Size = new System.Drawing.Size(579, 26);
            this.minTransportLabel.TabIndex = 16;
            this.minTransportLabel.Text = "Введите значение клетки с min стоимостью перевозки:";
            this.minTransportLabel.Visible = false;
            // 
            // minTransportButton
            // 
            this.minTransportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minTransportButton.Location = new System.Drawing.Point(677, 18);
            this.minTransportButton.Name = "minTransportButton";
            this.minTransportButton.Size = new System.Drawing.Size(131, 27);
            this.minTransportButton.TabIndex = 17;
            this.minTransportButton.Text = "Готово";
            this.minTransportButton.UseVisualStyleBackColor = true;
            this.minTransportButton.Visible = false;
            this.minTransportButton.Click += new System.EventHandler(this.minTransportButton_Click);
            // 
            // minTransportTextBox
            // 
            this.minTransportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minTransportTextBox.Location = new System.Drawing.Point(597, 20);
            this.minTransportTextBox.Name = "minTransportTextBox";
            this.minTransportTextBox.Size = new System.Drawing.Size(71, 23);
            this.minTransportTextBox.TabIndex = 18;
            this.minTransportTextBox.Visible = false;
            // 
            // volumeTransportingButton
            // 
            this.volumeTransportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.volumeTransportingButton.Location = new System.Drawing.Point(482, 144);
            this.volumeTransportingButton.Name = "volumeTransportingButton";
            this.volumeTransportingButton.Size = new System.Drawing.Size(443, 27);
            this.volumeTransportingButton.TabIndex = 19;
            this.volumeTransportingButton.Text = "Определение объёма перевозки";
            this.volumeTransportingButton.UseVisualStyleBackColor = true;
            this.volumeTransportingButton.Visible = false;
            this.volumeTransportingButton.Click += new System.EventHandler(this.volumeTransportingButton_Click);
            // 
            // minVolumeTransportingLabel
            // 
            this.minVolumeTransportingLabel.AutoSize = true;
            this.minVolumeTransportingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.minVolumeTransportingLabel.Location = new System.Drawing.Point(12, 17);
            this.minVolumeTransportingLabel.Name = "minVolumeTransportingLabel";
            this.minVolumeTransportingLabel.Size = new System.Drawing.Size(456, 26);
            this.minVolumeTransportingLabel.TabIndex = 20;
            this.minVolumeTransportingLabel.Text = "Введите min возможный объём перевозки:";
            this.minVolumeTransportingLabel.Visible = false;
            // 
            // minVolumeTrasnportingTextBox
            // 
            this.minVolumeTrasnportingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minVolumeTrasnportingTextBox.Location = new System.Drawing.Point(474, 20);
            this.minVolumeTrasnportingTextBox.Name = "minVolumeTrasnportingTextBox";
            this.minVolumeTrasnportingTextBox.Size = new System.Drawing.Size(71, 23);
            this.minVolumeTrasnportingTextBox.TabIndex = 21;
            this.minVolumeTrasnportingTextBox.Visible = false;
            // 
            // minVolumeTransportingButton
            // 
            this.minVolumeTransportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minVolumeTransportingButton.Location = new System.Drawing.Point(551, 18);
            this.minVolumeTransportingButton.Name = "minVolumeTransportingButton";
            this.minVolumeTransportingButton.Size = new System.Drawing.Size(131, 27);
            this.minVolumeTransportingButton.TabIndex = 22;
            this.minVolumeTransportingButton.Text = "Готово";
            this.minVolumeTransportingButton.UseVisualStyleBackColor = true;
            this.minVolumeTransportingButton.Visible = false;
            this.minVolumeTransportingButton.Click += new System.EventHandler(this.minVolumeTransportingButton_Click);
            // 
            // potentialButton
            // 
            this.potentialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.potentialButton.Location = new System.Drawing.Point(482, 177);
            this.potentialButton.Name = "potentialButton";
            this.potentialButton.Size = new System.Drawing.Size(443, 27);
            this.potentialButton.TabIndex = 23;
            this.potentialButton.Text = "Определение потенциалов";
            this.potentialButton.UseVisualStyleBackColor = true;
            this.potentialButton.Visible = false;
            this.potentialButton.Click += new System.EventHandler(this.potentialButton_Click);
            // 
            // potentialReadyLabel
            // 
            this.potentialReadyLabel.AutoSize = true;
            this.potentialReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.potentialReadyLabel.Location = new System.Drawing.Point(12, 17);
            this.potentialReadyLabel.Name = "potentialReadyLabel";
            this.potentialReadyLabel.Size = new System.Drawing.Size(355, 26);
            this.potentialReadyLabel.TabIndex = 24;
            this.potentialReadyLabel.Text = "Заполните столбец Uj и строку Vi";
            this.potentialReadyLabel.Visible = false;
            // 
            // potentailReadyButton
            // 
            this.potentailReadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.potentailReadyButton.Location = new System.Drawing.Point(366, 18);
            this.potentailReadyButton.Name = "potentailReadyButton";
            this.potentailReadyButton.Size = new System.Drawing.Size(131, 27);
            this.potentailReadyButton.TabIndex = 25;
            this.potentailReadyButton.Text = "Готово";
            this.potentailReadyButton.UseVisualStyleBackColor = true;
            this.potentailReadyButton.Visible = false;
            this.potentailReadyButton.Click += new System.EventHandler(this.potentailReadyButton_Click);
            // 
            // checkOptimalButton
            // 
            this.checkOptimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkOptimalButton.Location = new System.Drawing.Point(482, 210);
            this.checkOptimalButton.Name = "checkOptimalButton";
            this.checkOptimalButton.Size = new System.Drawing.Size(443, 27);
            this.checkOptimalButton.TabIndex = 26;
            this.checkOptimalButton.Text = "Проверка оптимальности";
            this.checkOptimalButton.UseVisualStyleBackColor = true;
            this.checkOptimalButton.Visible = false;
            this.checkOptimalButton.Click += new System.EventHandler(this.checkOptimalButton_Click);
            // 
            // planOptimalLabel
            // 
            this.planOptimalLabel.AutoSize = true;
            this.planOptimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.planOptimalLabel.Location = new System.Drawing.Point(477, 266);
            this.planOptimalLabel.Name = "planOptimalLabel";
            this.planOptimalLabel.Size = new System.Drawing.Size(451, 26);
            this.planOptimalLabel.TabIndex = 27;
            this.planOptimalLabel.Text = "Является ли опорный план оптимальным?";
            this.planOptimalLabel.Visible = false;
            // 
            // planOptimalYesButton
            // 
            this.planOptimalYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.planOptimalYesButton.Location = new System.Drawing.Point(551, 321);
            this.planOptimalYesButton.Name = "planOptimalYesButton";
            this.planOptimalYesButton.Size = new System.Drawing.Size(149, 27);
            this.planOptimalYesButton.TabIndex = 28;
            this.planOptimalYesButton.Text = "Да";
            this.planOptimalYesButton.UseVisualStyleBackColor = true;
            this.planOptimalYesButton.Visible = false;
            this.planOptimalYesButton.Click += new System.EventHandler(this.planOptimalYesButton_Click);
            // 
            // planOptimalNoButton
            // 
            this.planOptimalNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.planOptimalNoButton.Location = new System.Drawing.Point(706, 321);
            this.planOptimalNoButton.Name = "planOptimalNoButton";
            this.planOptimalNoButton.Size = new System.Drawing.Size(149, 27);
            this.planOptimalNoButton.TabIndex = 29;
            this.planOptimalNoButton.Text = "Нет";
            this.planOptimalNoButton.UseVisualStyleBackColor = true;
            this.planOptimalNoButton.Visible = false;
            this.planOptimalNoButton.Click += new System.EventHandler(this.planOptimalNoButton_Click);
            // 
            // defineFirstCageOfCycleButton
            // 
            this.defineFirstCageOfCycleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.defineFirstCageOfCycleButton.Location = new System.Drawing.Point(482, 243);
            this.defineFirstCageOfCycleButton.Name = "defineFirstCageOfCycleButton";
            this.defineFirstCageOfCycleButton.Size = new System.Drawing.Size(443, 27);
            this.defineFirstCageOfCycleButton.TabIndex = 30;
            this.defineFirstCageOfCycleButton.Text = "Определение первой клетки цикла";
            this.defineFirstCageOfCycleButton.UseVisualStyleBackColor = true;
            this.defineFirstCageOfCycleButton.Visible = false;
            this.defineFirstCageOfCycleButton.Click += new System.EventHandler(this.defineFirstCageOfCycleButton_Click);
            // 
            // cageFindedLabel
            // 
            this.cageFindedLabel.AutoSize = true;
            this.cageFindedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cageFindedLabel.Location = new System.Drawing.Point(15, 18);
            this.cageFindedLabel.Name = "cageFindedLabel";
            this.cageFindedLabel.Size = new System.Drawing.Size(453, 26);
            this.cageFindedLabel.TabIndex = 31;
            this.cageFindedLabel.Text = "Выделите клетку, с которой начнется цикл";
            this.cageFindedLabel.Visible = false;
            // 
            // cageFindedButton
            // 
            this.cageFindedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cageFindedButton.Location = new System.Drawing.Point(474, 18);
            this.cageFindedButton.Name = "cageFindedButton";
            this.cageFindedButton.Size = new System.Drawing.Size(131, 27);
            this.cageFindedButton.TabIndex = 32;
            this.cageFindedButton.Text = "Готово";
            this.cageFindedButton.UseVisualStyleBackColor = true;
            this.cageFindedButton.Visible = false;
            this.cageFindedButton.Click += new System.EventHandler(this.cageFindedButton_Click);
            // 
            // nextCageLabel
            // 
            this.nextCageLabel.AutoSize = true;
            this.nextCageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nextCageLabel.Location = new System.Drawing.Point(15, 18);
            this.nextCageLabel.Name = "nextCageLabel";
            this.nextCageLabel.Size = new System.Drawing.Size(676, 26);
            this.nextCageLabel.TabIndex = 33;
            this.nextCageLabel.Text = "Выделите остальные клетки входящие в цикл (удерживайте ctrl)";
            this.nextCageLabel.Visible = false;
            // 
            // nextCageButton
            // 
            this.nextCageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextCageButton.Location = new System.Drawing.Point(697, 18);
            this.nextCageButton.Name = "nextCageButton";
            this.nextCageButton.Size = new System.Drawing.Size(131, 27);
            this.nextCageButton.TabIndex = 34;
            this.nextCageButton.Text = "Готово";
            this.nextCageButton.UseVisualStyleBackColor = true;
            this.nextCageButton.Visible = false;
            this.nextCageButton.Click += new System.EventHandler(this.nextCageButton_Click);
            // 
            // enterTettaValueLabel
            // 
            this.enterTettaValueLabel.AutoSize = true;
            this.enterTettaValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.enterTettaValueLabel.Location = new System.Drawing.Point(15, 18);
            this.enterTettaValueLabel.Name = "enterTettaValueLabel";
            this.enterTettaValueLabel.Size = new System.Drawing.Size(269, 26);
            this.enterTettaValueLabel.TabIndex = 35;
            this.enterTettaValueLabel.Text = "Введите значение тетты:";
            this.enterTettaValueLabel.Visible = false;
            // 
            // enterTettaValueTextBox
            // 
            this.enterTettaValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterTettaValueTextBox.Location = new System.Drawing.Point(289, 21);
            this.enterTettaValueTextBox.Name = "enterTettaValueTextBox";
            this.enterTettaValueTextBox.Size = new System.Drawing.Size(71, 23);
            this.enterTettaValueTextBox.TabIndex = 36;
            this.enterTettaValueTextBox.Visible = false;
            // 
            // enterTettaValueButton
            // 
            this.enterTettaValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterTettaValueButton.Location = new System.Drawing.Point(366, 18);
            this.enterTettaValueButton.Name = "enterTettaValueButton";
            this.enterTettaValueButton.Size = new System.Drawing.Size(131, 27);
            this.enterTettaValueButton.TabIndex = 37;
            this.enterTettaValueButton.Text = "Готово";
            this.enterTettaValueButton.UseVisualStyleBackColor = true;
            this.enterTettaValueButton.Visible = false;
            this.enterTettaValueButton.Click += new System.EventHandler(this.enterTettaValueButton_Click);
            // 
            // goToTheBestPlan
            // 
            this.goToTheBestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goToTheBestPlan.Location = new System.Drawing.Point(482, 276);
            this.goToTheBestPlan.Name = "goToTheBestPlan";
            this.goToTheBestPlan.Size = new System.Drawing.Size(443, 27);
            this.goToTheBestPlan.TabIndex = 38;
            this.goToTheBestPlan.Text = "Переход к наилучшему плану";
            this.goToTheBestPlan.UseVisualStyleBackColor = true;
            this.goToTheBestPlan.Visible = false;
            this.goToTheBestPlan.Click += new System.EventHandler(this.goToTheBestPlan_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.endLabel.Location = new System.Drawing.Point(321, 19);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(270, 26);
            this.endLabel.TabIndex = 39;
            this.endLabel.Text = "Наилучший план найден!";
            this.endLabel.Visible = false;
            // 
            // endSecondlabel
            // 
            this.endSecondlabel.AutoSize = true;
            this.endSecondlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.endSecondlabel.Location = new System.Drawing.Point(266, 48);
            this.endSecondlabel.Name = "endSecondlabel";
            this.endSecondlabel.Size = new System.Drawing.Size(431, 26);
            this.endSecondlabel.TabIndex = 40;
            this.endSecondlabel.Text = "Смотрите его в текущем опорном плане!";
            this.endSecondlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(937, 697);
            this.Controls.Add(this.endSecondlabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.goToTheBestPlan);
            this.Controls.Add(this.enterTettaValueButton);
            this.Controls.Add(this.enterTettaValueTextBox);
            this.Controls.Add(this.enterTettaValueLabel);
            this.Controls.Add(this.nextCageButton);
            this.Controls.Add(this.nextCageLabel);
            this.Controls.Add(this.cageFindedButton);
            this.Controls.Add(this.cageFindedLabel);
            this.Controls.Add(this.defineFirstCageOfCycleButton);
            this.Controls.Add(this.planOptimalNoButton);
            this.Controls.Add(this.planOptimalYesButton);
            this.Controls.Add(this.planOptimalLabel);
            this.Controls.Add(this.checkOptimalButton);
            this.Controls.Add(this.potentailReadyButton);
            this.Controls.Add(this.potentialReadyLabel);
            this.Controls.Add(this.potentialButton);
            this.Controls.Add(this.minVolumeTransportingButton);
            this.Controls.Add(this.minVolumeTrasnportingTextBox);
            this.Controls.Add(this.minVolumeTransportingLabel);
            this.Controls.Add(this.volumeTransportingButton);
            this.Controls.Add(this.minTransportTextBox);
            this.Controls.Add(this.minTransportButton);
            this.Controls.Add(this.minTransportLabel);
            this.Controls.Add(this.nopButton);
            this.Controls.Add(this.readyBeginDataButton);
            this.Controls.Add(this.enterBeginDataLabel);
            this.Controls.Add(this.planAndPotencialLabel);
            this.Controls.Add(this.beginDataLabel);
            this.Controls.Add(this.planAndPotencialDataGrid);
            this.Controls.Add(this.beginDataDataGrid);
            this.Controls.Add(this.workingSpaceLabel);
            this.Controls.Add(this.workingSpaceDataGrid);
            this.Controls.Add(this.getJDimensionTextBox);
            this.Controls.Add(this.readyDimensionButton);
            this.Controls.Add(this.getIDimensionTextBox);
            this.Controls.Add(this.dimensionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "КТЗ";
            ((System.ComponentModel.ISupportInitialize)(this.workingSpaceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDataDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planAndPotencialDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dimensionLabel;
        private System.Windows.Forms.TextBox getIDimensionTextBox;
        private System.Windows.Forms.Button readyDimensionButton;
        private System.Windows.Forms.TextBox getJDimensionTextBox;
        private System.Windows.Forms.DataGridView workingSpaceDataGrid;
        private System.Windows.Forms.Label workingSpaceLabel;
        private System.Windows.Forms.DataGridView beginDataDataGrid;
        private System.Windows.Forms.DataGridView planAndPotencialDataGrid;
        private System.Windows.Forms.Label beginDataLabel;
        private System.Windows.Forms.Label planAndPotencialLabel;
        private System.Windows.Forms.Label enterBeginDataLabel;
        private System.Windows.Forms.Button readyBeginDataButton;
        private System.Windows.Forms.Button nopButton;
        private System.Windows.Forms.Label minTransportLabel;
        private System.Windows.Forms.Button minTransportButton;
        private System.Windows.Forms.TextBox minTransportTextBox;
        private System.Windows.Forms.Button volumeTransportingButton;
        private System.Windows.Forms.Label minVolumeTransportingLabel;
        private System.Windows.Forms.TextBox minVolumeTrasnportingTextBox;
        private System.Windows.Forms.Button minVolumeTransportingButton;
        private System.Windows.Forms.Button potentialButton;
        private System.Windows.Forms.Label potentialReadyLabel;
        private System.Windows.Forms.Button potentailReadyButton;
        private System.Windows.Forms.Button checkOptimalButton;
        private System.Windows.Forms.Label planOptimalLabel;
        private System.Windows.Forms.Button planOptimalYesButton;
        private System.Windows.Forms.Button planOptimalNoButton;
        private System.Windows.Forms.Button defineFirstCageOfCycleButton;
        private System.Windows.Forms.Label cageFindedLabel;
        private System.Windows.Forms.Button cageFindedButton;
        private System.Windows.Forms.Label nextCageLabel;
        private System.Windows.Forms.Button nextCageButton;
        private System.Windows.Forms.Label enterTettaValueLabel;
        private System.Windows.Forms.TextBox enterTettaValueTextBox;
        private System.Windows.Forms.Button enterTettaValueButton;
        private System.Windows.Forms.Button goToTheBestPlan;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label endSecondlabel;
    }
}

