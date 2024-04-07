
namespace autoclicker
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.textTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxDump = new System.Windows.Forms.TextBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.checkBoxAmount = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxCritical = new System.Windows.Forms.CheckBox();
            this.checkBoxMultiplier = new System.Windows.Forms.CheckBox();
            this.checkBoxBonus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 18);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(18, 77);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 35);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerClick
            // 
            this.timerClick.Interval = 1000;
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(134, 225);
            this.textTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(148, 26);
            this.textTime.TabIndex = 2;
            this.textTime.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "click time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Set hotkey";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 120);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBoxDump
            // 
            this.textBoxDump.Location = new System.Drawing.Point(18, 270);
            this.textBoxDump.Multiline = true;
            this.textBoxDump.Name = "textBoxDump";
            this.textBoxDump.Size = new System.Drawing.Size(538, 214);
            this.textBoxDump.TabIndex = 7;
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Checked = true;
            this.checkBoxPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPower.Location = new System.Drawing.Point(18, 171);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(79, 24);
            this.checkBoxPower.TabIndex = 8;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmount
            // 
            this.checkBoxAmount.AutoSize = true;
            this.checkBoxAmount.Checked = true;
            this.checkBoxAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAmount.Location = new System.Drawing.Point(103, 171);
            this.checkBoxAmount.Name = "checkBoxAmount";
            this.checkBoxAmount.Size = new System.Drawing.Size(91, 24);
            this.checkBoxAmount.TabIndex = 9;
            this.checkBoxAmount.Text = "Amount";
            this.checkBoxAmount.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpeed
            // 
            this.checkBoxSpeed.AutoSize = true;
            this.checkBoxSpeed.Location = new System.Drawing.Point(200, 171);
            this.checkBoxSpeed.Name = "checkBoxSpeed";
            this.checkBoxSpeed.Size = new System.Drawing.Size(82, 24);
            this.checkBoxSpeed.TabIndex = 10;
            this.checkBoxSpeed.Text = "Speed";
            this.checkBoxSpeed.UseVisualStyleBackColor = true;
            // 
            // checkBoxCritical
            // 
            this.checkBoxCritical.AutoSize = true;
            this.checkBoxCritical.Location = new System.Drawing.Point(288, 171);
            this.checkBoxCritical.Name = "checkBoxCritical";
            this.checkBoxCritical.Size = new System.Drawing.Size(82, 24);
            this.checkBoxCritical.TabIndex = 11;
            this.checkBoxCritical.Text = "Critical";
            this.checkBoxCritical.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiplier
            // 
            this.checkBoxMultiplier.AutoSize = true;
            this.checkBoxMultiplier.Location = new System.Drawing.Point(376, 171);
            this.checkBoxMultiplier.Name = "checkBoxMultiplier";
            this.checkBoxMultiplier.Size = new System.Drawing.Size(97, 24);
            this.checkBoxMultiplier.TabIndex = 12;
            this.checkBoxMultiplier.Text = "Multiplier";
            this.checkBoxMultiplier.UseVisualStyleBackColor = true;
            // 
            // checkBoxBonus
            // 
            this.checkBoxBonus.AutoSize = true;
            this.checkBoxBonus.Location = new System.Drawing.Point(480, 171);
            this.checkBoxBonus.Name = "checkBoxBonus";
            this.checkBoxBonus.Size = new System.Drawing.Size(81, 24);
            this.checkBoxBonus.TabIndex = 13;
            this.checkBoxBonus.Text = "Bonus";
            this.checkBoxBonus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 496);
            this.Controls.Add(this.checkBoxBonus);
            this.Controls.Add(this.checkBoxMultiplier);
            this.Controls.Add(this.checkBoxCritical);
            this.Controls.Add(this.checkBoxSpeed);
            this.Controls.Add(this.checkBoxAmount);
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.textBoxDump);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Idle Generators Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDump;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.CheckBox checkBoxAmount;
        private System.Windows.Forms.CheckBox checkBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxCritical;
        private System.Windows.Forms.CheckBox checkBoxMultiplier;
        private System.Windows.Forms.CheckBox checkBoxBonus;
    }
}

