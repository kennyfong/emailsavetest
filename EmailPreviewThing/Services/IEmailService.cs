using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailPreviewThing.Services
{
    public interface IEmailService
    {
        void Send(string emailLocation);
        string GenerateEmailAndSave(string pdfLocation);
    }
}
