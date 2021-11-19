using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Domain
{
    public class Document
    {
        DocumentType Type = new DocumentType();

        public string Number { get; set; }
    }
}
