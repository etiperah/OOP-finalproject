namespace finalproject
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pictureBox_purple = new System.Windows.Forms.PictureBox();
            pictureBox_green = new System.Windows.Forms.PictureBox();
            pictureBox_blue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_purple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_blue).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_purple
            // 
            pictureBox_purple.BackgroundImage = Properties.Resources.purplebook;
            pictureBox_purple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox_purple.Location = new System.Drawing.Point(157, 347);
            pictureBox_purple.Name = "pictureBox_purple";
            pictureBox_purple.Size = new System.Drawing.Size(105, 106);
            pictureBox_purple.TabIndex = 0;
            pictureBox_purple.TabStop = false;
        
            pictureBox_purple.Paint += pictureBox_purple_Paint;
            pictureBox_purple.MouseDown += pictureBox_purple_MouseDown;
            pictureBox_purple.MouseMove += pictureBox_purple_MouseMove;
            pictureBox_purple.MouseUp += pictureBox_purple_MouseUp;
          
            // 
            // pictureBox_green
            // 
            pictureBox_green.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox_green.BackgroundImage");
            pictureBox_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox_green.Location = new System.Drawing.Point(344, 347);
            pictureBox_green.Name = "pictureBox_green";
            pictureBox_green.Size = new System.Drawing.Size(105, 106);
            pictureBox_green.TabIndex = 1;
            pictureBox_green.TabStop = false;
            pictureBox_green.MouseDown += pictureBox_green_MouseDown;
            pictureBox_green.MouseMove += pictureBox_green_MouseMove;
            pictureBox_green.MouseUp += pictureBox_green_MouseUp;
            // 
            // pictureBox_blue
            // 
            pictureBox_blue.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox_blue.BackgroundImage");
            pictureBox_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox_blue.Location = new System.Drawing.Point(533, 347);
            pictureBox_blue.Name = "pictureBox_blue";
            pictureBox_blue.Size = new System.Drawing.Size(105, 106);
            pictureBox_blue.TabIndex = 2;
            pictureBox_blue.TabStop = false;
            pictureBox_blue.MouseDown += pictureBox_blue_MouseDown;
            pictureBox_blue.MouseMove += pictureBox_blue_MouseMove;
            pictureBox_blue.MouseUp += pictureBox_blue_MouseUp;
            // 
            // Game
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shelf;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox_blue);
            Controls.Add(pictureBox_green);
            Controls.Add(pictureBox_purple);
            MaximumSize = new System.Drawing.Size(822, 506);
            MinimumSize = new System.Drawing.Size(822, 506);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_purple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_blue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_purple;
        private System.Windows.Forms.PictureBox pictureBox_green;
        private System.Windows.Forms.PictureBox pictureBox_blue;
    }
}