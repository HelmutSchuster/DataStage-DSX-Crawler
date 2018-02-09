using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyseHugeTextFiles
{
  public class CSVField
  {
    public CSVField(int aMinLength, int aMaxLength)
    {
      MinLength = aMinLength;
      MaxLength = aMaxLength;
    }

    public int MinLength { get; set; }
    public int MaxLength { get; set; }
  }
}
