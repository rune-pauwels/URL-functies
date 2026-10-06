namespace URL_functies
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
            InputTextBox = new TextBox();
            ProtocolButton = new Button();
            DomeinnaamButton = new Button();
            OutputLabel = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 12);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(238, 23);
            InputTextBox.TabIndex = 0;
            // 
            // ProtocolButton
            // 
            ProtocolButton.Location = new Point(12, 41);
            ProtocolButton.Name = "ProtocolButton";
            ProtocolButton.Size = new Size(238, 23);
            ProtocolButton.TabIndex = 1;
            ProtocolButton.Text = "Protocol";
            ProtocolButton.UseVisualStyleBackColor = true;
            ProtocolButton.Click += ProtocolButton_Click;
            // 
            // DomeinnaamButton
            // 
            DomeinnaamButton.Location = new Point(12, 70);
            DomeinnaamButton.Name = "DomeinnaamButton";
            DomeinnaamButton.Size = new Size(238, 23);
            DomeinnaamButton.TabIndex = 2;
            DomeinnaamButton.Text = "Domeinnaam";
            DomeinnaamButton.UseVisualStyleBackColor = true;
            DomeinnaamButton.Click += DomeinnaamButton_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(12, 96);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(12, 15);
            OutputLabel.TabIndex = 3;
            OutputLabel.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 123);
            Controls.Add(OutputLabel);
            Controls.Add(DomeinnaamButton);
            Controls.Add(ProtocolButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button ProtocolButton;
        private Button DomeinnaamButton;
        private Label OutputLabel;
    }
}
