using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AnalyseHugeTextFiles
{
  public partial class Form1 : Form
  {
    private int fMin_LineLength = 0;
    private int fMax_LineLength = 0;
    private long fRowCount;
    private CSVField[] fFields = null;
    private char fDelimiter;
    private static int LOOP_WAIT_COUNT = 10000;
    private string[] fColNames;

    public Form1()
    {
      InitializeComponent();

      cbxDelimiter.Items.Clear();
      cbxDelimiter.Items.Add(new ComboBoxCharItem(',', "comma"));
      cbxDelimiter.Items.Add(new ComboBoxCharItem(';', "semicolon"));
      cbxDelimiter.Items.Add(new ComboBoxCharItem('#', "hash"));
      cbxDelimiter.Items.Add(new ComboBoxCharItem('|', "pipe"));
      cbxDelimiter.SelectedIndex = 0;
    }



    private void btnStart_Click(object sender, EventArgs e)
    {
      if (File.Exists(txtFilePath.Text))
      {
        ResetOutputValues();
        tsStatusLabel.Text = "Scanning";
        lstWarnings.Items.Clear();
        //lstWarnings.Items.Add("");
        lstWarnings.Items.Add("Scanning " + txtFilePath.Text);

        ReadTxtFile(txtFilePath.Text);

        ShowOutputValues();
        ConvertFieldsToTable();
        tsStatusLabel.Text = "Done";

        Color backgroundColor = this.BackColor;
        this.BackColor = Color.Green;
        Application.DoEvents();
        System.Threading.Thread.Sleep(300);
        this.BackColor = backgroundColor;
      }
      else
      {
        lstWarnings.Items.Add("File does not exist.");
      }
    }

    private void ReadTxtFile(string aFilePath)
    {
      int lColumnCount = 0;
      fDelimiter = ((ComboBoxCharItem)cbxDelimiter.SelectedItem).Value;
      bool lFirstLineIsHeader = chkFirstLineIsHeader.Checked;
      fColNames = null;

      if (fFields != null)
      {
        Array.Clear(fFields, 0, fFields.Length);
      }

      Regex regEx = new Regex(@"^[a-zA-Z0-9\s+-.,;/&()\\""'']*$");
      string regExString = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";

      using (StreamReader sr = new StreamReader(aFilePath))
      {
        String lTextLine;
        fRowCount = 1;
        while ((lTextLine = sr.ReadLine()) != null)
        {
          // First line is header.
          if ((fRowCount == 1) && lFirstLineIsHeader)
          {
            // Read the field names
            //var columnNames = lTextLine.Split(fDelimiter);
            var columnNames = Regex.Split(lTextLine, regExString);  // ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            fColNames = new string[columnNames.Length];

            for (int j = 0; j < columnNames.Length; j++)
            {
              fColNames[j] = columnNames[j];
            }

            fRowCount++;
            continue;
          }


          /* for the first data row initialize some start values */
          if (((fRowCount == 2) && lFirstLineIsHeader) || ((fRowCount == 1) && (!lFirstLineIsHeader)))
          {
            fMin_LineLength = lTextLine.Length;

            /* Split it into the content */
            //lColumnCount = lTextLine.Split(fDelimiter).Length;
            lColumnCount = Regex.Split(lTextLine, regExString).Length;
            if (!lFirstLineIsHeader)
            {
              fColNames = new string[lColumnCount];
            }

            fFields = new CSVField[lColumnCount];
            //Initialize the fields
            for (int j = 0; j < lColumnCount; j++)
            {
              fFields[j] = new CSVField(int.MaxValue, int.MinValue);
              if (!lFirstLineIsHeader)
              {
                fColNames[j] = "Column " + j.ToString();
              }
            }
          }

          /* Split the line into the delimiter separated elements. */
          //var values = lTextLine.Split(fDelimiter);
          var values = Regex.Split(lTextLine, regExString);

          //Check for invalid column count (caused by empty line or else).
          int lCurrentColCount = values.Length;
          if (lColumnCount != lCurrentColCount)
          {
            if (lTextLine.Trim().Length == 0)
            {
              lstWarnings.Items.Add("Empty line at row " + fRowCount);
            }
            else
            {
              lstWarnings.Items.Add("Column count error at line " + fRowCount);
            }

            fRowCount++;
            continue;
          }

          // Analyse each split item.
          for (int i = 0; i < lColumnCount; i++)
          {
            int elementsSize = values[i].Length;
            fFields[i].MinLength = Math.Min(elementsSize, fFields[i].MinLength);
            fFields[i].MaxLength = Math.Max(elementsSize, fFields[i].MaxLength);

            if (!regEx.IsMatch(values[i]))
            {
              // Validation failed
              if (lFirstLineIsHeader)
              {
                lstWarnings.Items.Add(String.Format("Validation error at line {0} and column {1} ({2}): {3}",
                 fRowCount, i, fColNames[i], values[i]));
              }
              else
              {
                lstWarnings.Items.Add("Validation error at policy " + values[1] + "," +  values[2] + "," + values[3] + "," +
                              " and column " + i.ToString() + ": " + values[i]);

                //lstWarnings.Items.Add("Validation error at line " + fRowCount.ToString() +
                //              " and column " + i.ToString() + ": " + values[i]);
              }
            }
          }

          /* Calculate the total line length */
          int lineLength = lTextLine.Length;
          if (lineLength < fMin_LineLength)
          {
            fMin_LineLength = lineLength;
          }
          if (lineLength > fMax_LineLength)
          {
            fMax_LineLength = lineLength;
          }

          if (fRowCount % LOOP_WAIT_COUNT == 0)
          {
            tsStatusLabel.Text = fRowCount.ToString() + " records read.";
            Application.DoEvents();
          }

          fRowCount++;
        }
      }

    }

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
      try
      {
        var lInitalDir = ConfigurationManager.AppSettings["SourceDirectory"].ToString();
        openFileDialog1.InitialDirectory = lInitalDir;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Check the config file for default Source directory." + Environment.NewLine + ex.Message);
      }
      
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        txtFilePath.Text = openFileDialog1.FileName;
      }
    }

    private void ResetOutputValues()
    {
      fColNames = null;

      fMin_LineLength = 0;
      fMax_LineLength = 0;
      lblLineLength.Text = "?";
      lblRowCount.Text = "?";
    }

    private void ShowOutputValues()
    {
      lblLineLength.Text = fMin_LineLength.ToString() + " - " + fMax_LineLength.ToString();
      lblRowCount.Text = fRowCount.ToString();
    }

    private void ConvertFieldsToTable()
    {
      DataTable dataTable = new DataTable();
      DataColumn col1 = new DataColumn("Column", typeof(String));
      DataColumn col2 = new DataColumn("Min Length", typeof(int));
      DataColumn col3 = new DataColumn("Max Length", typeof(int));
      dataTable.Columns.Add(col1);
      dataTable.Columns.Add(col2);
      dataTable.Columns.Add(col3);

      int index = 0;
      foreach (CSVField field in fFields)
      {
        DataRow row = dataTable.NewRow();
        row[0] = fColNames[index];
        row[1] = field.MinLength;
        row[2] = field.MaxLength;

        dataTable.Rows.Add(row);

        index++;
      };

      gridView.DataSource = dataTable;
    }

    private void toolStripTextBox_Click(object sender, EventArgs e)
    {
      SaveWarnings();
    }

    private void SaveWarnings()
    {
      SaveFileDialog fileSaver = new SaveFileDialog();

      try
      {
        string lInitialDirectory = ConfigurationManager.AppSettings["SaveDirectory"];
        fileSaver.InitialDirectory = lInitialDirectory;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Check the config file for default settings." + Environment.NewLine + ex.Message);
      }

      fileSaver.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      fileSaver.FilterIndex = 1;
      fileSaver.DefaultExt = ".txt";

      DialogResult dialogResult = fileSaver.ShowDialog();
      if (dialogResult != DialogResult.OK)
      {
        return;
      }
      string lFilePath = fileSaver.FileName;

      // Convert list items to StringBuilder strings with line breaks.
      try
      {
        StringBuilder sb = new StringBuilder();

        foreach (var item in lstWarnings.Items)
        {
          sb.Append(item.ToString() + Environment.NewLine);
        }

        File.WriteAllText(lFilePath, sb.ToString());
        MessageBox.Show("File saved to " + lFilePath);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Problem with saving: " + ex.Message);
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

  }
}
