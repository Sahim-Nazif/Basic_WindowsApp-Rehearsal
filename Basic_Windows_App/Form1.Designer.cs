namespace Basic_Windows_App
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCelcius = new System.Windows.Forms.Button();
            this.btnFarenheit = new System.Windows.Forms.Button();
            this.btnNewConvertor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temprature Convertor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Temprature  :";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(220, 119);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(226, 20);
            this.txtTemp.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(318, 181);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // btnCelcius
            // 
            this.btnCelcius.Location = new System.Drawing.Point(220, 241);
            this.btnCelcius.Name = "btnCelcius";
            this.btnCelcius.Size = new System.Drawing.Size(94, 44);
            this.btnCelcius.TabIndex = 4;
            this.btnCelcius.Text = "Celcius";
            this.btnCelcius.UseVisualStyleBackColor = true;
            this.btnCelcius.Click += new System.EventHandler(this.btnCelcius_Click);
            // 
            // btnFarenheit
            // 
            this.btnFarenheit.Location = new System.Drawing.Point(352, 241);
            this.btnFarenheit.Name = "btnFarenheit";
            this.btnFarenheit.Size = new System.Drawing.Size(94, 44);
            this.btnFarenheit.TabIndex = 5;
            this.btnFarenheit.Text = "Farenheit";
            this.btnFarenheit.UseVisualStyleBackColor = true;
            this.btnFarenheit.Click += new System.EventHandler(this.btnFarenheit_Click);
            // 
            // btnNewConvertor
            // 
            this.btnNewConvertor.Location = new System.Drawing.Point(277, 345);
            this.btnNewConvertor.Name = "btnNewConvertor";
            this.btnNewConvertor.Size = new System.Drawing.Size(94, 44);
            this.btnNewConvertor.TabIndex = 6;
            this.btnNewConvertor.Text = "New Convertor";
            this.btnNewConvertor.UseVisualStyleBackColor = true;
            this.btnNewConvertor.Click += new System.EventHandler(this.btnNewConvertor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnNewConvertor);
            this.Controls.Add(this.btnFarenheit);
            this.Controls.Add(this.btnCelcius);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCelcius;
        private System.Windows.Forms.Button btnFarenheit;
        private System.Windows.Forms.Button btnNewConvertor;
    }
}

