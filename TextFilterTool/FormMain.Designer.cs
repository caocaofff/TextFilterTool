
namespace Two_way_screening_tool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSourceTextFile = new System.Windows.Forms.Label();
            this.textBoxSourceTextFile = new System.Windows.Forms.TextBox();
            this.buttonChooseSourceTextFile = new System.Windows.Forms.Button();
            this.buttonChooesTargetTextFile = new System.Windows.Forms.Button();
            this.textBoxTargetTextFile = new System.Windows.Forms.TextBox();
            this.labelTargetTextFile = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxFound = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxNotFound = new System.Windows.Forms.TextBox();
            this.labelReadEncoding = new System.Windows.Forms.Label();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.labelSourceText = new System.Windows.Forms.Label();
            this.labelTargetText = new System.Windows.Forms.Label();
            this.labelFound = new System.Windows.Forms.Label();
            this.labelNotFound = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSourceTextFile
            // 
            this.labelSourceTextFile.AutoSize = true;
            this.labelSourceTextFile.Location = new System.Drawing.Point(16, 23);
            this.labelSourceTextFile.Name = "labelSourceTextFile";
            this.labelSourceTextFile.Size = new System.Drawing.Size(82, 15);
            this.labelSourceTextFile.TabIndex = 0;
            this.labelSourceTextFile.Text = "源文本文件";
            // 
            // textBoxSourceTextFile
            // 
            this.textBoxSourceTextFile.Location = new System.Drawing.Point(125, 19);
            this.textBoxSourceTextFile.Name = "textBoxSourceTextFile";
            this.textBoxSourceTextFile.Size = new System.Drawing.Size(314, 25);
            this.textBoxSourceTextFile.TabIndex = 1;
            // 
            // buttonChooseSourceTextFile
            // 
            this.buttonChooseSourceTextFile.Location = new System.Drawing.Point(453, 19);
            this.buttonChooseSourceTextFile.Name = "buttonChooseSourceTextFile";
            this.buttonChooseSourceTextFile.Size = new System.Drawing.Size(86, 25);
            this.buttonChooseSourceTextFile.TabIndex = 2;
            this.buttonChooseSourceTextFile.Text = "选择文件";
            this.buttonChooseSourceTextFile.UseVisualStyleBackColor = true;
            this.buttonChooseSourceTextFile.Click += new System.EventHandler(this.buttonChooseSourceTextFile_Click);
            // 
            // buttonChooesTargetTextFile
            // 
            this.buttonChooesTargetTextFile.Location = new System.Drawing.Point(453, 54);
            this.buttonChooesTargetTextFile.Name = "buttonChooesTargetTextFile";
            this.buttonChooesTargetTextFile.Size = new System.Drawing.Size(86, 25);
            this.buttonChooesTargetTextFile.TabIndex = 5;
            this.buttonChooesTargetTextFile.Text = "选择文件";
            this.buttonChooesTargetTextFile.UseVisualStyleBackColor = true;
            this.buttonChooesTargetTextFile.Click += new System.EventHandler(this.buttonChooesTargetTextFile_Click);
            // 
            // textBoxTargetTextFile
            // 
            this.textBoxTargetTextFile.Location = new System.Drawing.Point(125, 54);
            this.textBoxTargetTextFile.Name = "textBoxTargetTextFile";
            this.textBoxTargetTextFile.Size = new System.Drawing.Size(314, 25);
            this.textBoxTargetTextFile.TabIndex = 4;
            // 
            // labelTargetTextFile
            // 
            this.labelTargetTextFile.AutoSize = true;
            this.labelTargetTextFile.Location = new System.Drawing.Point(16, 58);
            this.labelTargetTextFile.Name = "labelTargetTextFile";
            this.labelTargetTextFile.Size = new System.Drawing.Size(97, 15);
            this.labelTargetTextFile.TabIndex = 3;
            this.labelTargetTextFile.Text = "目标文本文件";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(560, 54);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(211, 25);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "开始筛选目标";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFound
            // 
            this.textBoxFound.Location = new System.Drawing.Point(563, 120);
            this.textBoxFound.Multiline = true;
            this.textBoxFound.Name = "textBoxFound";
            this.textBoxFound.ReadOnly = true;
            this.textBoxFound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFound.Size = new System.Drawing.Size(223, 318);
            this.textBoxFound.TabIndex = 8;
            this.textBoxFound.WordWrap = false;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(292, 120);
            this.textBoxTarget.Multiline = true;
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTarget.Size = new System.Drawing.Size(247, 318);
            this.textBoxTarget.TabIndex = 10;
            this.textBoxTarget.WordWrap = false;
            // 
            // textBoxNotFound
            // 
            this.textBoxNotFound.Location = new System.Drawing.Point(807, 120);
            this.textBoxNotFound.Multiline = true;
            this.textBoxNotFound.Name = "textBoxNotFound";
            this.textBoxNotFound.ReadOnly = true;
            this.textBoxNotFound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNotFound.Size = new System.Drawing.Size(183, 318);
            this.textBoxNotFound.TabIndex = 11;
            this.textBoxNotFound.WordWrap = false;
            // 
            // labelReadEncoding
            // 
            this.labelReadEncoding.AutoSize = true;
            this.labelReadEncoding.Location = new System.Drawing.Point(560, 24);
            this.labelReadEncoding.Name = "labelReadEncoding";
            this.labelReadEncoding.Size = new System.Drawing.Size(67, 15);
            this.labelReadEncoding.TabIndex = 12;
            this.labelReadEncoding.Text = "读取编码";
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Location = new System.Drawing.Point(633, 20);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(76, 23);
            this.comboBoxEncoding.TabIndex = 13;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(19, 120);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(252, 318);
            this.textBoxSource.TabIndex = 14;
            this.textBoxSource.WordWrap = false;
            // 
            // labelSourceText
            // 
            this.labelSourceText.AutoSize = true;
            this.labelSourceText.Location = new System.Drawing.Point(16, 97);
            this.labelSourceText.Name = "labelSourceText";
            this.labelSourceText.Size = new System.Drawing.Size(52, 15);
            this.labelSourceText.TabIndex = 15;
            this.labelSourceText.Text = "源文本";
            // 
            // labelTargetText
            // 
            this.labelTargetText.AutoSize = true;
            this.labelTargetText.Location = new System.Drawing.Point(289, 97);
            this.labelTargetText.Name = "labelTargetText";
            this.labelTargetText.Size = new System.Drawing.Size(67, 15);
            this.labelTargetText.TabIndex = 16;
            this.labelTargetText.Text = "目标文本";
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(560, 97);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(52, 15);
            this.labelFound.TabIndex = 17;
            this.labelFound.Text = "已找到";
            // 
            // labelNotFound
            // 
            this.labelNotFound.AutoSize = true;
            this.labelNotFound.Location = new System.Drawing.Point(804, 97);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(52, 15);
            this.labelNotFound.TabIndex = 18;
            this.labelNotFound.Text = "未找到";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(777, 12);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(213, 67);
            this.textBoxLog.TabIndex = 19;
            this.textBoxLog.WordWrap = false;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(734, 15);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(37, 15);
            this.labelLog.TabIndex = 20;
            this.labelLog.Text = "日志";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelNotFound);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.labelTargetText);
            this.Controls.Add(this.labelSourceText);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.comboBoxEncoding);
            this.Controls.Add(this.labelReadEncoding);
            this.Controls.Add(this.textBoxNotFound);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxFound);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonChooesTargetTextFile);
            this.Controls.Add(this.textBoxTargetTextFile);
            this.Controls.Add(this.labelTargetTextFile);
            this.Controls.Add(this.buttonChooseSourceTextFile);
            this.Controls.Add(this.textBoxSourceTextFile);
            this.Controls.Add(this.labelSourceTextFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本筛选工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceTextFile;
        private System.Windows.Forms.TextBox textBoxSourceTextFile;
        private System.Windows.Forms.Button buttonChooseSourceTextFile;
        private System.Windows.Forms.Button buttonChooesTargetTextFile;
        private System.Windows.Forms.TextBox textBoxTargetTextFile;
        private System.Windows.Forms.Label labelTargetTextFile;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxFound;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.TextBox textBoxNotFound;
        private System.Windows.Forms.Label labelReadEncoding;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label labelSourceText;
        private System.Windows.Forms.Label labelTargetText;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.Label labelNotFound;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelLog;
    }
}

