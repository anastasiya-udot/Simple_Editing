namespace Figures
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
            this.Line_Button = new System.Windows.Forms.Button();
            this.Ellipse_Button = new System.Windows.Forms.Button();
            this.Polygon_Button = new System.Windows.Forms.Button();
            this.AllFigures_Button = new System.Windows.Forms.Button();
            this.Points_trackBar = new System.Windows.Forms.TrackBar();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.MouseCounter_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Points_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Line_Button
            // 
            this.Line_Button.Location = new System.Drawing.Point(732, 13);
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(129, 29);
            this.Line_Button.TabIndex = 0;
            this.Line_Button.Text = "Line";
            this.Line_Button.UseVisualStyleBackColor = true;
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click);
            // 
            // Ellipse_Button
            // 
            this.Ellipse_Button.Location = new System.Drawing.Point(732, 48);
            this.Ellipse_Button.Name = "Ellipse_Button";
            this.Ellipse_Button.Size = new System.Drawing.Size(129, 29);
            this.Ellipse_Button.TabIndex = 1;
            this.Ellipse_Button.Text = "Ellipse";
            this.Ellipse_Button.UseVisualStyleBackColor = true;
            this.Ellipse_Button.Click += new System.EventHandler(this.Ellipse_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Location = new System.Drawing.Point(732, 145);
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(129, 30);
            this.Polygon_Button.TabIndex = 2;
            this.Polygon_Button.Text = "Polygon";
            this.Polygon_Button.UseVisualStyleBackColor = true;
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // AllFigures_Button
            // 
            this.AllFigures_Button.Location = new System.Drawing.Point(733, 325);
            this.AllFigures_Button.Name = "AllFigures_Button";
            this.AllFigures_Button.Size = new System.Drawing.Size(128, 31);
            this.AllFigures_Button.TabIndex = 4;
            this.AllFigures_Button.Text = "All figures";
            this.AllFigures_Button.UseVisualStyleBackColor = true;
            this.AllFigures_Button.Click += new System.EventHandler(this.AllFigures_Button_Click);
            // 
            // Points_trackBar
            // 
            this.Points_trackBar.Location = new System.Drawing.Point(736, 198);
            this.Points_trackBar.Maximum = 6;
            this.Points_trackBar.Minimum = 3;
            this.Points_trackBar.Name = "Points_trackBar";
            this.Points_trackBar.Size = new System.Drawing.Size(124, 56);
            this.Points_trackBar.TabIndex = 5;
            this.Points_trackBar.Value = 3;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(733, 406);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(125, 34);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // MouseCounter_textBox
            // 
            this.MouseCounter_textBox.Location = new System.Drawing.Point(759, 260);
            this.MouseCounter_textBox.Name = "MouseCounter_textBox";
            this.MouseCounter_textBox.Size = new System.Drawing.Size(68, 22);
            this.MouseCounter_textBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 476);
            this.Controls.Add(this.MouseCounter_textBox);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Points_trackBar);
            this.Controls.Add(this.AllFigures_Button);
            this.Controls.Add(this.Polygon_Button);
            this.Controls.Add(this.Ellipse_Button);
            this.Controls.Add(this.Line_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Points_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Line_Button;
        private System.Windows.Forms.Button Ellipse_Button;
        private System.Windows.Forms.Button Polygon_Button;
        private System.Windows.Forms.Button AllFigures_Button;
        private System.Windows.Forms.TrackBar Points_trackBar;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.TextBox MouseCounter_textBox;
    }
}

