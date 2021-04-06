using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PruebaTecnicaTransUnion
{
    [XmlRoot("Salario")]
    public class Salario
    {
        [XmlAttribute]
        public int Mes { get; set; }
        public int Valor { get; set; }
    }
}
