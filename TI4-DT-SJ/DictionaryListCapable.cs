using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI4_DT_SJ {
  public interface Dictionaryable {
    Dictionary<string, dynamic> ValuesAsDict { get; }
  }
}
