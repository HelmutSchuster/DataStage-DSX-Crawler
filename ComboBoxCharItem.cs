using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyseHugeTextFiles
{
  public class ComboBoxCharItem
  {
    public ComboBoxCharItem(char aValue, string aDisplayText)
    {
      Value = aValue;
      DisplayText = aDisplayText;
    }

    public char Value { get; set; }
    protected string DisplayText { get; set; }

    //Needed so that the combo box displays the text.
    public override string ToString()
    {
      return DisplayText;
    }

  }
}
