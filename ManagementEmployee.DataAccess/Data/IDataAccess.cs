using ManagementEmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployee.DataAccess.Data
{
    public interface IDataAccess
    {
        List<EmpregadosModel> GetEmpregados();
        EmpregadosModel AddEmpregados(string Nome, string Sobrenome);
    }
}
