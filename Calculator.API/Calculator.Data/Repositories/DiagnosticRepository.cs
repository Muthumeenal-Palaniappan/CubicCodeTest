using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Data.DTO;

namespace Calculator.Data.Repositories
{
    public class DiagnosticRepository : IDiagnosticRepository
    {
        public void SaveDiagnosticInformation(DiagnosticInformationDTO dianosticInformation)
        {
            using (var _dbContext = new CalculatorSystemEntities1())
            {
               var itemToSave =  MapFromDignosticInformationDTO(dianosticInformation);
                _dbContext.DiagnosticInformations.Add(itemToSave);
                _dbContext.Entry(itemToSave).State = System.Data.Entity.EntityState.Added;
                _dbContext.SaveChanges();
            }
        }

        private static DiagnosticInformation MapFromDignosticInformationDTO(DiagnosticInformationDTO dianosticInformation)
        {
            return  new DiagnosticInformation()
            {
                FirstParameter = dianosticInformation.FirstParameter,
                SecondParameter = dianosticInformation.SecondParameter,
                MessageInfo = dianosticInformation.MessageInfo,
                Result = dianosticInformation.Result,
                Operation = dianosticInformation.Operation,
                CreatedTimeStamp = DateTime.Now
            };
        }
    }
}
