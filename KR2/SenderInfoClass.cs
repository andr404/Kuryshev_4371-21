using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    public class SenderInfoClass
    {
        string _fromName, _fromEmail, _toName, _toEmail, _congrText;
        public SenderInfoClass(string fromName, string fromEmail, string toName, string toEmail, string congrText)
        {
            _fromName = fromName;
            _fromEmail = fromEmail;
            _toName = toName;
            _toEmail = toEmail;
            _congrText = congrText;
        }
        public string FromName { get => _fromName; }
        public string FromEmail { get => _fromEmail; }
        public string ToName { get => _toName; }
        public string ToEmail { get => _toEmail; }
        public string CongrText { get => _congrText; }
    }
}
