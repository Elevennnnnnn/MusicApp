
namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Open = new System.Windows.Forms.Button();
            this.label_start = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Download_List = new System.Windows.Forms.ListBox();
            this.Track_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_volume = new System.Windows.Forms.Label();
            this.Volume_bar = new System.Windows.Forms.TrackBar();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(885, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 44);
            this.label2.TabIndex = 28;
            this.label2.Text = "XI Music App";
            // 
            // btn_Open
            // 
            this.btn_Open.AutoSize = true;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.ForeColor = System.Drawing.Color.Lime;
            this.btn_Open.Location = new System.Drawing.Point(607, 505);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(179, 31);
            this.btn_Open.TabIndex = 27;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.BackColor = System.Drawing.Color.Black;
            this.label_start.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.ForeColor = System.Drawing.Color.Lime;
            this.label_start.Location = new System.Drawing.Point(4, 111);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(116, 48);
            this.label_start.TabIndex = 25;
            this.label_start.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(8, 481);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(777, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 24;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // btn_Stop
            // 
            this.btn_Stop.AutoSize = true;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.ForeColor = System.Drawing.Color.Lime;
            this.btn_Stop.Location = new System.Drawing.Point(503, 505);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(99, 31);
            this.btn_Stop.TabIndex = 23;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.AutoSize = true;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.ForeColor = System.Drawing.Color.Lime;
            this.btn_Pause.Location = new System.Drawing.Point(385, 505);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(112, 31);
            this.btn_Pause.TabIndex = 22;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.AutoSize = true;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ForeColor = System.Drawing.Color.Lime;
            this.btn_Play.Location = new System.Drawing.Point(259, 505);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(121, 31);
            this.btn_Play.TabIndex = 21;
            this.btn_Play.Text = "Play";
            this.btn_Play.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AutoSize = true;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ForeColor = System.Drawing.Color.Lime;
            this.btn_Next.Location = new System.Drawing.Point(136, 505);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(117, 31);
            this.btn_Next.TabIndex = 20;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.AutoSize = true;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.Color.Lime;
            this.btn_prev.Location = new System.Drawing.Point(8, 505);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(123, 31);
            this.btn_prev.TabIndex = 19;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Download_List);
            this.panel1.Controls.Add(this.Track_List);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_volume);
            this.panel1.Controls.Add(this.Volume_bar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 313);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Dianhac4;
            this.pictureBox1.Location = new System.Drawing.Point(35, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(856, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Download list";
            // 
            // Download_List
            // 
            this.Download_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Download_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Download_List.FormattingEnabled = true;
            this.Download_List.ItemHeight = 16;
            this.Download_List.Items.AddRange(new object[] {
            "One call away - Charlie Puth",
            "The nights - Avicii",
            "Waiting for love - Avicii",
            "Why not me - Enrique Iglesias",
            "Shape of you - Ed Sheeran",
            "Perfect - Ed Sheera",
            "At my worst - Pink $weat",
            "Memories - Maroon 5",
            "Let me down slowly - Alec Benjamin",
            "Believer - Imagine Dragons"});
            this.Download_List.Location = new System.Drawing.Point(856, 2);
            this.Download_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Download_List.Name = "Download_List";
            this.Download_List.Size = new System.Drawing.Size(297, 276);
            this.Download_List.TabIndex = 13;
            this.Download_List.SelectedIndexChanged += new System.EventHandler(this.Download_List_SelectedIndexChanged);
            // 
            // Track_List
            // 
            this.Track_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Track_List.ForeColor = System.Drawing.Color.White;
            this.Track_List.FormattingEnabled = true;
            this.Track_List.ItemHeight = 16;
            this.Track_List.Location = new System.Drawing.Point(353, 2);
            this.Track_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Track_List.Name = "Track_List";
            this.Track_List.Size = new System.Drawing.Size(431, 276);
            this.Track_List.TabIndex = 9;
            this.Track_List.SelectedIndexChanged += new System.EventHandler(this.Track_List_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(787, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.BackColor = System.Drawing.Color.LightGreen;
            this.label_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.ForeColor = System.Drawing.Color.White;
            this.label_volume.Location = new System.Drawing.Point(799, 14);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(35, 17);
            this.label_volume.TabIndex = 12;
            this.label_volume.Text = "100";
            // 
            // Volume_bar
            // 
            this.Volume_bar.BackColor = System.Drawing.Color.LightGreen;
            this.Volume_bar.Location = new System.Drawing.Point(791, 32);
            this.Volume_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volume_bar.Maximum = 100;
            this.Volume_bar.Name = "Volume_bar";
            this.Volume_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Volume_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Volume_bar.Size = new System.Drawing.Size(56, 247);
            this.Volume_bar.TabIndex = 7;
            this.Volume_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume_bar.Scroll += new System.EventHandler(this.Volume_bar_Scroll);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(1, 0);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(865, 128);
            this.Player.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1155, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "XI Music App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Download_List;
        private System.Windows.Forms.ListBox Track_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.TrackBar Volume_bar;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

