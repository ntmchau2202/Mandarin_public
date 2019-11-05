namespace Mandarin
{
    public partial class BeginGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeginGame));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Start_lb = new System.Windows.Forms.Label();
            this.Instruction_lb = new System.Windows.Forms.Label();
            this.Exit_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Start_lb
            // 
            this.Start_lb.AutoSize = true;
            this.Start_lb.BackColor = System.Drawing.Color.Transparent;
            this.Start_lb.Font = new System.Drawing.Font("UVN But Long 2", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_lb.ForeColor = System.Drawing.Color.DarkGreen;
            this.Start_lb.Location = new System.Drawing.Point(151, 260);
            this.Start_lb.Name = "Start_lb";
            this.Start_lb.Size = new System.Drawing.Size(111, 47);
            this.Start_lb.TabIndex = 2;
            this.Start_lb.Text = "Bắt đầu";
            this.Start_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Start_lb.Click += new System.EventHandler(this.Start_lb_Click);
            this.Start_lb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start_lb_MouseClick);
            this.Start_lb.MouseEnter += new System.EventHandler(this.Start_lb_MouseEnter);
            this.Start_lb.MouseLeave += new System.EventHandler(this.Start_lb_MouseLeave);
            // 
            // Instruction_lb
            // 
            this.Instruction_lb.AutoSize = true;
            this.Instruction_lb.BackColor = System.Drawing.Color.Transparent;
            this.Instruction_lb.Font = new System.Drawing.Font("UVN But Long 2", 24F, System.Drawing.FontStyle.Bold);
            this.Instruction_lb.ForeColor = System.Drawing.Color.DarkGreen;
            this.Instruction_lb.Location = new System.Drawing.Point(134, 346);
            this.Instruction_lb.Name = "Instruction_lb";
            this.Instruction_lb.Size = new System.Drawing.Size(145, 47);
            this.Instruction_lb.TabIndex = 3;
            this.Instruction_lb.Text = "Hướng dẫn";
            this.Instruction_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Instruction_lb.Click += new System.EventHandler(this.Instruction_lb_Click);
            this.Instruction_lb.MouseEnter += new System.EventHandler(this.Instruction_lb_MouseEnter);
            this.Instruction_lb.MouseLeave += new System.EventHandler(this.Instruction_lb_MouseLeave);
            // 
            // Exit_lb
            // 
            this.Exit_lb.AutoSize = true;
            this.Exit_lb.BackColor = System.Drawing.Color.Transparent;
            this.Exit_lb.Font = new System.Drawing.Font("UVN But Long 2", 24F, System.Drawing.FontStyle.Bold);
            this.Exit_lb.ForeColor = System.Drawing.Color.DarkGreen;
            this.Exit_lb.Location = new System.Drawing.Point(162, 433);
            this.Exit_lb.Name = "Exit_lb";
            this.Exit_lb.Size = new System.Drawing.Size(87, 47);
            this.Exit_lb.TabIndex = 4;
            this.Exit_lb.Text = "Thoát";
            this.Exit_lb.Click += new System.EventHandler(this.Exit_lb_Click);
            this.Exit_lb.MouseEnter += new System.EventHandler(this.Exit_lb_MouseEnter);
            this.Exit_lb.MouseLeave += new System.EventHandler(this.Exit_lb_MouseLeave);
            // 
            // BeginGame
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.Exit_lb);
            this.Controls.Add(this.Instruction_lb);
            this.Controls.Add(this.Start_lb);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeginGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ô Ăn quan";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start_lb;
        private System.Windows.Forms.Label Instruction_lb;
        private System.Windows.Forms.Label Exit_lb;


    }
}