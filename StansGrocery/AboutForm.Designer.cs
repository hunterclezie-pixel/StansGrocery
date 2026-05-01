namespace StansGrocery
{
    partial class AboutForm
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
            AboutLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // AboutLabel
            // 
            AboutLabel.Location = new Point(12, 9);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(507, 136);
            AboutLabel.TabIndex = 0;
            AboutLabel.Text = "About Label";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(425, 148);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 39);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 200);
            Controls.Add(OkButton);
            Controls.Add(AboutLabel);
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutForm";
            ResumeLayout(false);
        }

        #endregion

        private Label AboutLabel;
        private Button OkButton;
    }
}