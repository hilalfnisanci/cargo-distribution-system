
namespace yazlab_proje1
{
    partial class Map_Ekrani
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
            this.map2Panel = new System.Windows.Forms.Panel();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.shortPathPanel = new System.Windows.Forms.Panel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.map2Panel.SuspendLayout();
            this.shortPathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // map2Panel
            // 
            this.map2Panel.Controls.Add(this.map2);
            this.map2Panel.Location = new System.Drawing.Point(12, 12);
            this.map2Panel.Name = "map2Panel";
            this.map2Panel.Size = new System.Drawing.Size(776, 353);
            this.map2Panel.TabIndex = 0;
            // 
            // map2
            // 
            this.map2.Bearing = 0F;
            this.map2.CanDragMap = true;
            this.map2.EmptyTileColor = System.Drawing.Color.Navy;
            this.map2.GrayScaleMode = false;
            this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map2.LevelsKeepInMemory = 5;
            this.map2.Location = new System.Drawing.Point(18, 14);
            this.map2.MarkersEnabled = true;
            this.map2.MaxZoom = 2;
            this.map2.MinZoom = 2;
            this.map2.MouseWheelZoomEnabled = true;
            this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map2.Name = "map2";
            this.map2.NegativeMode = false;
            this.map2.PolygonsEnabled = true;
            this.map2.RetryLoadTile = 0;
            this.map2.RoutesEnabled = true;
            this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map2.ShowTileGridLines = false;
            this.map2.Size = new System.Drawing.Size(740, 322);
            this.map2.TabIndex = 0;
            this.map2.Zoom = 0D;
            this.map2.Load += new System.EventHandler(this.Map2_Load);
            // 
            // shortPathPanel
            // 
            this.shortPathPanel.Controls.Add(this.pathLabel);
            this.shortPathPanel.Location = new System.Drawing.Point(12, 372);
            this.shortPathPanel.Name = "shortPathPanel";
            this.shortPathPanel.Size = new System.Drawing.Size(775, 99);
            this.shortPathPanel.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(15, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(54, 13);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "pathLabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Map_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.shortPathPanel);
            this.Controls.Add(this.map2Panel);
            this.Name = "Map_Ekrani";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Map_Ekrani_Load);
            this.Load += new System.EventHandler(this.Map_Ekrani_Load);
            this.map2Panel.ResumeLayout(false);
            this.shortPathPanel.ResumeLayout(false);
            this.shortPathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel map2Panel;
        private GMap.NET.WindowsForms.GMapControl map2;
        private System.Windows.Forms.Panel shortPathPanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Timer timer1;
    }
}