namespace Send
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radWorking = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radOnHold = new System.Windows.Forms.RadioButton();
            this.radStop = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(334, 236);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 39);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Insert";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 64);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(126, 22);
            this.txtType.TabIndex = 2;
            this.txtType.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(120, 26);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(126, 22);
            this.txtMachineName.TabIndex = 3;
            this.txtMachineName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 179);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radWorking
            // 
            this.radWorking.AutoSize = true;
            this.radWorking.Location = new System.Drawing.Point(120, 129);
            this.radWorking.Name = "radWorking";
            this.radWorking.Size = new System.Drawing.Size(81, 21);
            this.radWorking.TabIndex = 8;
            this.radWorking.TabStop = true;
            this.radWorking.Text = "Working";
            this.radWorking.UseVisualStyleBackColor = true;
            this.radWorking.CheckedChanged += new System.EventHandler(this.radWorking_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // radOnHold
            // 
            this.radOnHold.AutoSize = true;
            this.radOnHold.Location = new System.Drawing.Point(122, 175);
            this.radOnHold.Name = "radOnHold";
            this.radOnHold.Size = new System.Drawing.Size(79, 21);
            this.radOnHold.TabIndex = 10;
            this.radOnHold.TabStop = true;
            this.radOnHold.Text = "On hold";
            this.radOnHold.UseVisualStyleBackColor = true;
            this.radOnHold.CheckedChanged += new System.EventHandler(this.radOnHold_CheckedChanged);
            // 
            // radStop
            // 
            this.radStop.AutoSize = true;
            this.radStop.Location = new System.Drawing.Point(122, 219);
            this.radStop.Name = "radStop";
            this.radStop.Size = new System.Drawing.Size(58, 21);
            this.radStop.TabIndex = 11;
            this.radStop.TabStop = true;
            this.radStop.Text = "Stop";
            this.radStop.UseVisualStyleBackColor = true;
            this.radStop.CheckedChanged += new System.EventHandler(this.radStop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 385);
            this.Controls.Add(this.radStop);
            this.Controls.Add(this.radOnHold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radWorking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radWorking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radOnHold;
        private System.Windows.Forms.RadioButton radStop;
    }
}

