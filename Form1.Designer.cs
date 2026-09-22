namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGeriAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSilgi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRenk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dfgfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYDETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yUKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // pictureBox1
            //
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.buttonGeriAl);
            this.groupBox1.Controls.Add(this.buttonSilgi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.buttonRenk);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(586, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            //
            // buttonGeriAl
            //
            this.buttonGeriAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeriAl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeriAl.ImageIndex = 0;
            this.buttonGeriAl.ImageList = this.ımageList1;
            this.buttonGeriAl.Location = new System.Drawing.Point(266, 27);
            this.buttonGeriAl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGeriAl.Name = "buttonGeriAl";
            this.buttonGeriAl.Size = new System.Drawing.Size(48, 43);
            this.buttonGeriAl.TabIndex = 7;
            this.buttonGeriAl.Text = "GERİ AL";
            this.buttonGeriAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGeriAl.UseVisualStyleBackColor = false;
            this.buttonGeriAl.Click += new System.EventHandler(this.buttonGeriAl_Click);
            //
            // ımageList1
            //
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "return.png");
            this.ımageList1.Images.SetKeyName(1, "eraser.png");
            this.ımageList1.Images.SetKeyName(2, "broom.png");
            this.ımageList1.Images.SetKeyName(3, "dust.png");
            this.ımageList1.Images.SetKeyName(4, "folder.png");
            //
            // buttonSilgi
            //
            this.buttonSilgi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSilgi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSilgi.ImageIndex = 1;
            this.buttonSilgi.ImageList = this.ımageList1;
            this.buttonSilgi.Location = new System.Drawing.Point(214, 27);
            this.buttonSilgi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSilgi.Name = "buttonSilgi";
            this.buttonSilgi.Size = new System.Drawing.Size(48, 43);
            this.buttonSilgi.TabIndex = 6;
            this.buttonSilgi.Text = "SİL";
            this.buttonSilgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSilgi.UseVisualStyleBackColor = false;
            this.buttonSilgi.Click += new System.EventHandler(this.buttonSilgi_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(211, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ARAÇLAR";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(430, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "KALINLIK ";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "RENK ";
            //
            // buttonTemizle
            //
            this.buttonTemizle.BackColor = System.Drawing.Color.White;
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTemizle.ImageIndex = 2;
            this.buttonTemizle.ImageList = this.ımageList1;
            this.buttonTemizle.Location = new System.Drawing.Point(161, 27);
            this.buttonTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(48, 43);
            this.buttonTemizle.TabIndex = 2;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            //
            // comboBox1
            //
            this.comboBox1.BackColor = System.Drawing.Color.Brown;
            this.comboBox1.DropDownHeight = 500;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(401, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "2x";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //
            // buttonRenk
            //
            this.buttonRenk.BackColor = System.Drawing.Color.Black;
            this.buttonRenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenk.Location = new System.Drawing.Point(37, 27);
            this.buttonRenk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRenk.Name = "buttonRenk";
            this.buttonRenk.Size = new System.Drawing.Size(25, 25);
            this.buttonRenk.TabIndex = 0;
            this.buttonRenk.UseVisualStyleBackColor = false;
            this.buttonRenk.Click += new System.EventHandler(this.buttonRenk_Click);
            //
            // menuStrip1
            //
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgfdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            //
            // dfgfdToolStripMenuItem
            //
            this.dfgfdToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.dfgfdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYDETToolStripMenuItem,
            this.yUKLEToolStripMenuItem});
            this.dfgfdToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dfgfdToolStripMenuItem.Name = "dfgfdToolStripMenuItem";
            this.dfgfdToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.dfgfdToolStripMenuItem.Text = "DOSYA";
            //
            // kAYDETToolStripMenuItem
            //
            this.kAYDETToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.kAYDETToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.kAYDETToolStripMenuItem.Name = "kAYDETToolStripMenuItem";
            this.kAYDETToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.kAYDETToolStripMenuItem.Text = "KAYDET";
            this.kAYDETToolStripMenuItem.Click += new System.EventHandler(this.kAYDETToolStripMenuItem_Click);
            //
            // yUKLEToolStripMenuItem
            //
            this.yUKLEToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.yUKLEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.yUKLEToolStripMenuItem.Name = "yUKLEToolStripMenuItem";
            this.yUKLEToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yUKLEToolStripMenuItem.Text = "YÜKLE";
            this.yUKLEToolStripMenuItem.Click += new System.EventHandler(this.yUKLEToolStripMenuItem_Click);
            //
            // openFileDialog1
            //
            this.openFileDialog1.FileName = "openFileDialog1";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paint Drawing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRenk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dfgfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAYDETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yUKLEToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonSilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGeriAl;
    }
}
