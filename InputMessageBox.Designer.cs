namespace Weather_Rider
{
    partial class InputMessageBox
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
            bottom = new Panel();
            button2 = new Button();
            button1 = new Button();
            iconPanel = new Panel();
            icon = new PictureBox();
            label = new Label();
            textBox = new TextBox();
            bottom.SuspendLayout();
            iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // bottom
            // 
            bottom.BackColor = SystemColors.ButtonFace;
            bottom.Controls.Add(button2);
            bottom.Controls.Add(button1);
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(0, 97);
            bottom.Name = "bottom";
            bottom.Size = new Size(279, 42);
            bottom.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(106, 11);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CancelButtonClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(187, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OKButtonClicked;
            // 
            // iconPanel
            // 
            iconPanel.Controls.Add(icon);
            iconPanel.Dock = DockStyle.Left;
            iconPanel.Location = new Point(0, 0);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(53, 97);
            iconPanel.TabIndex = 1;
            // 
            // icon
            // 
            icon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icon.BackgroundImage = Properties.Resources.InputMessageBoxIcon1;
            icon.BackgroundImageLayout = ImageLayout.Stretch;
            icon.Location = new Point(15, 33);
            icon.Name = "icon";
            icon.Size = new Size(35, 35);
            icon.TabIndex = 2;
            icon.TabStop = false;
            // 
            // label
            // 
            label.Location = new Point(72, 9);
            label.Name = "label";
            label.Size = new Size(195, 54);
            label.TabIndex = 2;
            label.Text = "label";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(72, 66);
            textBox.Name = "textBox";
            textBox.ShortcutsEnabled = false;
            textBox.Size = new Size(195, 23);
            textBox.TabIndex = 3;
            textBox.WordWrap = false;
            textBox.KeyDown += TextboxKeyDown;
            // 
            // InputMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(279, 139);
            Controls.Add(textBox);
            Controls.Add(label);
            Controls.Add(iconPanel);
            Controls.Add(bottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputMessageBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputMessageBox";
            TopMost = true;
            bottom.ResumeLayout(false);
            iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel bottom;
        private Button button2;
        private Button button1;
        private Panel iconPanel;
        private PictureBox icon;
        private Label label;
        private TextBox textBox;
    }
}