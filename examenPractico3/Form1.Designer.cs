namespace practice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Fahrenheit = new System.Windows.Forms.Label();
            this.lbl_Celsius = new System.Windows.Forms.Label();
            this.lbl_Rawvalue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OnLed = new System.Windows.Forms.Button();
            this.btn_OffLed = new System.Windows.Forms.Button();
            this.btn_OnServo = new System.Windows.Forms.Button();
            this.btn_OffServo = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(145, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Date
            // 
            this.tb_Date.Location = new System.Drawing.Point(145, 59);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(100, 20);
            this.tb_Date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura";
            // 
            // lbl_Fahrenheit
            // 
            this.lbl_Fahrenheit.AutoSize = true;
            this.lbl_Fahrenheit.Location = new System.Drawing.Point(548, 77);
            this.lbl_Fahrenheit.Name = "lbl_Fahrenheit";
            this.lbl_Fahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lbl_Fahrenheit.TabIndex = 3;
            this.lbl_Fahrenheit.Text = "Fahrenheit";
            // 
            // lbl_Celsius
            // 
            this.lbl_Celsius.AutoSize = true;
            this.lbl_Celsius.Location = new System.Drawing.Point(548, 48);
            this.lbl_Celsius.Name = "lbl_Celsius";
            this.lbl_Celsius.Size = new System.Drawing.Size(40, 13);
            this.lbl_Celsius.TabIndex = 4;
            this.lbl_Celsius.Text = "Celsius";
            // 
            // lbl_Rawvalue
            // 
            this.lbl_Rawvalue.AutoSize = true;
            this.lbl_Rawvalue.Location = new System.Drawing.Point(548, 105);
            this.lbl_Rawvalue.Name = "lbl_Rawvalue";
            this.lbl_Rawvalue.Size = new System.Drawing.Size(68, 13);
            this.lbl_Rawvalue.TabIndex = 5;
            this.lbl_Rawvalue.Text = "RAWVALUE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Control Luz Led";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Control Servomotor";
            // 
            // btn_OnLed
            // 
            this.btn_OnLed.Location = new System.Drawing.Point(12, 342);
            this.btn_OnLed.Name = "btn_OnLed";
            this.btn_OnLed.Size = new System.Drawing.Size(87, 40);
            this.btn_OnLed.TabIndex = 11;
            this.btn_OnLed.Text = "Encender";
            this.btn_OnLed.UseVisualStyleBackColor = true;
            this.btn_OnLed.Click += new System.EventHandler(this.btn_OnLed_Click_1);
            // 
            // btn_OffLed
            // 
            this.btn_OffLed.Location = new System.Drawing.Point(105, 342);
            this.btn_OffLed.Name = "btn_OffLed";
            this.btn_OffLed.Size = new System.Drawing.Size(87, 40);
            this.btn_OffLed.TabIndex = 12;
            this.btn_OffLed.Text = "Apagar";
            this.btn_OffLed.UseVisualStyleBackColor = true;
            this.btn_OffLed.Click += new System.EventHandler(this.btn_OffLed_Click_1);
            // 
            // btn_OnServo
            // 
            this.btn_OnServo.Location = new System.Drawing.Point(460, 342);
            this.btn_OnServo.Name = "btn_OnServo";
            this.btn_OnServo.Size = new System.Drawing.Size(87, 40);
            this.btn_OnServo.TabIndex = 13;
            this.btn_OnServo.Text = "Encender";
            this.btn_OnServo.UseVisualStyleBackColor = true;
            this.btn_OnServo.Click += new System.EventHandler(this.btn_OnServo_Click_1);
            // 
            // btn_OffServo
            // 
            this.btn_OffServo.Location = new System.Drawing.Point(573, 342);
            this.btn_OffServo.Name = "btn_OffServo";
            this.btn_OffServo.Size = new System.Drawing.Size(87, 40);
            this.btn_OffServo.TabIndex = 14;
            this.btn_OffServo.Text = "Apagar";
            this.btn_OffServo.UseVisualStyleBackColor = true;
            this.btn_OffServo.Click += new System.EventHandler(this.btn_OffServo_Click_1);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(82, 117);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 15;
            this.btn_Connect.Text = "Conectar";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click_1);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(211, 117);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(90, 23);
            this.btn_Disconnect.TabIndex = 16;
            this.btn_Disconnect.Text = "Desconectar";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click_1);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(343, 38);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(35, 13);
            this.lbl_Status.TabIndex = 18;
            this.lbl_Status.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_OffServo);
            this.Controls.Add(this.btn_OnServo);
            this.Controls.Add(this.btn_OffLed);
            this.Controls.Add(this.btn_OnLed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Rawvalue);
            this.Controls.Add(this.lbl_Celsius);
            this.Controls.Add(this.lbl_Fahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Fahrenheit;
        private System.Windows.Forms.Label lbl_Celsius;
        private System.Windows.Forms.Label lbl_Rawvalue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OnLed;
        private System.Windows.Forms.Button btn_OffLed;
        private System.Windows.Forms.Button btn_OnServo;
        private System.Windows.Forms.Button btn_OffServo;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Label lbl_Status;
    }
}

