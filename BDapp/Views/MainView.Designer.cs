namespace BDapp.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnWells = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResearch);
            this.panel1.Controls.Add(this.btnWells);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 0;
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(0, 50);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(200, 52);
            this.btnResearch.TabIndex = 1;
            this.btnResearch.Text = "Методы исследованй";
            this.btnResearch.UseVisualStyleBackColor = true;
            // 
            // btnWells
            // 
            this.btnWells.Location = new System.Drawing.Point(0, 0);
            this.btnWells.Name = "btnWells";
            this.btnWells.Size = new System.Drawing.Size(200, 52);
            this.btnWells.TabIndex = 0;
            this.btnWells.Text = "Скважины";
            this.btnWells.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 520);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Меню";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWells;
        private System.Windows.Forms.Button btnResearch;
    }
}