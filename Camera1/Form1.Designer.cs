namespace Camera1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_frame = new System.Windows.Forms.PictureBox();
            this.btn_capture = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_devices = new System.Windows.Forms.Label();
            this.cb_devices = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_frame
            // 
            this.pb_frame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_frame.Location = new System.Drawing.Point(189, 8);
            this.pb_frame.Name = "pb_frame";
            this.pb_frame.Size = new System.Drawing.Size(341, 256);
            this.pb_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_frame.TabIndex = 0;
            this.pb_frame.TabStop = false;
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(13, 144);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(157, 30);
            this.btn_capture.TabIndex = 1;
            this.btn_capture.Text = "Start";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 180);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(157, 30);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_devices
            // 
            this.lb_devices.AutoSize = true;
            this.lb_devices.Location = new System.Drawing.Point(10, 7);
            this.lb_devices.Name = "lb_devices";
            this.lb_devices.Size = new System.Drawing.Size(46, 13);
            this.lb_devices.TabIndex = 3;
            this.lb_devices.Text = "Devices";
            // 
            // cb_devices
            // 
            this.cb_devices.FormattingEnabled = true;
            this.cb_devices.Location = new System.Drawing.Point(10, 23);
            this.cb_devices.Name = "cb_devices";
            this.cb_devices.Size = new System.Drawing.Size(157, 21);
            this.cb_devices.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(13, 216);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(157, 30);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_devices);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_capture);
            this.panel1.Controls.Add(this.cb_devices);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 270);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_frame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_frame;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_devices;
        private System.Windows.Forms.ComboBox cb_devices;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
    }
}

