namespace test_api_call_2
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
            this.btnLoadEventTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadEventTypes
            // 
            this.btnLoadEventTypes.Location = new System.Drawing.Point(154, 42);
            this.btnLoadEventTypes.Name = "btnLoadEventTypes";
            this.btnLoadEventTypes.Size = new System.Drawing.Size(75, 23);
            this.btnLoadEventTypes.TabIndex = 0;
            this.btnLoadEventTypes.Text = "Load Event Types";
            this.btnLoadEventTypes.UseVisualStyleBackColor = true;
            this.btnLoadEventTypes.Click += new System.EventHandler(this.btnLoadEventTypes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 503);
            this.Controls.Add(this.btnLoadEventTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadEventTypes;
    }
}

