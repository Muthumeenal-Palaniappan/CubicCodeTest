using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calcuclator.Business.Interfaces;
using Calcuclator.Business;
using Moq;
using Calculator.Data.Repositories;

namespace Calculator.Business.Tests
{
    [TestClass]

    public class SimpleCalculatorTests
    {
        readonly Mock<IDiagnosticRepository> _dataAccessMock;
        readonly SimpleCalculatorService _simpleCalcService;
        public SimpleCalculatorTests()
        {
            _dataAccessMock = new Mock<IDiagnosticRepository>();
            _simpleCalcService = new SimpleCalculatorService(_dataAccessMock.Object);
        }
        [TestMethod()]
        public void AddTest_PositiveCase()
        {
            int firstParam = 13;
            int secondParam = 15;
            int expectedResult = 28;
            _dataAccessMock.Setup(x => x.SaveDiagnosticInformation(new Data.DTO.DiagnosticInformationDTO(firstParam, secondParam,expectedResult,"Add","success")));
            int actualResult = _simpleCalcService.Add(firstParam, secondParam);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void DivideTest_PositiveCase()
        {
            int firstParam = 150;
            int secondParam = 15;
            int expectedResult = 10;
            _dataAccessMock.Setup(x => x.SaveDiagnosticInformation(new Data.DTO.DiagnosticInformationDTO(firstParam, secondParam, expectedResult, "Divide", "success")));
            int actualResult = _simpleCalcService.Divide(firstParam, secondParam);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Cannot divide by zero")]
        public void DivideTest_DivideByZeroException()
        {
            int firstParam = 500;
            int secondParam = 0;
            int? expectedResult = null;
            _dataAccessMock.Setup(x => x.SaveDiagnosticInformation(new Data.DTO.DiagnosticInformationDTO(firstParam, secondParam, expectedResult, "Divide", "Error")));
            int actualResult = _simpleCalcService.Divide(firstParam, secondParam);
        }

        [TestMethod()]
        public void MultiplyTest_PositiveCase()
        {
            int firstParam = 12;
            int secondParam = 11;
            int expectedResult = 132;
            _dataAccessMock.Setup(x => x.SaveDiagnosticInformation(new Data.DTO.DiagnosticInformationDTO(firstParam, secondParam, expectedResult, "Mulltiply", "Success")));
            int actualResult = _simpleCalcService.Multiply(firstParam, secondParam);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void SubtractTest_PositiveCase()
        {
            int firstParam = 99;
            int secondParam = 11;
            int expectedResult = 88;
            _dataAccessMock.Setup(x => x.SaveDiagnosticInformation(new Data.DTO.DiagnosticInformationDTO(firstParam, secondParam, expectedResult, "Subtract", "Success")));
            int actualResult = _simpleCalcService.Subtract(firstParam, secondParam);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
