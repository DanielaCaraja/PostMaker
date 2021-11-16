using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG
        public const string DatabaseConnectionString = @"Data Source=DESKTOP-2DDKLQM\SQLEXPRESS;Initial Catalog=PostMaker;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
#endif
#if RELEASE
  public const string DatabaseConnectionString = @"";
#endif
    }
}
