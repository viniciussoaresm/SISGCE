namespace Boca_Junior___Gerencia_de_quadras
{
    partial class ReservasData
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
            this.dgvReservasData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUADRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservasData
            // 
            this.dgvReservasData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvReservasData.AllowUserToAddRows = false;
            this.dgvReservasData.AllowUserToDeleteRows = false;
            this.dgvReservasData.AllowUserToResizeColumns = false;
            this.dgvReservasData.AllowUserToResizeRows = false;
            this.dgvReservasData.CausesValidation = false;
            this.dgvReservasData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA,
            this.ENTRADA,
            this.SAIDA,
            this.QUADRA});
            this.dgvReservasData.Enabled = false;
            this.dgvReservasData.Location = new System.Drawing.Point(28, 73);
            this.dgvReservasData.Name = "dgvReservasData";
            this.dgvReservasData.Size = new System.Drawing.Size(442, 210);
            this.dgvReservasData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HORARIO RESERVADOS PARA DATA ";
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            // 
            // ENTRADA
            // 
            this.ENTRADA.HeaderText = "ENTRADA";
            this.ENTRADA.Name = "ENTRADA";
            // 
            // SAIDA
            // 
            this.SAIDA.HeaderText = "SAIDA";
            this.SAIDA.Name = "SAIDA";
            // 
            // QUADRA
            // 
            this.QUADRA.HeaderText = "QUADRA";
            this.QUADRA.Name = "QUADRA";
            // 
            // ReservasData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservasData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasData";
            this.Text = "ReservasData";
            this.Load += new System.EventHandler(this.ReservasData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUADRA;
        private System.Windows.Forms.DataGridView dgvReservasData;
    }
}