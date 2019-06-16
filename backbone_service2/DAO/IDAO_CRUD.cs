using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backbone_service2.DAO
{
    interface IDAO_CRUD:IDisposable
    {
        bool Create();

        bool Update();

        bool Delete();
    }
}
