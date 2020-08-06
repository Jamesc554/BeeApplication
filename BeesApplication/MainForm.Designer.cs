namespace BeesApplication
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
            this.DamageButton = new System.Windows.Forms.Button();
            this.BeeListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(12, 415);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(447, 23);
            this.DamageButton.TabIndex = 0;
            this.DamageButton.Text = "Damage Random Bee";
            this.DamageButton.UseVisualStyleBackColor = true;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // BeeListView
            // 
            this.BeeListView.HideSelection = false;
            this.BeeListView.Location = new System.Drawing.Point(12, 12);
            this.BeeListView.Name = "BeeListView";
            this.BeeListView.Size = new System.Drawing.Size(447, 397);
            this.BeeListView.TabIndex = 1;
            this.BeeListView.UseCompatibleStateImageBehavior = false;
            this.BeeListView.View = System.Windows.Forms.View.Tile;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.BeeListView);
            this.Controls.Add(this.DamageButton);
            this.Name = "MainForm";
            this.Text = "Bee Application - James Carter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.ListView BeeListView;
    }
}

