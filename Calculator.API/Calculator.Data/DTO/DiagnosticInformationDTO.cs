using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.DTO
{
    public class DiagnosticInformationDTO
    {
        private int _firstParameter;
        private int _secondParameter;
        private string _operation;
        private string _messageInfo;
        private int? _result;
        public DiagnosticInformationDTO(int start, int amount, int? result, string operation, string messageInfo)
        {
            _firstParameter = start;
            _secondParameter = amount;
            _result = result;
            _operation = operation;
            _messageInfo = messageInfo;
        }

        public int FirstParameter
        {
            get { return _firstParameter; }
            set { _firstParameter = value; }
        }
        public int SecondParameter
        {
            get { return _secondParameter; }
            set { _secondParameter = value; }
        }
        public string Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }
        public Nullable<int> Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public string MessageInfo
        {
            get { return _messageInfo; }
            set { _messageInfo = value; }
        }
    }
}
