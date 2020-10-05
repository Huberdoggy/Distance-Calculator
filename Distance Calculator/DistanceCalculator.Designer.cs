namespace Distance_Calculator
{
    partial class DistanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistanceCalculator));
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mphTxtBox = new System.Windows.Forms.TextBox();
            this.hours_traveledTxtBox = new System.Windows.Forms.TextBox();
            this.mphLbl = new System.Windows.Forms.Label();
            this.hrs_traveledLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.Color.Linen;
            this.outputListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputListBox.Enabled = false;
            this.outputListBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.ForeColor = System.Drawing.Color.Navy;
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 18;
            this.outputListBox.Location = new System.Drawing.Point(44, 173);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(450, 308);
            this.outputListBox.TabIndex = 7;
            this.outputListBox.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Snow;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.ForeColor = System.Drawing.Color.Navy;
            this.clearBtn.Location = new System.Drawing.Point(225, 501);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 46);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Snow;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.ForeColor = System.Drawing.Color.Navy;
            this.exitBtn.Location = new System.Drawing.Point(364, 501);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 46);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mphTxtBox
            // 
            this.mphTxtBox.BackColor = System.Drawing.Color.Linen;
            this.mphTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mphTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mphTxtBox.ForeColor = System.Drawing.Color.Navy;
            this.mphTxtBox.Location = new System.Drawing.Point(224, 27);
            this.mphTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mphTxtBox.Name = "mphTxtBox";
            this.mphTxtBox.Size = new System.Drawing.Size(176, 23);
            this.mphTxtBox.TabIndex = 0;
            // 
            // hours_traveledTxtBox
            // 
            this.hours_traveledTxtBox.BackColor = System.Drawing.Color.Linen;
            this.hours_traveledTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hours_traveledTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_traveledTxtBox.ForeColor = System.Drawing.Color.Navy;
            this.hours_traveledTxtBox.Location = new System.Drawing.Point(224, 92);
            this.hours_traveledTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hours_traveledTxtBox.Name = "hours_traveledTxtBox";
            this.hours_traveledTxtBox.Size = new System.Drawing.Size(176, 23);
            this.hours_traveledTxtBox.TabIndex = 1;
            // 
            // mphLbl
            // 
            this.mphLbl.AutoSize = true;
            this.mphLbl.ForeColor = System.Drawing.Color.Navy;
            this.mphLbl.Location = new System.Drawing.Point(86, 31);
            this.mphLbl.Name = "mphLbl";
            this.mphLbl.Size = new System.Drawing.Size(132, 18);
            this.mphLbl.TabIndex = 5;
            this.mphLbl.Text = "Vehicle Speed (MPH):";
            // 
            // hrs_traveledLbl
            // 
            this.hrs_traveledLbl.AutoSize = true;
            this.hrs_traveledLbl.ForeColor = System.Drawing.Color.Navy;
            this.hrs_traveledLbl.Location = new System.Drawing.Point(120, 96);
            this.hrs_traveledLbl.Name = "hrs_traveledLbl";
            this.hrs_traveledLbl.Size = new System.Drawing.Size(101, 18);
            this.hrs_traveledLbl.TabIndex = 6;
            this.hrs_traveledLbl.Text = "Hours Traveled:";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Snow;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcBtn.ForeColor = System.Drawing.Color.Navy;
            this.calcBtn.Location = new System.Drawing.Point(86, 501);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(115, 46);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // saveFile
            // 
            this.saveFile.Title = "Choose Where To Save The Results";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gray;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.Color.Navy;
            this.saveButton.Location = new System.Drawing.Point(225, 569);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 46);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Results";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Distance_Calculator.Properties.Resources.opaque_musclecar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 641);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.hrs_traveledLbl);
            this.Controls.Add(this.mphLbl);
            this.Controls.Add(this.hours_traveledTxtBox);
            this.Controls.Add(this.mphTxtBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.outputListBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DistanceCalculator";
            this.Text = "Kyle\'s Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox mphTxtBox;
        private System.Windows.Forms.TextBox hours_traveledTxtBox;
        private System.Windows.Forms.Label mphLbl;
        private System.Windows.Forms.Label hrs_traveledLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button saveButton;
    }
}

