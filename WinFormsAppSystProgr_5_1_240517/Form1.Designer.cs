namespace WinFormsAppSystProgr_5_1_240517
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
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            panelReport = new Panel();
            tableLayoutPanelExclamatoryCount = new TableLayoutPanel();
            label11 = new Label();
            labelExclamatoryCount = new Label();
            tableLayoutPanelInterrogativeCount = new TableLayoutPanel();
            label10 = new Label();
            labelInterrogativeCount = new Label();
            tableLayoutPanelWordCount = new TableLayoutPanel();
            label7 = new Label();
            labelWordCount = new Label();
            tableLayoutPanelCharacterCount = new TableLayoutPanel();
            label3 = new Label();
            labelCharacterCount = new Label();
            tableLayoutPanelSentenceCount = new TableLayoutPanel();
            label1 = new Label();
            labelSentenceCount = new Label();
            buttonSave = new Button();
            panel1 = new Panel();
            buttonClear = new Button();
            buttonStop = new Button();
            buttonContinue = new Button();
            buttonPause = new Button();
            buttonStart = new Button();
            groupBox1 = new GroupBox();
            checkBoxExclamatoryCount = new CheckBox();
            checkBoxInterrogativeCount = new CheckBox();
            checkBoxWordCount = new CheckBox();
            checkBoxCharacterCount = new CheckBox();
            checkBoxSentenceCount = new CheckBox();
            checkBoxAll = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelReport.SuspendLayout();
            tableLayoutPanelExclamatoryCount.SuspendLayout();
            tableLayoutPanelInterrogativeCount.SuspendLayout();
            tableLayoutPanelWordCount.SuspendLayout();
            tableLayoutPanelCharacterCount.SuspendLayout();
            tableLayoutPanelSentenceCount.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelReport);
            splitContainer1.Panel2.Controls.Add(buttonSave);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1166, 644);
            splitContainer1.SplitterDistance = 896;
            splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type or paste your text here";
            textBox1.Size = new Size(896, 644);
            textBox1.TabIndex = 0;
            // 
            // panelReport
            // 
            panelReport.Controls.Add(tableLayoutPanelExclamatoryCount);
            panelReport.Controls.Add(tableLayoutPanelInterrogativeCount);
            panelReport.Controls.Add(tableLayoutPanelWordCount);
            panelReport.Controls.Add(tableLayoutPanelCharacterCount);
            panelReport.Controls.Add(tableLayoutPanelSentenceCount);
            panelReport.Location = new Point(8, 331);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(244, 142);
            panelReport.TabIndex = 5;
            // 
            // tableLayoutPanelExclamatoryCount
            // 
            tableLayoutPanelExclamatoryCount.ColumnCount = 2;
            tableLayoutPanelExclamatoryCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanelExclamatoryCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanelExclamatoryCount.Controls.Add(label11, 0, 0);
            tableLayoutPanelExclamatoryCount.Controls.Add(labelExclamatoryCount, 1, 0);
            tableLayoutPanelExclamatoryCount.Dock = DockStyle.Top;
            tableLayoutPanelExclamatoryCount.Location = new Point(0, 105);
            tableLayoutPanelExclamatoryCount.Name = "tableLayoutPanelExclamatoryCount";
            tableLayoutPanelExclamatoryCount.RowCount = 1;
            tableLayoutPanelExclamatoryCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelExclamatoryCount.Size = new Size(244, 37);
            tableLayoutPanelExclamatoryCount.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(168, 37);
            label11.TabIndex = 0;
            label11.Text = "Number of exclamatory sentences:";
            // 
            // labelExclamatoryCount
            // 
            labelExclamatoryCount.AutoSize = true;
            labelExclamatoryCount.Dock = DockStyle.Fill;
            labelExclamatoryCount.Location = new Point(177, 0);
            labelExclamatoryCount.Name = "labelExclamatoryCount";
            labelExclamatoryCount.Size = new Size(64, 37);
            labelExclamatoryCount.TabIndex = 1;
            labelExclamatoryCount.Text = "0";
            labelExclamatoryCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelInterrogativeCount
            // 
            tableLayoutPanelInterrogativeCount.ColumnCount = 2;
            tableLayoutPanelInterrogativeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanelInterrogativeCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanelInterrogativeCount.Controls.Add(label10, 0, 0);
            tableLayoutPanelInterrogativeCount.Controls.Add(labelInterrogativeCount, 1, 0);
            tableLayoutPanelInterrogativeCount.Dock = DockStyle.Top;
            tableLayoutPanelInterrogativeCount.Location = new Point(0, 72);
            tableLayoutPanelInterrogativeCount.Name = "tableLayoutPanelInterrogativeCount";
            tableLayoutPanelInterrogativeCount.RowCount = 1;
            tableLayoutPanelInterrogativeCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInterrogativeCount.Size = new Size(244, 33);
            tableLayoutPanelInterrogativeCount.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(168, 33);
            label10.TabIndex = 0;
            label10.Text = "Number of interrogative sentences:";
            // 
            // labelInterrogativeCount
            // 
            labelInterrogativeCount.AutoSize = true;
            labelInterrogativeCount.Dock = DockStyle.Fill;
            labelInterrogativeCount.Location = new Point(177, 0);
            labelInterrogativeCount.Name = "labelInterrogativeCount";
            labelInterrogativeCount.Size = new Size(64, 33);
            labelInterrogativeCount.TabIndex = 1;
            labelInterrogativeCount.Text = "0";
            labelInterrogativeCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelWordCount
            // 
            tableLayoutPanelWordCount.ColumnCount = 2;
            tableLayoutPanelWordCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanelWordCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanelWordCount.Controls.Add(label7, 0, 0);
            tableLayoutPanelWordCount.Controls.Add(labelWordCount, 1, 0);
            tableLayoutPanelWordCount.Dock = DockStyle.Top;
            tableLayoutPanelWordCount.Location = new Point(0, 48);
            tableLayoutPanelWordCount.Name = "tableLayoutPanelWordCount";
            tableLayoutPanelWordCount.RowCount = 1;
            tableLayoutPanelWordCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelWordCount.Size = new Size(244, 24);
            tableLayoutPanelWordCount.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(168, 24);
            label7.TabIndex = 0;
            label7.Text = "Number of words:";
            // 
            // labelWordCount
            // 
            labelWordCount.AutoSize = true;
            labelWordCount.Dock = DockStyle.Fill;
            labelWordCount.Location = new Point(177, 0);
            labelWordCount.Name = "labelWordCount";
            labelWordCount.Size = new Size(64, 24);
            labelWordCount.TabIndex = 1;
            labelWordCount.Text = "0";
            // 
            // tableLayoutPanelCharacterCount
            // 
            tableLayoutPanelCharacterCount.ColumnCount = 2;
            tableLayoutPanelCharacterCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanelCharacterCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanelCharacterCount.Controls.Add(label3, 0, 0);
            tableLayoutPanelCharacterCount.Controls.Add(labelCharacterCount, 1, 0);
            tableLayoutPanelCharacterCount.Dock = DockStyle.Top;
            tableLayoutPanelCharacterCount.Location = new Point(0, 24);
            tableLayoutPanelCharacterCount.Name = "tableLayoutPanelCharacterCount";
            tableLayoutPanelCharacterCount.RowCount = 1;
            tableLayoutPanelCharacterCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCharacterCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCharacterCount.Size = new Size(244, 24);
            tableLayoutPanelCharacterCount.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 24);
            label3.TabIndex = 0;
            label3.Text = "Number of characters:";
            // 
            // labelCharacterCount
            // 
            labelCharacterCount.AutoSize = true;
            labelCharacterCount.Dock = DockStyle.Fill;
            labelCharacterCount.Location = new Point(177, 0);
            labelCharacterCount.Name = "labelCharacterCount";
            labelCharacterCount.Size = new Size(64, 24);
            labelCharacterCount.TabIndex = 1;
            labelCharacterCount.Text = "0";
            // 
            // tableLayoutPanelSentenceCount
            // 
            tableLayoutPanelSentenceCount.ColumnCount = 2;
            tableLayoutPanelSentenceCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanelSentenceCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanelSentenceCount.Controls.Add(label1, 0, 0);
            tableLayoutPanelSentenceCount.Controls.Add(labelSentenceCount, 1, 0);
            tableLayoutPanelSentenceCount.Dock = DockStyle.Top;
            tableLayoutPanelSentenceCount.Location = new Point(0, 0);
            tableLayoutPanelSentenceCount.Name = "tableLayoutPanelSentenceCount";
            tableLayoutPanelSentenceCount.RowCount = 1;
            tableLayoutPanelSentenceCount.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelSentenceCount.Size = new Size(244, 24);
            tableLayoutPanelSentenceCount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 24);
            label1.TabIndex = 0;
            label1.Text = "Number of sentences:";
            // 
            // labelSentenceCount
            // 
            labelSentenceCount.AutoSize = true;
            labelSentenceCount.Dock = DockStyle.Fill;
            labelSentenceCount.Location = new Point(177, 0);
            labelSentenceCount.Name = "labelSentenceCount";
            labelSentenceCount.Size = new Size(64, 24);
            labelSentenceCount.TabIndex = 1;
            labelSentenceCount.Text = "0";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom;
            buttonSave.Location = new Point(8, 608);
            buttonSave.Margin = new Padding(3, 10, 3, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(244, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save to file";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonStop);
            panel1.Controls.Add(buttonContinue);
            panel1.Controls.Add(buttonPause);
            panel1.Controls.Add(buttonStart);
            panel1.Location = new Point(8, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 121);
            panel1.TabIndex = 1;
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Top;
            buttonClear.Location = new Point(0, 95);
            buttonClear.Margin = new Padding(3, 10, 3, 10);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(244, 26);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonStop
            // 
            buttonStop.Dock = DockStyle.Top;
            buttonStop.Location = new Point(0, 69);
            buttonStop.Margin = new Padding(3, 10, 3, 10);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(244, 26);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Dock = DockStyle.Top;
            buttonContinue.Location = new Point(0, 46);
            buttonContinue.Margin = new Padding(3, 10, 3, 10);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(244, 23);
            buttonContinue.TabIndex = 2;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // buttonPause
            // 
            buttonPause.Dock = DockStyle.Top;
            buttonPause.Location = new Point(0, 23);
            buttonPause.Margin = new Padding(3, 10, 3, 10);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(244, 23);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Top;
            buttonStart.Location = new Point(0, 0);
            buttonStart.Margin = new Padding(3, 10, 3, 10);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(244, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxExclamatoryCount);
            groupBox1.Controls.Add(checkBoxInterrogativeCount);
            groupBox1.Controls.Add(checkBoxWordCount);
            groupBox1.Controls.Add(checkBoxCharacterCount);
            groupBox1.Controls.Add(checkBoxSentenceCount);
            groupBox1.Controls.Add(checkBoxAll);
            groupBox1.Location = new Point(8, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "The report will  contain information:";
            // 
            // checkBoxExclamatoryCount
            // 
            checkBoxExclamatoryCount.AutoSize = true;
            checkBoxExclamatoryCount.Location = new Point(6, 148);
            checkBoxExclamatoryCount.Name = "checkBoxExclamatoryCount";
            checkBoxExclamatoryCount.Size = new Size(207, 19);
            checkBoxExclamatoryCount.TabIndex = 5;
            checkBoxExclamatoryCount.Text = "Number of exclamatory sentences";
            checkBoxExclamatoryCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterrogativeCount
            // 
            checkBoxInterrogativeCount.AutoSize = true;
            checkBoxInterrogativeCount.Location = new Point(6, 123);
            checkBoxInterrogativeCount.Name = "checkBoxInterrogativeCount";
            checkBoxInterrogativeCount.Size = new Size(209, 19);
            checkBoxInterrogativeCount.TabIndex = 4;
            checkBoxInterrogativeCount.Text = "Number of interrogative sentences";
            checkBoxInterrogativeCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxWordCount
            // 
            checkBoxWordCount.AutoSize = true;
            checkBoxWordCount.Location = new Point(6, 98);
            checkBoxWordCount.Name = "checkBoxWordCount";
            checkBoxWordCount.Size = new Size(119, 19);
            checkBoxWordCount.TabIndex = 3;
            checkBoxWordCount.Text = "Number of words";
            checkBoxWordCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxCharacterCount
            // 
            checkBoxCharacterCount.AutoSize = true;
            checkBoxCharacterCount.Location = new Point(6, 73);
            checkBoxCharacterCount.Name = "checkBoxCharacterCount";
            checkBoxCharacterCount.Size = new Size(141, 19);
            checkBoxCharacterCount.TabIndex = 2;
            checkBoxCharacterCount.Text = "Number of characters";
            checkBoxCharacterCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxSentenceCount
            // 
            checkBoxSentenceCount.AutoSize = true;
            checkBoxSentenceCount.Location = new Point(6, 47);
            checkBoxSentenceCount.Name = "checkBoxSentenceCount";
            checkBoxSentenceCount.Size = new Size(139, 19);
            checkBoxSentenceCount.TabIndex = 1;
            checkBoxSentenceCount.Text = "Number of sentences";
            checkBoxSentenceCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(6, 22);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(40, 19);
            checkBoxAll.TabIndex = 0;
            checkBoxAll.Text = "All";
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.31148F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6885242F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 100);
            label5.TabIndex = 0;
            label5.Text = "Number of sentences:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(145, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 100);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 644);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(740, 593);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelReport.ResumeLayout(false);
            tableLayoutPanelExclamatoryCount.ResumeLayout(false);
            tableLayoutPanelExclamatoryCount.PerformLayout();
            tableLayoutPanelInterrogativeCount.ResumeLayout(false);
            tableLayoutPanelInterrogativeCount.PerformLayout();
            tableLayoutPanelWordCount.ResumeLayout(false);
            tableLayoutPanelWordCount.PerformLayout();
            tableLayoutPanelCharacterCount.ResumeLayout(false);
            tableLayoutPanelCharacterCount.PerformLayout();
            tableLayoutPanelSentenceCount.ResumeLayout(false);
            tableLayoutPanelSentenceCount.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private CheckBox checkBoxSentenceCount;
        private CheckBox checkBoxAll;
        private CheckBox checkBoxCharacterCount;
        private CheckBox checkBoxExclamatoryCount;
        private CheckBox checkBoxInterrogativeCount;
        private CheckBox checkBoxWordCount;
        private Panel panel1;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonContinue;
        private Button buttonPause;
        private Panel panelReport;
        private TableLayoutPanel tableLayoutPanelSentenceCount;
        private Label label1;
        private Button buttonSave;
        private TableLayoutPanel tableLayoutPanelExclamatoryCount;
        private Label label11;
        private Label labelExclamatoryCount;
        private TableLayoutPanel tableLayoutPanelInterrogativeCount;
        private Label label10;
        private Label labelInterrogativeCount;
        private TableLayoutPanel tableLayoutPanelWordCount;
        private Label label7;
        private Label labelWordCount;
        private TableLayoutPanel tableLayoutPanelCharacterCount;
        private Label label3;
        private Label labelCharacterCount;
        private Label labelSentenceCount;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button buttonClear;
    }
}
