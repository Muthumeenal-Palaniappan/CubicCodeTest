using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Data.DTO;

namespace Calculator.Data.Repositories
{
    public class DummyDiagnosticRepository : IDiagnosticRepository
    {
        public void SaveDiagnosticInformation(DiagnosticInformationDTO dianosticInformation)
        {
           //dummy
        }
    }
}
