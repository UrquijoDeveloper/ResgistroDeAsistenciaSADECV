
namespace ResgistroDeAsistenciaSADECV
{
    partial class ReporteForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmarJustificante_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.motivoJustificante_Lbl = new System.Windows.Forms.Label();
            this.codigo_Tbx = new System.Windows.Forms.TextBox();
            this.codigo_Lbl = new System.Windows.Forms.Label();
            this.motivoJustificante_Rtbx = new System.Windows.Forms.RichTextBox();
            this.general_Rbtn = new System.Windows.Forms.RadioButton();
            this.particular_Rbtn = new System.Windows.Forms.RadioButton();
            this.fechaJustificante_monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de asistencias:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmarJustificante_Btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.motivoJustificante_Lbl);
            this.groupBox1.Controls.Add(this.codigo_Tbx);
            this.groupBox1.Controls.Add(this.codigo_Lbl);
            this.groupBox1.Controls.Add(this.motivoJustificante_Rtbx);
            this.groupBox1.Controls.Add(this.general_Rbtn);
            this.groupBox1.Controls.Add(this.particular_Rbtn);
            this.groupBox1.Controls.Add(this.fechaJustificante_monthCalendar);
            this.groupBox1.Location = new System.Drawing.Point(23, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 334);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seccion Justificantes";
            // 
            // confirmarJustificante_Btn
            // 
            this.confirmarJustificante_Btn.Location = new System.Drawing.Point(852, 265);
            this.confirmarJustificante_Btn.Name = "confirmarJustificante_Btn";
            this.confirmarJustificante_Btn.Size = new System.Drawing.Size(131, 44);
            this.confirmarJustificante_Btn.TabIndex = 5;
            this.confirmarJustificante_Btn.Text = "Confirmar Justificante";
            this.confirmarJustificante_Btn.UseVisualStyleBackColor = true;
            this.confirmarJustificante_Btn.Click += new System.EventHandler(this.confirmarJustificante_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrese la fecha del Justificante:";
            // 
            // motivoJustificante_Lbl
            // 
            this.motivoJustificante_Lbl.AutoSize = true;
            this.motivoJustificante_Lbl.Location = new System.Drawing.Point(10, 265);
            this.motivoJustificante_Lbl.Name = "motivoJustificante_Lbl";
            this.motivoJustificante_Lbl.Size = new System.Drawing.Size(163, 13);
            this.motivoJustificante_Lbl.TabIndex = 11;
            this.motivoJustificante_Lbl.Text = "Ingrese el motivo del Justificante:";
            // 
            // codigo_Tbx
            // 
            this.codigo_Tbx.Location = new System.Drawing.Point(148, 115);
            this.codigo_Tbx.Name = "codigo_Tbx";
            this.codigo_Tbx.Size = new System.Drawing.Size(100, 20);
            this.codigo_Tbx.TabIndex = 10;
            this.codigo_Tbx.Visible = false;
            // 
            // codigo_Lbl
            // 
            this.codigo_Lbl.AutoSize = true;
            this.codigo_Lbl.Location = new System.Drawing.Point(37, 115);
            this.codigo_Lbl.Name = "codigo_Lbl";
            this.codigo_Lbl.Size = new System.Drawing.Size(94, 13);
            this.codigo_Lbl.TabIndex = 9;
            this.codigo_Lbl.Text = "Ingrese su codigo:";
            this.codigo_Lbl.Visible = false;
            // 
            // motivoJustificante_Rtbx
            // 
            this.motivoJustificante_Rtbx.Location = new System.Drawing.Point(191, 220);
            this.motivoJustificante_Rtbx.Name = "motivoJustificante_Rtbx";
            this.motivoJustificante_Rtbx.Size = new System.Drawing.Size(482, 96);
            this.motivoJustificante_Rtbx.TabIndex = 8;
            this.motivoJustificante_Rtbx.Text = "";
            // 
            // general_Rbtn
            // 
            this.general_Rbtn.AutoSize = true;
            this.general_Rbtn.Location = new System.Drawing.Point(161, 56);
            this.general_Rbtn.Name = "general_Rbtn";
            this.general_Rbtn.Size = new System.Drawing.Size(62, 17);
            this.general_Rbtn.TabIndex = 6;
            this.general_Rbtn.TabStop = true;
            this.general_Rbtn.Text = "General";
            this.general_Rbtn.UseVisualStyleBackColor = true;
            this.general_Rbtn.CheckedChanged += new System.EventHandler(this.general_Rbtn_CheckedChanged);
            // 
            // particular_Rbtn
            // 
            this.particular_Rbtn.AutoSize = true;
            this.particular_Rbtn.Location = new System.Drawing.Point(40, 56);
            this.particular_Rbtn.Name = "particular_Rbtn";
            this.particular_Rbtn.Size = new System.Drawing.Size(69, 17);
            this.particular_Rbtn.TabIndex = 5;
            this.particular_Rbtn.TabStop = true;
            this.particular_Rbtn.Text = "Particular";
            this.particular_Rbtn.UseVisualStyleBackColor = true;
            this.particular_Rbtn.CheckedChanged += new System.EventHandler(this.particular_Rbtn_CheckedChanged);
            // 
            // fechaJustificante_monthCalendar
            // 
            this.fechaJustificante_monthCalendar.Location = new System.Drawing.Point(735, 38);
            this.fechaJustificante_monthCalendar.Name = "fechaJustificante_monthCalendar";
            this.fechaJustificante_monthCalendar.TabIndex = 4;
            this.fechaJustificante_monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.fechaJustificante_monthCalendar_DateChanged);
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReporteForm";
            this.Text = "ReporteForm";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmarJustificante_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label motivoJustificante_Lbl;
        private System.Windows.Forms.TextBox codigo_Tbx;
        private System.Windows.Forms.Label codigo_Lbl;
        private System.Windows.Forms.RichTextBox motivoJustificante_Rtbx;
        private System.Windows.Forms.RadioButton general_Rbtn;
        private System.Windows.Forms.RadioButton particular_Rbtn;
        private System.Windows.Forms.MonthCalendar fechaJustificante_monthCalendar;
    }
}