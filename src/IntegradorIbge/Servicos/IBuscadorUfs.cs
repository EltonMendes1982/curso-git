using IntegradorIbge.Dto;
using System.Collections.Generic;

namespace IntegradorIbge.Servicos
{
    public interface IBuscadorUfs
    {
        List<UfDto> BuscarUfs();
    }
}