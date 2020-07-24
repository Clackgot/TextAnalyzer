namespace TextAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelInputRichTextBox = new System.Windows.Forms.Panel();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.panelOutputRichTextBox = new System.Windows.Forms.Panel();
            this.dataGridViewTextAlphabetInfo = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonRus = new System.Windows.Forms.RadioButton();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1251ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdateDataGridViewGeneralInfo = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.dataGridViewGeneralInfo = new System.Windows.Forms.DataGridView();
            this.panelInputRichTextBox.SuspendLayout();
            this.panelOutputRichTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTextAlphabetInfo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelInputRichTextBox
            // 
            this.panelInputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInputRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInputRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelInputRichTextBox.Controls.Add(this.richTextBoxInput);
            this.panelInputRichTextBox.Location = new System.Drawing.Point(7, 7);
            this.panelInputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelInputRichTextBox.Name = "panelInputRichTextBox";
            this.panelInputRichTextBox.Size = new System.Drawing.Size(663, 408);
            this.panelInputRichTextBox.TabIndex = 0;
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(663, 408);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // panelOutputRichTextBox
            // 
            this.panelOutputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutputRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOutputRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutputRichTextBox.Controls.Add(this.dataGridViewTextAlphabetInfo);
            this.panelOutputRichTextBox.Location = new System.Drawing.Point(11, 468);
            this.panelOutputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelOutputRichTextBox.Name = "panelOutputRichTextBox";
            this.panelOutputRichTextBox.Size = new System.Drawing.Size(659, 260);
            this.panelOutputRichTextBox.TabIndex = 2;
            // 
            // dataGridViewTextAlphabetInfo
            // 
            this.dataGridViewTextAlphabetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTextAlphabetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTextAlphabetInfo.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTextAlphabetInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTextAlphabetInfo.Name = "dataGridViewTextAlphabetInfo";
            this.dataGridViewTextAlphabetInfo.RowHeadersWidth = 51;
            this.dataGridViewTextAlphabetInfo.Size = new System.Drawing.Size(651, 252);
            this.dataGridViewTextAlphabetInfo.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.radioButtonRus);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonEng);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 423);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 37);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.AutoSize = true;
            this.radioButtonRus.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonRus.Location = new System.Drawing.Point(4, 4);
            this.radioButtonRus.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(118, 21);
            this.radioButtonRus.TabIndex = 0;
            this.radioButtonRus.Text = "Русский язык";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            this.radioButtonRus.CheckedChanged += new System.EventHandler(this.radioButtonRus_CheckedChanged);
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonEng.Location = new System.Drawing.Point(130, 4);
            this.radioButtonEng.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(134, 21);
            this.radioButtonEng.TabIndex = 1;
            this.radioButtonEng.Text = "Английкий язык";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            this.radioButtonEng.CheckedChanged += new System.EventHandler(this.radioButtonEng_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(272, 4);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Какой-то чекбокс";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectEncodingToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(709, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // selectEncodingToolStripMenuItem
            // 
            this.selectEncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.uTF8ToolStripMenuItem,
            this.windows1251ToolStripMenuItem});
            this.selectEncodingToolStripMenuItem.Enabled = false;
            this.selectEncodingToolStripMenuItem.Name = "selectEncodingToolStripMenuItem";
            this.selectEncodingToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.selectEncodingToolStripMenuItem.Text = "Кодировки";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // windows1251ToolStripMenuItem
            // 
            this.windows1251ToolStripMenuItem.Name = "windows1251ToolStripMenuItem";
            this.windows1251ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.windows1251ToolStripMenuItem.Text = "Windows-1251";
            this.windows1251ToolStripMenuItem.Click += new System.EventHandler(this.windows1251ToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 761);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelInputRichTextBox);
            this.tabPage1.Controls.Add(this.panelOutputRichTextBox);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистика текста";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonUpdateDataGridViewGeneralInfo);
            this.tabPage2.Controls.Add(this.buttonSaveText);
            this.tabPage2.Controls.Add(this.dataGridViewGeneralInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Общая статистика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Обновить таблицу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сохранить статистику текста на сервер";
            // 
            // buttonUpdateDataGridViewGeneralInfo
            // 
            this.buttonUpdateDataGridViewGeneralInfo.AutoSize = true;
            this.buttonUpdateDataGridViewGeneralInfo.Location = new System.Drawing.Point(284, 386);
            this.buttonUpdateDataGridViewGeneralInfo.Name = "buttonUpdateDataGridViewGeneralInfo";
            this.buttonUpdateDataGridViewGeneralInfo.Size = new System.Drawing.Size(153, 30);
            this.buttonUpdateDataGridViewGeneralInfo.TabIndex = 4;
            this.buttonUpdateDataGridViewGeneralInfo.Text = "Обновить таблицу";
            this.buttonUpdateDataGridViewGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(284, 350);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(110, 30);
            this.buttonSaveText.TabIndex = 3;
            this.buttonSaveText.Text = "Сохранить";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // dataGridViewGeneralInfo
            // 
            this.dataGridViewGeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGeneralInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneralInfo.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewGeneralInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGeneralInfo.Name = "dataGridViewGeneralInfo";
            this.dataGridViewGeneralInfo.RowHeadersWidth = 51;
            this.dataGridViewGeneralInfo.Size = new System.Drawing.Size(663, 336);
            this.dataGridViewGeneralInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 804);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(727, 851);
            this.MinimumSize = new System.Drawing.Size(727, 851);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.panelInputRichTextBox.ResumeLayout(false);
            this.panelOutputRichTextBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTextAlphabetInfo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneralInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelInputRichTextBox;
        private System.Windows.Forms.Panel panelOutputRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonRus;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewTextAlphabetInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1251ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewGeneralInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdateDataGridViewGeneralInfo;
        private System.Windows.Forms.Button buttonSaveText;
    }
}

