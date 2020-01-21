namespace Basic_Windows_App
{
    partial class Temp
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
            this.label1 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.chboxCelcius = new System.Windows.Forms.CheckBox();
            this.chkboxFarenheit = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temprature Convertor";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(118, 124);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(98, 13);
            this.c.TabIndex = 2;
            this.c.Text = "Enter Temprature  :";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(233, 121);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(226, 20);
            this.txtTemp.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(233, 306);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 44);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // chboxCelcius
            // 
            this.chboxCelcius.AutoSize = true;
            this.chboxCelcius.Location = new System.Drawing.Point(233, 166);
            this.chboxCelcius.Name = "chboxCelcius";
            this.chboxCelcius.Size = new System.Drawing.Size(60, 17);
            this.chboxCelcius.TabIndex = 6;
            this.chboxCelcius.Text = "Celcius";
            this.chboxCelcius.UseVisualStyleBackColor = true;
            // 
            // chkboxFarenheit
            // 
            this.chkboxFarenheit.AutoSize = true;
            this.chkboxFarenheit.Location = new System.Drawing.Point(233, 205);
            this.chkboxFarenheit.Name = "chkboxFarenheit";
            this.chkboxFarenheit.Size = new System.Drawing.Size(70, 17);
            this.chkboxFarenheit.TabIndex = 7;
            this.chkboxFarenheit.Text = "Farenheit";
            this.chkboxFarenheit.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(230, 257);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkboxFarenheit);
            this.Controls.Add(this.chboxCelcius);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label1);
            this.Name = "Temp";
            this.Text = "Temp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox chboxCelcius;
        private System.Windows.Forms.CheckBox chkboxFarenheit;
        private System.Windows.Forms.Label lblResult;
    }
}