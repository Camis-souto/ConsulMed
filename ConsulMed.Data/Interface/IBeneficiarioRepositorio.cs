using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsulMed.Data;

namespace ConsulMed.Data.Interface
{
    public interface IBeneficiarioRepositorio
    {
        List<Dto.BeneficiarioDto> ListarTodas();
        Dto.BeneficiarioDto PorId(int idBeneficiario);
        int Atualizar(Dto.BeneficiarioDto cadastrarDto);
        int AtualizarId();
        int Cadastrar(Dto.BeneficiarioDto cadastrarDto);
        int Excluir(int idBeneficiario);
    }
}
