namespace CalculatorApp
{
    partial class MainForm
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenParen = new System.Windows.Forms.Button();
            this.btnCloseParen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button(); // Новая кнопка логарифма
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button(); // Перемещена в другое место
            this.btnEquals = new System.Windows.Forms.Button();  // Перемещена в другое место
            this.btn0 = new System.Windows.Forms.Button();       // Добавлена кнопка btn0
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(320, 90);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.WordWrap = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None; // По умолчанию прокрутки нет
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 4; // Количество столбцов: 4
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            // Добавляем кнопки в нужные ячейки (столбец 0-3, строки 0-5)
            this.tableLayoutPanelButtons.Controls.Add(this.btnOpenParen, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnCloseParen, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnBackspace, 3, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSqrt, 0, 1); // Перемещена в колонку 0, строка 1
            this.tableLayoutPanelButtons.Controls.Add(this.btnLog, 1, 1);   // Новая кнопка логарифма в колонку 1, строка 1
            this.tableLayoutPanelButtons.Controls.Add(this.btnSquare, 2, 1); // Перемещена в колонку 2, строка 1
            this.tableLayoutPanelButtons.Controls.Add(this.btnPower, 3, 1);  // Перемещена в колонку 3, строка 1
            this.tableLayoutPanelButtons.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btnDivide, 3, 2); // Перемещена вниз
            this.tableLayoutPanelButtons.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btn5, 1, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btn6, 2, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btnMultiply, 3, 3); // Перемещена вниз
            this.tableLayoutPanelButtons.Controls.Add(this.btn1, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btn2, 1, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btn3, 2, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSubtract, 3, 4); // Перемещена вниз
            this.tableLayoutPanelButtons.Controls.Add(this.btnDecimal, 0, 5);   // Перемещена на место btnPlusMinus
            this.tableLayoutPanelButtons.Controls.Add(this.btn0, 1, 5);         // Добавлена кнопка btn0
            this.tableLayoutPanelButtons.Controls.Add(this.btnEquals, 2, 5);    // Перемещена вместо btnDecimal
            this.tableLayoutPanelButtons.Controls.Add(this.btnAdd, 3, 5);       // Перемещена вниз
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 6;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(320, 360); // Соответствует новой ширине формы
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnOpenParen
            // 
            this.btnOpenParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpenParen.Location = new System.Drawing.Point(3, 3);
            this.btnOpenParen.Name = "btnOpenParen";
            this.btnOpenParen.Size = new System.Drawing.Size(74, 53);
            this.btnOpenParen.TabIndex = 0;
            this.btnOpenParen.Text = "(";
            this.btnOpenParen.UseVisualStyleBackColor = true;
            this.btnOpenParen.Click += new System.EventHandler(this.BtnOpenParen_Click);
            // 
            // btnCloseParen
            // 
            this.btnCloseParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCloseParen.Location = new System.Drawing.Point(83, 3);
            this.btnCloseParen.Name = "btnCloseParen";
            this.btnCloseParen.Size = new System.Drawing.Size(74, 53);
            this.btnCloseParen.TabIndex = 1;
            this.btnCloseParen.Text = ")";
            this.btnCloseParen.UseVisualStyleBackColor = true;
            this.btnCloseParen.Click += new System.EventHandler(this.BtnCloseParen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(163, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 53);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBackspace.Location = new System.Drawing.Point(243, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(74, 53);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSqrt.Location = new System.Drawing.Point(3, 62);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(74, 53);
            this.btnSqrt.TabIndex = 4;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLog.Location = new System.Drawing.Point(83, 62);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(74, 53);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "ln";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSquare.Location = new System.Drawing.Point(163, 62);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(74, 53);
            this.btnSquare.TabIndex = 6;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnPower
            // 
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPower.Location = new System.Drawing.Point(243, 62);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(74, 53);
            this.btnPower.TabIndex = 7;
            this.btnPower.Text = "xʸ";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDivide.Location = new System.Drawing.Point(243, 121);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 53);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMultiply.Location = new System.Drawing.Point(243, 121);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 53);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(243, 180);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(74, 53);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(243, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 53);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn7.Location = new System.Drawing.Point(3, 121);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 53);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn8.Location = new System.Drawing.Point(83, 121);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 53);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn9.Location = new System.Drawing.Point(163, 121);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 53);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn4.Location = new System.Drawing.Point(3, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 53);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn5.Location = new System.Drawing.Point(83, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 53);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn6.Location = new System.Drawing.Point(163, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 53);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn1.Location = new System.Drawing.Point(3, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 53);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn2.Location = new System.Drawing.Point(83, 239);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 53);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn3.Location = new System.Drawing.Point(163, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 53);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDecimal.Location = new System.Drawing.Point(3, 298);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(74, 59);
            this.btnDecimal.TabIndex = 21;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn0.Location = new System.Drawing.Point(83, 298);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 59);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquals.Location = new System.Drawing.Point(163, 298);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(74, 59);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 450); // Уменьшена ширина до 320 пикселей
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Запрет изменения размера
            this.MaximizeBox = false; // Отключение кнопки максимизации
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnOpenParen;
        private System.Windows.Forms.Button btnCloseParen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLog; // Новая кнопка логарифма
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn0; // Добавлена кнопка btn0
    }
}
