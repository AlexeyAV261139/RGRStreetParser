using System.Text.RegularExpressions;
using RGRStreetParser.Exceptions;
using RGRStreetParser.Interfaces;
using RGRStreetParser.Models;

namespace RGRStreetParser;

public partial class SubscriberForm : Form
{
    private ISubscribersDataStorage? _subscribersDataStorage;

    public SubscriberForm()
    {
        InitializeComponent();
        openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt";
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
                ? "Ошибка выбора файла"
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
            MessageBox.Show("Ошибка обработки источника данных");
        }
    }

    private void GetSurnames()
    {
        string targetStreet = targetStreetTextBox.Text;

        IEnumerable<SubscribersData> data = _subscribersDataStorage?.GetSubscribersData()
            ?? throw new SubscriberException("Источник получения данных не установлен");

        var result = targetStreet == string.Empty
            ? data
            : data.Where(x => x.Adress.Street == targetStreet);  
        
        result = result.ToArray();

        int count = result.Count();

        surnamesLB.DataContext = result;
        countAbunentsLabel.Text = $"Количество абонентов: {count}";
    }
}