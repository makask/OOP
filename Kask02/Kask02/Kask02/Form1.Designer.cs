namespace Kask02
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
            this.txtBox_Num1 = new System.Windows.Forms.TextBox();
            this.txtBox_Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.radioBtn_Add = new System.Windows.Forms.RadioButton();
            this.radioBtn_Subtract = new System.Windows.Forms.RadioButton();
            this.radioBtn_Multiply = new System.Windows.Forms.RadioButton();
            this.radioBtn_Divide = new System.Windows.Forms.RadioButton();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Num1
            // 
            this.txtBox_Num1.Location = new System.Drawing.Point(49, 76);
            this.txtBox_Num1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBox_Num1.Name = "txtBox_Num1";
            this.txtBox_Num1.Size = new System.Drawing.Size(180, 29);
            this.txtBox_Num1.TabIndex = 0;
            // 
            // txtBox_Num2
            // 
            this.txtBox_Num2.Location = new System.Drawing.Point(374, 76);
            this.txtBox_Num2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBox_Num2.Name = "txtBox_Num2";
            this.txtBox_Num2.Size = new System.Drawing.Size(180, 29);
            this.txtBox_Num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esimene arv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(370, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teine arv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vastus";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Answer.Location = new System.Drawing.Point(127, 176);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(427, 43);
            this.lbl_Answer.TabIndex = 5;
            // 
            // radioBtn_Add
            // 
            this.radioBtn_Add.AutoSize = true;
            this.radioBtn_Add.ForeColor = System.Drawing.Color.Red;
            this.radioBtn_Add.Location = new System.Drawing.Point(70, 264);
            this.radioBtn_Add.Name = "radioBtn_Add";
            this.radioBtn_Add.Size = new System.Drawing.Size(83, 25);
            this.radioBtn_Add.TabIndex = 6;
            this.radioBtn_Add.TabStop = true;
            this.radioBtn_Add.Text = "Liida";
            this.radioBtn_Add.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Subtract
            // 
            this.radioBtn_Subtract.AutoSize = true;
            this.radioBtn_Subtract.ForeColor = System.Drawing.Color.Red;
            this.radioBtn_Subtract.Location = new System.Drawing.Point(70, 304);
            this.radioBtn_Subtract.Name = "radioBtn_Subtract";
            this.radioBtn_Subtract.Size = new System.Drawing.Size(94, 25);
            this.radioBtn_Subtract.TabIndex = 7;
            this.radioBtn_Subtract.TabStop = true;
            this.radioBtn_Subtract.Text = "Lahuta";
            this.radioBtn_Subtract.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Multiply
            // 
            this.radioBtn_Multiply.AutoSize = true;
            this.radioBtn_Multiply.ForeColor = System.Drawing.Color.Red;
            this.radioBtn_Multiply.Location = new System.Drawing.Point(290, 264);
            this.radioBtn_Multiply.Name = "radioBtn_Multiply";
            this.radioBtn_Multiply.Size = new System.Drawing.Size(105, 25);
            this.radioBtn_Multiply.TabIndex = 8;
            this.radioBtn_Multiply.TabStop = true;
            this.radioBtn_Multiply.Text = "Korruta";
            this.radioBtn_Multiply.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Divide
            // 
            this.radioBtn_Divide.AutoSize = true;
            this.radioBtn_Divide.ForeColor = System.Drawing.Color.Red;
            this.radioBtn_Divide.Location = new System.Drawing.Point(290, 304);
            this.radioBtn_Divide.Name = "radioBtn_Divide";
            this.radioBtn_Divide.Size = new System.Drawing.Size(72, 25);
            this.radioBtn_Divide.TabIndex = 9;
            this.radioBtn_Divide.TabStop = true;
            this.radioBtn_Divide.Text = "Jaga";
            this.radioBtn_Divide.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Calculate.Location = new System.Drawing.Point(181, 403);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(260, 45);
            this.btn_Calculate.TabIndex = 10;
            this.btn_Calculate.Text = "Arvestada";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 474);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.radioBtn_Divide);
            this.Controls.Add(this.radioBtn_Multiply);
            this.Controls.Add(this.radioBtn_Subtract);
            this.Controls.Add(this.radioBtn_Add);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Num2);
            this.Controls.Add(this.txtBox_Num1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Minu kalkulaator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Num1;
        private System.Windows.Forms.TextBox txtBox_Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.RadioButton radioBtn_Add;
        private System.Windows.Forms.RadioButton radioBtn_Subtract;
        private System.Windows.Forms.RadioButton radioBtn_Multiply;
        private System.Windows.Forms.RadioButton radioBtn_Divide;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

