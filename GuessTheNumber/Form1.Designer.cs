
namespace GuessTheNumber
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUserNamberPrint = new System.Windows.Forms.Label();
            this.labelUserNamber = new System.Windows.Forms.Label();
            this.labelPCNumberPrint = new System.Windows.Forms.Label();
            this.labelPCNumber = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(104, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загадать число";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUserNamberPrint
            // 
            this.labelUserNamberPrint.AutoSize = true;
            this.labelUserNamberPrint.Location = new System.Drawing.Point(29, 34);
            this.labelUserNamberPrint.Name = "labelUserNamberPrint";
            this.labelUserNamberPrint.Size = new System.Drawing.Size(256, 32);
            this.labelUserNamberPrint.TabIndex = 1;
            this.labelUserNamberPrint.Text = "Загаданное число";
            // 
            // labelUserNamber
            // 
            this.labelUserNamber.AutoSize = true;
            this.labelUserNamber.Location = new System.Drawing.Point(98, 93);
            this.labelUserNamber.Name = "labelUserNamber";
            this.labelUserNamber.Size = new System.Drawing.Size(79, 32);
            this.labelUserNamber.TabIndex = 2;
            this.labelUserNamber.Text = "0000";
            // 
            // labelPCNumberPrint
            // 
            this.labelPCNumberPrint.AutoSize = true;
            this.labelPCNumberPrint.Location = new System.Drawing.Point(487, 34);
            this.labelPCNumberPrint.Name = "labelPCNumberPrint";
            this.labelPCNumberPrint.Size = new System.Drawing.Size(266, 32);
            this.labelPCNumberPrint.TabIndex = 3;
            this.labelPCNumberPrint.Text = "Число компьютера";
            // 
            // labelPCNumber
            // 
            this.labelPCNumber.AutoSize = true;
            this.labelPCNumber.Location = new System.Drawing.Point(585, 93);
            this.labelPCNumber.Name = "labelPCNumber";
            this.labelPCNumber.Size = new System.Drawing.Size(79, 32);
            this.labelPCNumber.TabIndex = 4;
            this.labelPCNumber.Text = "0000";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(104, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(554, 95);
            this.button2.TabIndex = 5;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPCNumber);
            this.Controls.Add(this.labelPCNumberPrint);
            this.Controls.Add(this.labelUserNamber);
            this.Controls.Add(this.labelUserNamberPrint);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUserNamberPrint;
        private System.Windows.Forms.Label labelUserNamber;
        private System.Windows.Forms.Label labelPCNumberPrint;
        private System.Windows.Forms.Label labelPCNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

