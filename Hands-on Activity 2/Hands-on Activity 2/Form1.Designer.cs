namespace Hands_on_Activity_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RockButton = new Button();
            PaperButton = new Button();
            ScissorsButton = new Button();
            computerChoiceLabel = new Label();
            resultLabel = new Label();
            playerChoiceLabel = new Label();
            SuspendLayout();
            // 
            // RockButton
            // 
            RockButton.FlatStyle = FlatStyle.Popup;
            RockButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RockButton.Location = new Point(73, 270);
            RockButton.Name = "RockButton";
            RockButton.Size = new Size(146, 85);
            RockButton.TabIndex = 0;
            RockButton.Text = "ROCK";
            RockButton.UseVisualStyleBackColor = true;
            RockButton.Click += RockButton_Click;
            // 
            // PaperButton
            // 
            PaperButton.FlatStyle = FlatStyle.Popup;
            PaperButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaperButton.Location = new Point(317, 270);
            PaperButton.Name = "PaperButton";
            PaperButton.Size = new Size(146, 85);
            PaperButton.TabIndex = 1;
            PaperButton.Text = "PAPER";
            PaperButton.UseVisualStyleBackColor = true;
            PaperButton.Click += PaperButton_Click;
            // 
            // ScissorsButton
            // 
            ScissorsButton.FlatStyle = FlatStyle.Popup;
            ScissorsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScissorsButton.Location = new Point(562, 270);
            ScissorsButton.Name = "ScissorsButton";
            ScissorsButton.Size = new Size(146, 85);
            ScissorsButton.TabIndex = 2;
            ScissorsButton.Text = "SCISSORS";
            ScissorsButton.UseVisualStyleBackColor = true;
            ScissorsButton.Click += ScissorsButton_Click;
            // 
            // computerChoiceLabel
            // 
            computerChoiceLabel.AutoSize = true;
            computerChoiceLabel.Location = new Point(367, 111);
            computerChoiceLabel.Name = "computerChoiceLabel";
            computerChoiceLabel.Size = new Size(0, 15);
            computerChoiceLabel.TabIndex = 3;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(367, 159);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 4;
            resultLabel.Click += resultLabel_Click;
            // 
            // playerChoiceLabel
            // 
            playerChoiceLabel.AutoSize = true;
            playerChoiceLabel.Location = new Point(367, 66);
            playerChoiceLabel.Name = "playerChoiceLabel";
            playerChoiceLabel.Size = new Size(0, 15);
            playerChoiceLabel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playerChoiceLabel);
            Controls.Add(resultLabel);
            Controls.Add(computerChoiceLabel);
            Controls.Add(ScissorsButton);
            Controls.Add(PaperButton);
            Controls.Add(RockButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RockButton;
        private Button PaperButton;
        private Button ScissorsButton;
        private Label computerChoiceLabel;
        private Label resultLabel;
        private Label playerChoiceLabel;
    }
}
