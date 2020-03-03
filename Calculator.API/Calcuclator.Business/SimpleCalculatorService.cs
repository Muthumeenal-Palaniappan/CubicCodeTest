using Calcuclator.Business.Enums;
using Calcuclator.Business.Interfaces;
using Calculator.Data.DTO;
using Calculator.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuclator.Business
{
    public class SimpleCalculatorService : ISimpleCalculatorService
    {
        private readonly IDiagnosticRepository _diagnosticRepository;
        public SimpleCalculatorService(IDiagnosticRepository diagnosticRepository)
        {
            _diagnosticRepository = diagnosticRepository;
        }
        public int Add(int start, int amount)
        {
            int result =  start + amount;
            _diagnosticRepository.SaveDiagnosticInformation(new DiagnosticInformationDTO(start, amount, result, Operations.Add.ToString(), "Success"));
            return result;
        }

        public int Divide(int start, int by)
        {
            if (by == 0)
            {
                _diagnosticRepository.SaveDiagnosticInformation(new DiagnosticInformationDTO(start, by, null, Operations.Divide.ToString(), "Error"));
                throw new DivideByZeroException("Cannot divide by zero");
            }
            int result = start / by;
            _diagnosticRepository.SaveDiagnosticInformation(new DiagnosticInformationDTO(start, by, result, Operations.Divide.ToString(), "Success"));
            return result;
        }

        public int Multiply(int start, int by)
        {
            int result =  start* by;
            _diagnosticRepository.SaveDiagnosticInformation(new DiagnosticInformationDTO(start, by, result, Operations.Multiply.ToString(), "Success"));
            return result;
        }

        public int Subtract(int start, int amount)
        {
            int result =  start - amount;
            _diagnosticRepository.SaveDiagnosticInformation(new DiagnosticInformationDTO(start, amount, result, Operations.Subtract.ToString(), "Success"));
            return result;
        }
    }
}
