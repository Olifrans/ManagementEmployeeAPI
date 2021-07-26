using ManagementEmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployee.DataAccess.Data
{
    public class DataAccess //: IDataAccess
    {
        private List<EmpregadosModel> _empregados = new(); // sintaxe C# 9

        public DataAccess()
        {
            _empregados.Add(new EmpregadosModel { Id = 1, Nome="Frans", Sobrenome = "Oliveira" });
            _empregados.Add(new EmpregadosModel { Id = 2, Nome="Frans", Sobrenome = "Garcia" });
        }

        public List<EmpregadosModel> GetEmpregados()
        {
            return _empregados;
        }

        public EmpregadosModel AddEmpregados(string nome, string sobrenome)
        {
            EmpregadosModel newEmpregado = new() {Nome = nome, Sobrenome = sobrenome};
            newEmpregado.Id = _empregados.Max(x => x.Id) + 1;
            return newEmpregado;
        }
    }
}
