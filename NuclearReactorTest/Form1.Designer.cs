namespace NuclearReactorTest
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
            this.NuclearTitleLabel = new System.Windows.Forms.Label();
            this.Reactor1Label = new System.Windows.Forms.Label();
            this.Reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NuclearTitleLabel
            // 
            this.NuclearTitleLabel.AutoSize = true;
            this.NuclearTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuclearTitleLabel.Location = new System.Drawing.Point(87, 44);
            this.NuclearTitleLabel.Name = "NuclearTitleLabel";
            this.NuclearTitleLabel.Size = new System.Drawing.Size(891, 111);
            this.NuclearTitleLabel.TabIndex = 0;
            this.NuclearTitleLabel.Text = "Nuclear Reactor Test";
            this.NuclearTitleLabel.Click += new System.EventHandler(this.NuclearTitle_Click);
            // 
            // Reactor1Label
            // 
            this.Reactor1Label.AutoSize = true;
            this.Reactor1Label.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1Label.Location = new System.Drawing.Point(96, 201);
            this.Reactor1Label.Name = "Reactor1Label";
            this.Reactor1Label.Size = new System.Drawing.Size(202, 56);
            this.Reactor1Label.TabIndex = 1;
            this.Reactor1Label.Text = "Reactor 1";
            this.Reactor1Label.Click += new System.EventHandler(this.Reactor1Label_Click);
            // 
            // Reactor2Label
            // 
            this.Reactor2Label.AutoSize = true;
            this.Reactor2Label.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2Label.Location = new System.Drawing.Point(770, 201);
            this.Reactor2Label.Name = "Reactor2Label";
            this.Reactor2Label.Size = new System.Drawing.Size(208, 56);
            this.Reactor2Label.TabIndex = 2;
            this.Reactor2Label.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor1StateLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1StateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reactor1StateLabel.Location = new System.Drawing.Point(106, 295);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(192, 180);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor2StateLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2StateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reactor2StateLabel.Location = new System.Drawing.Point(780, 295);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(198, 180);
            this.reactor2StateLabel.TabIndex = 4;
            this.reactor2StateLabel.Click += new System.EventHandler(this.reactor2StateLabel_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.outputLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(106, 540);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(872, 172);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(399, 295);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(292, 124);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Enable";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1032, 736);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.NuclearTitleLabel);
            this.Controls.Add(this.Reactor2Label);
            this.Controls.Add(this.Reactor1Label);
            this.Name = "Form1";
            this.Text = "NuclearTestVisuals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NuclearTitleLabel;
        private System.Windows.Forms.Label Reactor1Label;
        private System.Windows.Forms.Label Reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

