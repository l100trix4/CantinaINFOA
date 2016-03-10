namespace WindowsFormsApplication1
{
    partial class FormPrincipal
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
            this.NomeLabel = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.MatriculaBox = new System.Windows.Forms.TextBox();
            this.MatriculaLabel = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.GravarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(13, 13);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(38, 13);
            this.NomeLabel.TabIndex = 0;
            this.NomeLabel.Text = "Nome:";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(68, 10);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(668, 20);
            this.NomeBox.TabIndex = 1;
            this.NomeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MatriculaBox
            // 
            this.MatriculaBox.Location = new System.Drawing.Point(68, 36);
            this.MatriculaBox.Name = "MatriculaBox";
            this.MatriculaBox.Size = new System.Drawing.Size(668, 20);
            this.MatriculaBox.TabIndex = 2;
            // 
            // MatriculaLabel
            // 
            this.MatriculaLabel.AutoSize = true;
            this.MatriculaLabel.Location = new System.Drawing.Point(13, 39);
            this.MatriculaLabel.Name = "MatriculaLabel";
            this.MatriculaLabel.Size = new System.Drawing.Size(53, 13);
            this.MatriculaLabel.TabIndex = 3;
            this.MatriculaLabel.Text = "Matricula:";
            // 
            // NovoButton
            // 
            this.NovoButton.Location = new System.Drawing.Point(271, 62);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(75, 23);
            this.NovoButton.TabIndex = 4;
            this.NovoButton.Text = "Novo";
            this.NovoButton.UseVisualStyleBackColor = true;
            // 
            // GravarButton
            // 
            this.GravarButton.Location = new System.Drawing.Point(352, 62);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(75, 23);
            this.GravarButton.TabIndex = 5;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(433, 62);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 6;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.GravarButton);
            this.Controls.Add(this.NovoButton);
            this.Controls.Add(this.MatriculaLabel);
            this.Controls.Add(this.MatriculaBox);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.NomeLabel);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox MatriculaBox;
        private System.Windows.Forms.Label MatriculaLabel;
        private System.Windows.Forms.Button NovoButton;
        private System.Windows.Forms.Button GravarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

