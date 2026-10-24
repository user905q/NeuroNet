using System;
using System.Drawing;
using System.Windows.Forms;
namespace Oralov_PI31_Kesha
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button_SaveTrainSample = new Button();
            button_SaveTestSample = new Button();
            numericUpDown_NecessaryOutput = new NumericUpDown();
            Button_Recognize = new Button();
            label_Output = new Label();
            label_Probabylity = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_NecessaryOutput).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(272, 60);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Change_Status_buttons;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(313, 60);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Change_Status_buttons;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(354, 60);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Change_Status_buttons;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(272, 101);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Change_Status_buttons;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(313, 101);
            button5.Name = "button5";
            button5.Size = new Size(35, 35);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += Change_Status_buttons;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(354, 101);
            button6.Name = "button6";
            button6.Size = new Size(35, 35);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Change_Status_buttons;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(272, 142);
            button7.Name = "button7";
            button7.Size = new Size(35, 35);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += Change_Status_buttons;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(313, 142);
            button8.Name = "button8";
            button8.Size = new Size(35, 35);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += Change_Status_buttons;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(354, 142);
            button9.Name = "button9";
            button9.Size = new Size(35, 35);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Change_Status_buttons;
            // 
            // button10
            // 
            button10.BackColor = Color.LightGray;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(272, 183);
            button10.Name = "button10";
            button10.Size = new Size(35, 35);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Change_Status_buttons;
            // 
            // button11
            // 
            button11.BackColor = Color.LightGray;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(313, 183);
            button11.Name = "button11";
            button11.Size = new Size(35, 35);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = false;
            button11.Click += Change_Status_buttons;
            // 
            // button12
            // 
            button12.BackColor = Color.LightGray;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(354, 183);
            button12.Name = "button12";
            button12.Size = new Size(35, 35);
            button12.TabIndex = 11;
            button12.UseVisualStyleBackColor = false;
            button12.Click += Change_Status_buttons;
            // 
            // button13
            // 
            button13.BackColor = Color.LightGray;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(272, 224);
            button13.Name = "button13";
            button13.Size = new Size(35, 35);
            button13.TabIndex = 12;
            button13.UseVisualStyleBackColor = false;
            button13.Click += Change_Status_buttons;
            // 
            // button14
            // 
            button14.BackColor = Color.LightGray;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(313, 224);
            button14.Name = "button14";
            button14.Size = new Size(35, 35);
            button14.TabIndex = 13;
            button14.UseVisualStyleBackColor = false;
            button14.Click += Change_Status_buttons;
            // 
            // button15
            // 
            button15.BackColor = Color.LightGray;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(354, 224);
            button15.Name = "button15";
            button15.Size = new Size(35, 35);
            button15.TabIndex = 14;
            button15.UseVisualStyleBackColor = false;
            button15.Click += Change_Status_buttons;
            // 
            // button_SaveTrainSample
            // 
            button_SaveTrainSample.Location = new Point(272, 320);
            button_SaveTrainSample.Name = "button_SaveTrainSample";
            button_SaveTrainSample.Size = new Size(85, 23);
            button_SaveTrainSample.TabIndex = 15;
            button_SaveTrainSample.Text = "Обучение";
            button_SaveTrainSample.UseVisualStyleBackColor = true;
            button_SaveTrainSample.Click += button_SaveTrainSample_Click;
            // 
            // button_SaveTestSample
            // 
            button_SaveTestSample.Location = new Point(273, 349);
            button_SaveTestSample.Name = "button_SaveTestSample";
            button_SaveTestSample.Size = new Size(84, 23);
            button_SaveTestSample.TabIndex = 16;
            button_SaveTestSample.Text = "Тренировка";
            button_SaveTestSample.UseVisualStyleBackColor = true;
            button_SaveTestSample.Click += button_SaveTestSample_Click;
            // 
            // numericUpDown_NecessaryOutput
            // 
            numericUpDown_NecessaryOutput.Location = new Point(271, 287);
            numericUpDown_NecessaryOutput.Name = "numericUpDown_NecessaryOutput";
            numericUpDown_NecessaryOutput.Size = new Size(36, 23);
            numericUpDown_NecessaryOutput.TabIndex = 17;
            // 
            // Button_Recognize
            // 
            Button_Recognize.Location = new Point(272, 378);
            Button_Recognize.Name = "Button_Recognize";
            Button_Recognize.Size = new Size(100, 60);
            Button_Recognize.TabIndex = 18;
            Button_Recognize.Text = "Распознать";
            Button_Recognize.UseVisualStyleBackColor = true;
            Button_Recognize.Click += Button_Recognize_Click;
            // 
            // label_Output
            // 
            label_Output.AutoSize = true;
            label_Output.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_Output.Location = new Point(445, 60);
            label_Output.Name = "label_Output";
            label_Output.Size = new Size(107, 65);
            label_Output.TabIndex = 19;
            label_Output.Text = "Out";
            // 
            // label_Probabylity
            // 
            label_Probabylity.AutoSize = true;
            label_Probabylity.Location = new Point(463, 142);
            label_Probabylity.Name = "label_Probabylity";
            label_Probabylity.Size = new Size(67, 15);
            label_Probabylity.TabIndex = 20;
            label_Probabylity.Text = "Probabylity";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Probabylity);
            Controls.Add(label_Output);
            Controls.Add(Button_Recognize);
            Controls.Add(numericUpDown_NecessaryOutput);
            Controls.Add(button_SaveTestSample);
            Controls.Add(button_SaveTrainSample);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Kesha";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_NecessaryOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button_SaveTrainSample;
        private Button button_SaveTestSample;
        private NumericUpDown numericUpDown_NecessaryOutput;
        private Button Button_Recognize;
        private Label label_Output;
        private Label label_Probabylity;
    }
}
