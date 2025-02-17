using RGRStreetParser.Exceptions;
using RGRStreetParser.Interfaces;
using RGRStreetParser.Models;

namespace RGRStreetParser;

public partial class SubscriberForm : Form
{
    private ISubscribersDataStorageGetter? _subscribersDataStorage;

    public SubscriberForm()
    {
        InitializeComponent();
        openFileDialog1.Filter = "��������� �����(*.txt)|*.txt";
    }

    private void SelectFileBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SelectFileButton();
        }
        catch (Exception ex)
        {
            string message = ex.Message == string.Empty
                ? "������ ������ �����"
                : ex.Message;
            MessageBox.Show(message);
        }
    }

    private void SelectFileButton()
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        string path = openFileDialog1.FileName;
        labelFilePath.Text = path;
        _subscribersDataStorage = new SubscribersDataTxtFileStorage(path);
    }

    private void GetSurnamesBtn_Click(object sender, EventArgs e)
    {
        try
        {
            GetSurnames();
        }
        catch (SubscriberException ex)
        {
            MessageBox.Show(ex.Message);
        }
        catch
        {
            MessageBox.Show("������ ��������� ��������� ������");
        }
    }

    private void GetSurnames()
    {
        string targetStreet = targetStreetTextBox.Text;

        IEnumerable<SubscribersData> data = _subscribersDataStorage?.GetSubscribersData()
            ?? throw new SubscriberException("�������� ��������� ������ �� ����������");

        var result = (targetStreet == string.Empty
            ? data
            : data.Where(x => x.Adress.Street == targetStreet))
            .Select(x => x.Initials.Surname)
            .ToArray();

        int count = result.Count();

        surnamesLB.Items.Clear();
        surnamesLB.Items.AddRange(result);
        countAbunentsLabel.Text = $"���������� ���������: {count}";
    }

    private void targetStreetTextBox_TextChanged(object sender, EventArgs e)
    {
        if (targetStreetTextBox.Text != string.Empty)
        {
            GetSurnamesBtn.Text = "�����";
            return;
        }

        GetSurnamesBtn.Text = "�������� ��";
    }
}