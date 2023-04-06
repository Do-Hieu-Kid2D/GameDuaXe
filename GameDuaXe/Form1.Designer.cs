using System.Windows.Forms;

namespace GameDuaXe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.car7 = new System.Windows.Forms.PictureBox();
            this.car5 = new System.Windows.Forms.PictureBox();
            this.car6 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTop1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btngioithieu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GameDuaXe.Properties.Resources.duongua;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.car7);
            this.panel2.Controls.Add(this.car5);
            this.panel2.Controls.Add(this.car6);
            this.panel2.Controls.Add(this.car4);
            this.panel2.Controls.Add(this.car3);
            this.panel2.Controls.Add(this.car2);
            this.panel2.Controls.Add(this.car1);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1754, 748);
            this.panel2.TabIndex = 3;
            // 
            // car7
            // 
            this.car7.BackgroundImage = global::GameDuaXe.Properties.Resources.thuyen;
            this.car7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car7.Location = new System.Drawing.Point(15, 585);
            this.car7.Name = "car7";
            this.car7.Size = new System.Drawing.Size(116, 66);
            this.car7.TabIndex = 7;
            this.car7.TabStop = false;
            this.car7.Visible = false;
            // 
            // car5
            // 
            this.car5.BackgroundImage = global::GameDuaXe.Properties.Resources.sieunhan;
            this.car5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car5.Location = new System.Drawing.Point(22, 406);
            this.car5.Name = "car5";
            this.car5.Size = new System.Drawing.Size(106, 69);
            this.car5.TabIndex = 6;
            this.car5.TabStop = false;
            this.car5.Visible = false;
            // 
            // car6
            // 
            this.car6.BackgroundImage = global::GameDuaXe.Properties.Resources.tac_ke;
            this.car6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car6.Location = new System.Drawing.Point(10, 507);
            this.car6.Name = "car6";
            this.car6.Size = new System.Drawing.Size(123, 54);
            this.car6.TabIndex = 5;
            this.car6.TabStop = false;
            this.car6.Visible = false;
            // 
            // car4
            // 
            this.car4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car4.BackgroundImage")));
            this.car4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car4.Location = new System.Drawing.Point(15, 316);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(116, 68);
            this.car4.TabIndex = 4;
            this.car4.TabStop = false;
            this.car4.Visible = false;
            // 
            // car3
            // 
            this.car3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car3.BackgroundImage")));
            this.car3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car3.Location = new System.Drawing.Point(26, 231);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(105, 63);
            this.car3.TabIndex = 3;
            this.car3.TabStop = false;
            this.car3.Visible = false;
            // 
            // car2
            // 
            this.car2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car2.BackgroundImage")));
            this.car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car2.Location = new System.Drawing.Point(28, 146);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(102, 63);
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            this.car2.Visible = false;
            // 
            // car1
            // 
            this.car1.BackgroundImage = global::GameDuaXe.Properties.Resources.xe1;
            this.car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car1.Location = new System.Drawing.Point(22, 74);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(108, 57);
            this.car1.TabIndex = 0;
            this.car1.TabStop = false;
            this.car1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameDuaXe.Properties.Resources.Screenshot__32_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtTop1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btngioithieu);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnDua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1754, 90);
            this.panel1.TabIndex = 2;
            // 
            // txtTop1
            // 
            this.txtTop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTop1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTop1.Location = new System.Drawing.Point(634, 10);
            this.txtTop1.Name = "txtTop1";
            this.txtTop1.Size = new System.Drawing.Size(302, 71);
            this.txtTop1.TabIndex = 8;
            this.txtTop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTop1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(1570, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 112);
            this.panel3.TabIndex = 6;
            // 
            // btngioithieu
            // 
            this.btngioithieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngioithieu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngioithieu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btngioithieu.Location = new System.Drawing.Point(1616, 21);
            this.btngioithieu.Name = "btngioithieu";
            this.btngioithieu.Size = new System.Drawing.Size(98, 44);
            this.btngioithieu.TabIndex = 5;
            this.btngioithieu.Text = "in tư";
            this.btngioithieu.UseVisualStyleBackColor = true;
            this.btngioithieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.No;
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 4;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1263, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(246, 63);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Còn gỡ đc !<";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLoad.FlatAppearance.BorderSize = 5;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(577, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(342, 67);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Show Hàng :>";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDua
            // 
            this.btnDua.AutoSize = true;
            this.btnDua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDua.Enabled = false;
            this.btnDua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDua.FlatAppearance.BorderSize = 5;
            this.btnDua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnDua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnDua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDua.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDua.Location = new System.Drawing.Point(993, 11);
            this.btnDua.Name = "btnDua";
            this.btnDua.Size = new System.Drawing.Size(218, 69);
            this.btnDua.TabIndex = 2;
            this.btnDua.Text = "Đua Đê :>";
            this.btnDua.UseVisualStyleBackColor = false;
            this.btnDua.Click += new System.EventHandler(this.btnDua_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đua Xe K quạo!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1697, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car5;
        private System.Windows.Forms.PictureBox car6;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car7;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btngioithieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTop1;
    }
}

