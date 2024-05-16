namespace PassMan
{
    partial class Names
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
            label1 = new Label();
            lstNames = new ListBox();
            txtName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Names";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 94);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(165, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Names
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 141);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Location = new Point(12, 9);
            Name = "Names";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox lstNames;
        private TextBox txtName;
        private Button button1;
    }
}
