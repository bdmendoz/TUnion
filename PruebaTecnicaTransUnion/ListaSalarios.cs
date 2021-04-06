using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PruebaTecnicaTransUnion
{
    [XmlRoot("ListaSalarios")]
    public class ListaSalarios
    {
        
        [XmlElement("Anualidad")]
        public Anualidad Anualidad { get; set;} 

    }
    [XmlRoot("Anualidad")]
    public class Anualidad
    {
        [XmlAttribute]
        public int Anio { get; set; }
        [XmlElement("Salario")]
        public List<Salario> Salarios { get; } = new List<Salario>();

    }
}
