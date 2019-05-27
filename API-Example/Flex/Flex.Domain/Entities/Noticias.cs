using System;
using System.Collections.Generic;
using System.Text;

namespace Flex.Domain.Entities
{
    public class Noticias : BaseEntity
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }        
        public virtual Autor Autor { get; set; }
    }
}
