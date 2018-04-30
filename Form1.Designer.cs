namespace MyFlix
{
    partial class MainForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.moveListBox = new System.Windows.Forms.ListBox();
            this.costButton = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.directions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(193, 55);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(603, 108);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "My Flix Downloader";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveListBox
            // 
            this.moveListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.moveListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveListBox.FormattingEnabled = true;
            this.moveListBox.ItemHeight = 37;
            this.moveListBox.Items.AddRange(new object[] {
            "Misery",
            "Goldfinger",
            "Mission Impossible",
            "Return of the Jedi",
            "Super 8",
            "Dracula Dead and Loving It",
            "Jurassic Park",
            "Aliens",
            "Lethal Weapon",
            "Garden State"});
            this.moveListBox.Location = new System.Drawing.Point(62, 220);
            this.moveListBox.Name = "moveListBox";
            this.moveListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.moveListBox.Size = new System.Drawing.Size(425, 300);
            this.moveListBox.TabIndex = 1;
            // 
            // costButton
            // 
            this.costButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.costButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.costButton.FlatAppearance.BorderSize = 3;
            this.costButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.Location = new System.Drawing.Point(115, 576);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(236, 67);
            this.costButton.TabIndex = 2;
            this.costButton.Text = "Estimate Cost";
            this.costButton.UseVisualStyleBackColor = false;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(466, 585);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(385, 49);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Estimated Cost: ";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directions
            // 
            this.directions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.directions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directions.Location = new System.Drawing.Point(567, 252);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(270, 199);
            this.directions.TabIndex = 4;
            this.directions.Text = "Hold CTRL to select multiple movies. Click Estimate Cost button to get cost";
            this.directions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.directions);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.moveListBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "MyFlix Downloader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox moveListBox;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label directions;
    }
}

