using Calculator.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repositories
{
    public interface IDiagnosticRepository
    {
        void SaveDiagnosticInformation(DiagnosticInformationDTO dianosticInformation);

    }
}
