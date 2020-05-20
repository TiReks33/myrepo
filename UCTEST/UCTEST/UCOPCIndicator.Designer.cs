namespace UCTEST
{
    partial class UCOPCIndicator
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelSine = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.labelRamp = new System.Windows.Forms.Label();
            this.textBoxSine = new System.Windows.Forms.TextBox();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.textBoxInfo);
            this.groupBoxMain.Controls.Add(this.labelSine);
            this.groupBoxMain.Controls.Add(this.labelRandom);
            this.groupBoxMain.Controls.Add(this.labelRamp);
            this.groupBoxMain.Controls.Add(this.textBoxSine);
            this.groupBoxMain.Controls.Add(this.textBoxRandom);
            this.groupBoxMain.Controls.Add(this.textBoxRamp);
            this.groupBoxMain.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(113, 152);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "OPC I";
            // 
            // labelSine
            // 
            this.labelSine.AutoSize = true;
            this.labelSine.Location = new System.Drawing.Point(7, 77);
            this.labelSine.Name = "labelSine";
            this.labelSine.Size = new System.Drawing.Size(28, 13);
            this.labelSine.TabIndex = 5;
            this.labelSine.Text = "Sine";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(7, 51);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(47, 13);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Random";
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Location = new System.Drawing.Point(7, 22);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(35, 13);
            this.labelRamp.TabIndex = 3;
            this.labelRamp.Text = "Ramp";
            // 
            // textBoxSine
            // 
            this.textBoxSine.Location = new System.Drawing.Point(60, 74);
            this.textBoxSine.Name = "textBoxSine";
            this.textBoxSine.Size = new System.Drawing.Size(43, 20);
            this.textBoxSine.TabIndex = 2;
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(60, 48);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(43, 20);
            this.textBoxRandom.TabIndex = 1;
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(60, 19);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(43, 20);
            this.textBoxRamp.TabIndex = 0;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(44, 113);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(63, 20);
            this.textBoxInfo.TabIndex = 6;
            // 
            // UCOPCIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMain);
            this.Name = "UCOPCIndicator";
            this.Size = new System.Drawing.Size(121, 166);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label labelSine;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.TextBox textBoxSine;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}
