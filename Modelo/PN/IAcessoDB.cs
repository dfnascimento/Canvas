using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public interface IAcessoDB<T>
    {
        bool SalvarUsuario(T registro);
        List<T> GetUsuarios();
        T GetUsuarioPorLoginSenha(T registro);
        T GetUsuarioPorCodigo(int codigo);
    }
}
