namespace OstPathHelper
{
    partial class mainForm
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
            this.source_file_path_label = new System.Windows.Forms.Label();
            this.target_file_path_label = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.original_file_path_txt = new System.Windows.Forms.TextBox();
            this.target_file_path_txt = new System.Windows.Forms.TextBox();
            this.source_file_path_btn = new System.Windows.Forms.Button();
            this.target_file_path_btn = new System.Windows.Forms.Button();
            this.go_btn = new System.Windows.Forms.Button();
            this.close_outlook_process_btn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_file_path_label
            // 
            this.source_file_path_label.AutoSize = true;
            this.source_file_path_label.Location = new System.Drawing.Point(10, 18);
            this.source_file_path_label.Name = "source_file_path_label";
            this.source_file_path_label.Size = new System.Drawing.Size(90, 13);
            this.source_file_path_label.TabIndex = 0;
            this.source_file_path_label.Text = "Source_file_path:";
            // 
            // target_file_path_label
            // 
            this.target_file_path_label.AutoSize = true;
            this.target_file_path_label.Location = new System.Drawing.Point(10, 50);
            this.target_file_path_label.Name = "target_file_path_label";
            this.target_file_path_label.Size = new System.Drawing.Size(84, 13);
            this.target_file_path_label.TabIndex = 1;
            this.target_file_path_label.Text = "Target file path: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 112);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_label
            // 
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(152, 17);
            this.status_label.Text = "Outlook process not found.";
            // 
            // original_file_path_txt
            // 
            this.original_file_path_txt.Location = new System.Drawing.Point(100, 15);
            this.original_file_path_txt.Name = "original_file_path_txt";
            this.original_file_path_txt.Size = new System.Drawing.Size(411, 20);
            this.original_file_path_txt.TabIndex = 3;
            // 
            // target_file_path_txt
            // 
            this.target_file_path_txt.Location = new System.Drawing.Point(100, 46);
            this.target_file_path_txt.Name = "target_file_path_txt";
            this.target_file_path_txt.Size = new System.Drawing.Size(411, 20);
            this.target_file_path_txt.TabIndex = 4;
            // 
            // source_file_path_btn
            // 
            this.source_file_path_btn.Location = new System.Drawing.Point(517, 13);
            this.source_file_path_btn.Name = "source_file_path_btn";
            this.source_file_path_btn.Size = new System.Drawing.Size(33, 23);
            this.source_file_path_btn.TabIndex = 5;
            this.source_file_path_btn.Text = "...";
            this.source_file_path_btn.UseVisualStyleBackColor = true;
            this.source_file_path_btn.Click += new System.EventHandler(this.Original_file_path_btn_Click);
            // 
            // target_file_path_btn
            // 
            this.target_file_path_btn.Location = new System.Drawing.Point(517, 44);
            this.target_file_path_btn.Name = "target_file_path_btn";
            this.target_file_path_btn.Size = new System.Drawing.Size(33, 23);
            this.target_file_path_btn.TabIndex = 6;
            this.target_file_path_btn.Text = "...";
            this.target_file_path_btn.UseVisualStyleBackColor = true;
            this.target_file_path_btn.Click += new System.EventHandler(this.Target_file_path_btn_Click);
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(517, 73);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(75, 23);
            this.go_btn.TabIndex = 7;
            this.go_btn.Text = "Go!";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.Go_btn_Click);
            // 
            // close_outlook_process_btn
            // 
            this.close_outlook_process_btn.Location = new System.Drawing.Point(12, 73);
            this.close_outlook_process_btn.Name = "close_outlook_process_btn";
            this.close_outlook_process_btn.Size = new System.Drawing.Size(158, 23);
            this.close_outlook_process_btn.TabIndex = 8;
            this.close_outlook_process_btn.Text = "Close Outlook process";
            this.close_outlook_process_btn.UseVisualStyleBackColor = true;
            this.close_outlook_process_btn.Click += new System.EventHandler(this.Close_outlook_process_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 134);
            this.Controls.Add(this.close_outlook_process_btn);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.target_file_path_btn);
            this.Controls.Add(this.source_file_path_btn);
            this.Controls.Add(this.target_file_path_txt);
            this.Controls.Add(this.original_file_path_txt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.target_file_path_label);
            this.Controls.Add(this.source_file_path_label);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OstPathHelper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label source_file_path_label;
        private System.Windows.Forms.Label target_file_path_label;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_label;
        private System.Windows.Forms.TextBox original_file_path_txt;
        private System.Windows.Forms.TextBox target_file_path_txt;
        private System.Windows.Forms.Button source_file_path_btn;
        private System.Windows.Forms.Button target_file_path_btn;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Button close_outlook_process_btn;
    }
}

