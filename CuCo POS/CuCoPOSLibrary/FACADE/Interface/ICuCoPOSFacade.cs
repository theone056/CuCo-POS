using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCoPOSLib.FACADE.Interface
{
    public interface ICuCoPOSFacade
    {
        Task<List<Dictionary<string, object>>> GetAllMenuItem();
        Task<bool> AddItem();
    }
}
