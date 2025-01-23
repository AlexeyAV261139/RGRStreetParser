namespace RGRStreetParser;

partial class SubscriberForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriberForm));
        selectFileBtn = new Button();
        openFileDialog1 = new OpenFileDialog();
        labelFilePath = new Label();
        targetStreetTextBox = new TextBox();
        label1 = new Label();
        GetSurnamesBtn = new Button();
        surnamesLB = new ListBox();
        countAbunentsLabel = new Label();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // selectFileBtn
        // 
        selectFileBtn.Location = new Point(12, 37);
        selectFileBtn.Name = "selectFileBtn";
        selectFileBtn.Size = new Size(97, 23);
        selectFileBtn.TabIndex = 0;
        selectFileBtn.Text = "Выбрать файл";
        selectFileBtn.UseVisualStyleBackColor = true;
        selectFileBtn.Click += SelectFileBtn_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // labelFilePath
        // 
        labelFilePath.AutoSize = true;
        labelFilePath.Location = new Point(12, 19);
        labelFilePath.Name = "labelFilePath";
        labelFilePath.Size = new Size(111, 15);
        labelFilePath.TabIndex = 1;
        labelFilePath.Text = "Выбранный файл: ";
        // 
        // targetStreetTextBox
        // 
        targetStreetTextBox.Location = new Point(61, 31);
        targetStreetTextBox.Name = "targetStreetTextBox";
        targetStreetTextBox.Size = new Size(100, 23);
        targetStreetTextBox.TabIndex = 2;
        targetStreetTextBox.TextChanged += targetStreetTextBox_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 34);
        label1.Name = "label1";
        label1.Size = new Size(41, 15);
        label1.TabIndex = 3;
        label1.Text = "Улица";
        // 
        // GetSurnamesBtn
        // 
        GetSurnamesBtn.Location = new Point(12, 161);
        GetSurnamesBtn.Name = "GetSurnamesBtn";
        GetSurnamesBtn.Size = new Size(98, 41);
        GetSurnamesBtn.TabIndex = 4;
        GetSurnamesBtn.Text = "Показать всё";
        GetSurnamesBtn.UseVisualStyleBackColor = true;
        GetSurnamesBtn.Click += GetSurnamesBtn_Click;
        // 
        // surnamesLB
        // 
        surnamesLB.FormattingEnabled = true;
        surnamesLB.ItemHeight = 15;
        surnamesLB.Location = new Point(6, 13);
        surnamesLB.Name = "surnamesLB";
        surnamesLB.Size = new Size(184, 274);
        surnamesLB.TabIndex = 5;
        // 
        // countAbunentsLabel
        // 
        countAbunentsLabel.AutoSize = true;
        countAbunentsLabel.Location = new Point(6, 290);
        countAbunentsLabel.Name = "countAbunentsLabel";
        countAbunentsLabel.Size = new Size(136, 15);
        countAbunentsLabel.TabIndex = 6;
        countAbunentsLabel.Text = "Количество абонентов:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(targetStreetTextBox);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 72);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(200, 83);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Фильтр";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(surnamesLB);
        groupBox2.Controls.Add(countAbunentsLabel);
        groupBox2.Location = new Point(246, 37);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(197, 313);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        // 
        // SubscriberForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(469, 359);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(GetSurnamesBtn);
        Controls.Add(labelFilePath);
        Controls.Add(selectFileBtn);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "SubscriberForm";
        Text = "Поиск абонентов по улице";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button selectFileBtn;
    private OpenFileDialog openFileDialog1;
    private Label labelFilePath;
    private TextBox targetStreetTextBox;
    private Label label1;
    private Button GetSurnamesBtn;
    private ListBox surnamesLB;
    private Label countAbunentsLabel;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
}
