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
        selectFileBtn = new Button();
        openFileDialog1 = new OpenFileDialog();
        labelFilePath = new Label();
        targetStreetTextBox = new TextBox();
        label1 = new Label();
        GetSurnamesBtn = new Button();
        surnamesLB = new ListBox();
        countAbunentsLabel = new Label();
        panel1 = new Panel();
        panel1.SuspendLayout();
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
        // streetTB
        // 
        targetStreetTextBox.Location = new Point(104, 156);
        targetStreetTextBox.Name = "streetTB";
        targetStreetTextBox.Size = new Size(100, 23);
        targetStreetTextBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(57, 159);
        label1.Name = "label1";
        label1.Size = new Size(41, 15);
        label1.TabIndex = 3;
        label1.Text = "Улица";
        // 
        // GetSurnamesBtn
        // 
        GetSurnamesBtn.Location = new Point(72, 185);
        GetSurnamesBtn.Name = "GetSurnamesBtn";
        GetSurnamesBtn.Size = new Size(97, 23);
        GetSurnamesBtn.TabIndex = 4;
        GetSurnamesBtn.Text = "Поиск";
        GetSurnamesBtn.UseVisualStyleBackColor = true;
        GetSurnamesBtn.Click += GetSurnamesBtn_Click;
        // 
        // surnamesLB
        // 
        surnamesLB.FormattingEnabled = true;
        surnamesLB.ItemHeight = 15;
        surnamesLB.Location = new Point(16, 17);
        surnamesLB.Name = "surnamesLB";
        surnamesLB.Size = new Size(203, 199);
        surnamesLB.TabIndex = 5;
        // 
        // countAbunentsLabel
        // 
        countAbunentsLabel.AutoSize = true;
        countAbunentsLabel.Location = new Point(16, 219);
        countAbunentsLabel.Name = "countAbunentsLabel";
        countAbunentsLabel.Size = new Size(136, 15);
        countAbunentsLabel.TabIndex = 6;
        countAbunentsLabel.Text = "Количество абонентов:";
        // 
        // panel1
        // 
        panel1.Controls.Add(surnamesLB);
        panel1.Controls.Add(countAbunentsLabel);
        panel1.Location = new Point(282, 60);
        panel1.Name = "panel1";
        panel1.Size = new Size(282, 282);
        panel1.TabIndex = 7;
        // 
        // SubscriberForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(628, 368);
        Controls.Add(panel1);
        Controls.Add(GetSurnamesBtn);
        Controls.Add(label1);
        Controls.Add(targetStreetTextBox);
        Controls.Add(labelFilePath);
        Controls.Add(selectFileBtn);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Name = "SubscriberForm";
        Text = "Поиск абонентов по улице";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
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
    private Panel panel1;
}
