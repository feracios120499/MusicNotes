namespace MusicNotes
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRecording = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonStop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(1507, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 37);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 37);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1557, 264);
            this.panel2.TabIndex = 2;
            // 
            // buttonRecording
            // 
            this.buttonRecording.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonRecording.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecording.BorderRadius = 0;
            this.buttonRecording.ButtonText = "Recording";
            this.buttonRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecording.DisabledColor = System.Drawing.Color.Gray;
            this.buttonRecording.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonRecording.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonRecording.Iconimage")));
            this.buttonRecording.Iconimage_right = null;
            this.buttonRecording.Iconimage_right_Selected = null;
            this.buttonRecording.Iconimage_Selected = null;
            this.buttonRecording.IconMarginLeft = 0;
            this.buttonRecording.IconMarginRight = 0;
            this.buttonRecording.IconRightVisible = true;
            this.buttonRecording.IconRightZoom = 0D;
            this.buttonRecording.IconVisible = true;
            this.buttonRecording.IconZoom = 90D;
            this.buttonRecording.IsTab = false;
            this.buttonRecording.Location = new System.Drawing.Point(403, 436);
            this.buttonRecording.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRecording.Name = "buttonRecording";
            this.buttonRecording.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonRecording.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonRecording.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonRecording.selected = false;
            this.buttonRecording.Size = new System.Drawing.Size(236, 59);
            this.buttonRecording.TabIndex = 3;
            this.buttonRecording.Text = "Recording";
            this.buttonRecording.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecording.Textcolor = System.Drawing.Color.White;
            this.buttonRecording.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecording.Click += new System.EventHandler(this.buttonRecording_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.BorderRadius = 0;
            this.buttonStop.ButtonText = "Stop Recording";
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.DisabledColor = System.Drawing.Color.Gray;
            this.buttonStop.Enabled = false;
            this.buttonStop.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonStop.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonStop.Iconimage")));
            this.buttonStop.Iconimage_right = null;
            this.buttonStop.Iconimage_right_Selected = null;
            this.buttonStop.Iconimage_Selected = null;
            this.buttonStop.IconMarginLeft = 0;
            this.buttonStop.IconMarginRight = 0;
            this.buttonStop.IconRightVisible = true;
            this.buttonStop.IconRightZoom = 0D;
            this.buttonStop.IconVisible = true;
            this.buttonStop.IconZoom = 90D;
            this.buttonStop.IsTab = false;
            this.buttonStop.Location = new System.Drawing.Point(663, 436);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonStop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonStop.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonStop.selected = false;
            this.buttonStop.Size = new System.Drawing.Size(236, 59);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop Recording";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.Textcolor = System.Drawing.Color.White;
            this.buttonStop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.BorderRadius = 0;
            this.buttonSave.ButtonText = "Save as";
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSave.Enabled = false;
            this.buttonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSave.Iconimage")));
            this.buttonSave.Iconimage_right = null;
            this.buttonSave.Iconimage_right_Selected = null;
            this.buttonSave.Iconimage_Selected = null;
            this.buttonSave.IconMarginLeft = 0;
            this.buttonSave.IconMarginRight = 0;
            this.buttonSave.IconRightVisible = true;
            this.buttonSave.IconRightZoom = 0D;
            this.buttonSave.IconVisible = true;
            this.buttonSave.IconZoom = 90D;
            this.buttonSave.IsTab = false;
            this.buttonSave.Location = new System.Drawing.Point(920, 436);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSave.selected = false;
            this.buttonSave.Size = new System.Drawing.Size(236, 59);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save as";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Textcolor = System.Drawing.Color.White;
            this.buttonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.BorderRadius = 0;
            this.buttonPlay.ButtonText = "Play";
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Iconimage")));
            this.buttonPlay.Iconimage_right = null;
            this.buttonPlay.Iconimage_right_Selected = null;
            this.buttonPlay.Iconimage_Selected = null;
            this.buttonPlay.IconMarginLeft = 0;
            this.buttonPlay.IconMarginRight = 0;
            this.buttonPlay.IconRightVisible = true;
            this.buttonPlay.IconRightZoom = 0D;
            this.buttonPlay.IconVisible = true;
            this.buttonPlay.IconZoom = 90D;
            this.buttonPlay.IsTab = false;
            this.buttonPlay.Location = new System.Drawing.Point(146, 436);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPlay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPlay.selected = false;
            this.buttonPlay.Size = new System.Drawing.Size(236, 59);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlay.Textcolor = System.Drawing.Color.White;
            this.buttonPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 750);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRecording);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPlay;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSave;
        private Bunifu.Framework.UI.BunifuFlatButton buttonStop;
        private Bunifu.Framework.UI.BunifuFlatButton buttonRecording;
    }
}