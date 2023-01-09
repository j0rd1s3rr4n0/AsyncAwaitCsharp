namespace AsyncCsharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstb_FolderOne = new System.Windows.Forms.ListBox();
            this.lstb_FolderTwo = new System.Windows.Forms.ListBox();
            this.tv_CarpetaOne = new System.Windows.Forms.Label();
            this.tv_CarpetaTwo = new System.Windows.Forms.Label();
            this.btn_OpenFolderOne = new System.Windows.Forms.Button();
            this.btn_OpenFolderTawo = new System.Windows.Forms.Button();
            this.tb_TimerFolderOne = new System.Windows.Forms.TextBox();
            this.tb_TimerFolderTwo = new System.Windows.Forms.TextBox();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.btn_showHora = new System.Windows.Forms.Button();
            this.tb_time_folderTwo = new System.Windows.Forms.TextBox();
            this.tb_time_folderOne = new System.Windows.Forms.TextBox();
            this.btn_FileListTwo = new System.Windows.Forms.Button();
            this.btn_FileListOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_show_path_collection = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstb_FolderOne
            // 
            this.lstb_FolderOne.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstb_FolderOne.FormattingEnabled = true;
            this.lstb_FolderOne.ItemHeight = 12;
            this.lstb_FolderOne.Location = new System.Drawing.Point(30, 53);
            this.lstb_FolderOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstb_FolderOne.Name = "lstb_FolderOne";
            this.lstb_FolderOne.Size = new System.Drawing.Size(358, 184);
            this.lstb_FolderOne.TabIndex = 0;
            // 
            // lstb_FolderTwo
            // 
            this.lstb_FolderTwo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstb_FolderTwo.FormattingEnabled = true;
            this.lstb_FolderTwo.ItemHeight = 12;
            this.lstb_FolderTwo.Location = new System.Drawing.Point(424, 55);
            this.lstb_FolderTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstb_FolderTwo.Name = "lstb_FolderTwo";
            this.lstb_FolderTwo.Size = new System.Drawing.Size(358, 184);
            this.lstb_FolderTwo.TabIndex = 1;
            // 
            // tv_CarpetaOne
            // 
            this.tv_CarpetaOne.AutoSize = true;
            this.tv_CarpetaOne.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tv_CarpetaOne.Location = new System.Drawing.Point(30, 17);
            this.tv_CarpetaOne.Name = "tv_CarpetaOne";
            this.tv_CarpetaOne.Size = new System.Drawing.Size(222, 30);
            this.tv_CarpetaOne.TabIndex = 2;
            this.tv_CarpetaOne.Text = "Carpeta 1: Sequencial";
            // 
            // tv_CarpetaTwo
            // 
            this.tv_CarpetaTwo.AutoSize = true;
            this.tv_CarpetaTwo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tv_CarpetaTwo.Location = new System.Drawing.Point(424, 17);
            this.tv_CarpetaTwo.Name = "tv_CarpetaTwo";
            this.tv_CarpetaTwo.Size = new System.Drawing.Size(195, 30);
            this.tv_CarpetaTwo.TabIndex = 3;
            this.tv_CarpetaTwo.Text = "Carpeta 2: Parallels";
            // 
            // btn_OpenFolderOne
            // 
            this.btn_OpenFolderOne.Location = new System.Drawing.Point(243, 242);
            this.btn_OpenFolderOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OpenFolderOne.Name = "btn_OpenFolderOne";
            this.btn_OpenFolderOne.Size = new System.Drawing.Size(144, 20);
            this.btn_OpenFolderOne.TabIndex = 4;
            this.btn_OpenFolderOne.Text = "Abrir";
            this.btn_OpenFolderOne.UseVisualStyleBackColor = true;
            this.btn_OpenFolderOne.Click += new System.EventHandler(this.btn_OpenFolderOne_ClickA);
            // 
            // btn_OpenFolderTawo
            // 
            this.btn_OpenFolderTawo.Location = new System.Drawing.Point(638, 242);
            this.btn_OpenFolderTawo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OpenFolderTawo.Name = "btn_OpenFolderTawo";
            this.btn_OpenFolderTawo.Size = new System.Drawing.Size(144, 20);
            this.btn_OpenFolderTawo.TabIndex = 5;
            this.btn_OpenFolderTawo.Text = "Abrir";
            this.btn_OpenFolderTawo.UseVisualStyleBackColor = true;
            this.btn_OpenFolderTawo.Click += new System.EventHandler(this.btn_OpenFolderTwo_Click);
            // 
            // tb_TimerFolderOne
            // 
            this.tb_TimerFolderOne.Location = new System.Drawing.Point(32, 242);
            this.tb_TimerFolderOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimerFolderOne.Name = "tb_TimerFolderOne";
            this.tb_TimerFolderOne.Size = new System.Drawing.Size(213, 23);
            this.tb_TimerFolderOne.TabIndex = 6;
            // 
            // tb_TimerFolderTwo
            // 
            this.tb_TimerFolderTwo.Location = new System.Drawing.Point(424, 242);
            this.tb_TimerFolderTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimerFolderTwo.Name = "tb_TimerFolderTwo";
            this.tb_TimerFolderTwo.Size = new System.Drawing.Size(213, 23);
            this.tb_TimerFolderTwo.TabIndex = 7;
            // 
            // tb_hora
            // 
            this.tb_hora.Location = new System.Drawing.Point(200, 336);
            this.tb_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(248, 23);
            this.tb_hora.TabIndex = 8;
            // 
            // btn_showHora
            // 
            this.btn_showHora.Location = new System.Drawing.Point(445, 336);
            this.btn_showHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showHora.Name = "btn_showHora";
            this.btn_showHora.Size = new System.Drawing.Size(122, 23);
            this.btn_showHora.TabIndex = 9;
            this.btn_showHora.Text = "Mostrar Hora";
            this.btn_showHora.UseVisualStyleBackColor = true;
            this.btn_showHora.Click += new System.EventHandler(this.btn_showHora_Click);
            // 
            // tb_time_folderTwo
            // 
            this.tb_time_folderTwo.Location = new System.Drawing.Point(499, 267);
            this.tb_time_folderTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_time_folderTwo.Name = "tb_time_folderTwo";
            this.tb_time_folderTwo.Size = new System.Drawing.Size(284, 23);
            this.tb_time_folderTwo.TabIndex = 15;
            // 
            // tb_time_folderOne
            // 
            this.tb_time_folderOne.Location = new System.Drawing.Point(104, 267);
            this.tb_time_folderOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_time_folderOne.Name = "tb_time_folderOne";
            this.tb_time_folderOne.Size = new System.Drawing.Size(284, 23);
            this.tb_time_folderOne.TabIndex = 14;
            // 
            // btn_FileListTwo
            // 
            this.btn_FileListTwo.Location = new System.Drawing.Point(424, 290);
            this.btn_FileListTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FileListTwo.Name = "btn_FileListTwo";
            this.btn_FileListTwo.Size = new System.Drawing.Size(358, 22);
            this.btn_FileListTwo.TabIndex = 13;
            this.btn_FileListTwo.Text = "Listar Archivos";
            this.btn_FileListTwo.UseVisualStyleBackColor = true;
            this.btn_FileListTwo.Click += new System.EventHandler(this.btn_FileListTwo_Click);
            // 
            // btn_FileListOne
            // 
            this.btn_FileListOne.Location = new System.Drawing.Point(32, 290);
            this.btn_FileListOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FileListOne.Name = "btn_FileListOne";
            this.btn_FileListOne.Size = new System.Drawing.Size(358, 22);
            this.btn_FileListOne.TabIndex = 12;
            this.btn_FileListOne.Text = "Listar Archivos";
            this.btn_FileListOne.UseVisualStyleBackColor = true;
            this.btn_FileListOne.Click += new System.EventHandler(this.btn_FileListOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(424, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Duración:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Duración:";
            // 
            // cb_show_path_collection
            // 
            this.cb_show_path_collection.AutoSize = true;
            this.cb_show_path_collection.Checked = true;
            this.cb_show_path_collection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_show_path_collection.Location = new System.Drawing.Point(611, 338);
            this.cb_show_path_collection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_show_path_collection.Name = "cb_show_path_collection";
            this.cb_show_path_collection.Size = new System.Drawing.Size(159, 19);
            this.cb_show_path_collection.TabIndex = 16;
            this.cb_show_path_collection.Text = "Mostrar Ruta En Archivos";
            this.cb_show_path_collection.UseVisualStyleBackColor = true;
            this.cb_show_path_collection.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 374);
            this.Controls.Add(this.cb_show_path_collection);
            this.Controls.Add(this.tb_time_folderTwo);
            this.Controls.Add(this.tb_time_folderOne);
            this.Controls.Add(this.btn_FileListTwo);
            this.Controls.Add(this.btn_FileListOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_showHora);
            this.Controls.Add(this.tb_hora);
            this.Controls.Add(this.tb_TimerFolderTwo);
            this.Controls.Add(this.tb_TimerFolderOne);
            this.Controls.Add(this.btn_OpenFolderTawo);
            this.Controls.Add(this.btn_OpenFolderOne);
            this.Controls.Add(this.tv_CarpetaTwo);
            this.Controls.Add(this.tv_CarpetaOne);
            this.Controls.Add(this.lstb_FolderTwo);
            this.Controls.Add(this.lstb_FolderOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Skype";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstb_FolderOne;
        private ListBox lstb_FolderTwo;
        private Label tv_CarpetaOne;
        private Label tv_CarpetaTwo;
        private Button btn_OpenFolderOne;
        private Button btn_OpenFolderTawo;
        private TextBox tb_TimerFolderOne;
        private TextBox tb_TimerFolderTwo;
        private TextBox tb_hora;
        private Button btn_showHora;
        private TextBox tb_time_folderTwo;
        private TextBox tb_time_folderOne;
        private Button btn_FileListTwo;
        private Button btn_FileListOne;
        private Label label1;
        private Label label2;
        private CheckBox cb_show_path_collection;
    }
}