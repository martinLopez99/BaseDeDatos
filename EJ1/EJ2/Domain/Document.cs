using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.Domain
{
    class Document
    {
        DocumentType Type = new DocumentType();

        public string Number { get; set; }
    }
}
