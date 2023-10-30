namespace ProcessManipulation
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
            this.StartedAssembliesListBox = new System.Windows.Forms.ListBox();
            this.AvailableAssembliesListBox = new System.Windows.Forms.ListBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.RunCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartedAssembliesListBox
            // 
            this.StartedAssembliesListBox.FormattingEnabled = true;
            this.StartedAssembliesListBox.ItemHeight = 16;
            this.StartedAssembliesListBox.Location = new System.Drawing.Point(54, 51);
            this.StartedAssembliesListBox.Name = "StartedAssembliesListBox";
            this.StartedAssembliesListBox.Size = new System.Drawing.Size(257, 340);
            this.StartedAssembliesListBox.TabIndex = 0;
            // 
            // AvailableAssembliesListBox
            // 
            this.AvailableAssembliesListBox.FormattingEnabled = true;
            this.AvailableAssembliesListBox.ItemHeight = 16;
            this.AvailableAssembliesListBox.Location = new System.Drawing.Point(486, 51);
            this.AvailableAssembliesListBox.Name = "AvailableAssembliesListBox";
            this.AvailableAssembliesListBox.Size = new System.Drawing.Size(246, 340);
            this.AvailableAssembliesListBox.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(340, 104);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(123, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(340, 151);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(123, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.Location = new System.Drawing.Point(340, 201);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(123, 23);
            this.CloseWindow.TabIndex = 4;
            this.CloseWindow.Text = "CloseWindow";
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(340, 258);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(123, 23);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // RunCalc
            // 
            this.RunCalc.Location = new System.Drawing.Point(340, 304);
            this.RunCalc.Name = "RunCalc";
            this.RunCalc.Size = new System.Drawing.Size(123, 23);
            this.RunCalc.TabIndex = 6;
            this.RunCalc.Text = "RunCalc";
            this.RunCalc.UseVisualStyleBackColor = true;
            this.RunCalc.Click += new System.EventHandler(this.RunCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunCalc);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AvailableAssembliesListBox);
            this.Controls.Add(this.StartedAssembliesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StartedAssembliesListBox;
        private System.Windows.Forms.ListBox AvailableAssembliesListBox;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button RunCalc;
    }
}

