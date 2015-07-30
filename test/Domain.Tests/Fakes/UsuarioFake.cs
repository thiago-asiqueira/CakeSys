using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.CakeSys.Domain.Tests.Fakes
{
    public static class UsuarioFake
    {
        public static UsuarioEntity MakeSingle()
        {
            return new UsuarioEntity(1,"Thiago Siqueira","thiago.asiqueira","123456",PerfilTipo.Administrador,Status.Ativo);
        }
    }
}
