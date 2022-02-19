
namespace CuCo_POS
{
    partial class ContainerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerPage));
            this.panelsContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelsContainer
            // 
            this.panelsContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelsContainer.Name = "panelsContainer";
            this.panelsContainer.Size = new System.Drawing.Size(1288, 581);
            this.panelsContainer.TabIndex = 6;
            // 
            // ContainerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 581);
            this.ControlBox = false;
            this.Controls.Add(this.panelsContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContainerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContainerPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelsContainer;
    }
}

