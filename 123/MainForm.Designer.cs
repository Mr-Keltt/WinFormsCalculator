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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnOpenParen = new System.Windows.Forms.Button();
            this.btnCloseParen = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(400, 60);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 5;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnBackspace, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnOpenParen, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnCloseParen, 3, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSqrt, 4, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSquare, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnPower, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnDivide, 4, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btnMultiply, 4, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btn5, 1, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btn6, 2, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSubtract, 4, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btn1, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btn2, 1, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btn3, 2, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btnAdd, 4, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btnPlusMinus, 0, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.btn0, 1, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.btnDecimal, 2, 5);
            this.tableLayoutPanelButtons.Controls.Add(this.btnEquals, 4, 5);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 6;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(400, 390);
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 59);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBackspace.Location = new System.Drawing.Point(83, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(74, 59);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // btnOpenParen
            // 
            this.btnOpenParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpenParen.Location = new System.Drawing.Point(163, 3);
            this.btnOpenParen.Name = "btnOpenParen";
            this.btnOpenParen.Size = new System.Drawing.Size(74, 59);
            this.btnOpenParen.TabIndex = 2;
            this.btnOpenParen.Text = "(";
            this.btnOpenParen.UseVisualStyleBackColor = true;
            this.btnOpenParen.Click += new System.EventHandler(this.BtnOpenParen_Click);
            // 
            // btnCloseParen
            // 
            this.btnCloseParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCloseParen.Location = new System.Drawing.Point(243, 3);
            this.btnCloseParen.Name = "btnCloseParen";
            this.btnCloseParen.Size = new System.Drawing.Size(74, 59);
            this.btnCloseParen.TabIndex = 3;
            this.btnCloseParen.Text = ")";
            this.btnCloseParen.UseVisualStyleBackColor = true;
            this.btnCloseParen.Click += new System.EventHandler(this.BtnCloseParen_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSqrt.Location = new System.Drawing.Point(323, 3);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(74, 59);
            this.btnSqrt.TabIndex = 4;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSquare.Location = new System.Drawing.Point(3, 68);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(74, 59);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnPower
            // 
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPower.Location = new System.Drawing.Point(83, 68);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(74, 59);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "xʸ";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDivide.Location = new System.Drawing.Point(323, 68);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 59);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn7.Location = new System.Drawing.Point(3, 133);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 59);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn8.Location = new System.Drawing.Point(83, 133);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 59);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn9.Location = new System.Drawing.Point(163, 133);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 59);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMultiply.Location = new System.Drawing.Point(323, 133);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 59);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn4.Location = new System.Drawing.Point(3, 198);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 59);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn5.Location = new System.Drawing.Point(83, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 59);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn6.Location = new System.Drawing.Point(163, 198);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 59);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(323, 198);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(74, 59);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn1.Location = new System.Drawing.Point(3, 263);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 59);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn2.Location = new System.Drawing.Point(83, 263);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 59);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn3.Location = new System.Drawing.Point(163, 263);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 59);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(323, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 59);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPlusMinus.Location = new System.Drawing.Point(3, 328);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(74, 59);
            this.btnPlusMinus.TabIndex = 20;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.BtnPlusMinus_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn0.Location = new System.Drawing.Point(83, 328);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 59);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDecimal.Location = new System.Drawing.Point(163, 328);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(74, 59);
            this.btnDecimal.TabIndex = 22;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquals.Location = new System.Drawing.Point(323, 328);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(74, 59);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.txtDisplay);
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnOpenParen;
        private System.Windows.Forms.Button btnCloseParen;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
    }
}
