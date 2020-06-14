using IntegradorIbge.Dto;
using System.Collections.Generic;

namespace IntegradorIbge.Servicos
{
    public interface IBuscadorMunicipio
    {
        List<MunicipioDto> BuscarMunicipiosDaUf(int uf);
        string BuscarMunicipiosDaUfJson(int uf);
    }
}
