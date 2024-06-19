namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label Combinate;
        private TextBox First;
        private TextBox Second;
        private TextBox Third;
        private Button checkButton;
        private Button btnNext;
        private Label Result;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Combinate = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Third = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Combinate
            this.Combinate.AutoSize = true;
            this.Combinate.Location = new System.Drawing.Point(30, 30);
            this.Combinate.Name = "Combinate";
            this.Combinate.Size = new System.Drawing.Size(0, 13);
            this.Combinate.TabIndex = 0;

            // First
            this.First.Location = new System.Drawing.Point(30, 60);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(100, 20);
            this.First.TabIndex = 1;

            // Second
            this.Second.Location = new System.Drawing.Point(30, 90);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(100, 20);
            this.Second.TabIndex = 2;

            // Third
            this.Third.Location = new System.Drawing.Point(30, 120);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(100, 20);
            this.Third.TabIndex = 3;

            // checkButton
            this.checkButton.Location = new System.Drawing.Point(30, 150);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Перевірити";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);

            // btnNext
            this.btnNext.Location = new System.Drawing.Point(30, 180);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Наступна";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // Result
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(30, 210);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 6;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Combinate);
            this.Controls.Add(this.First);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Числові головоломки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
