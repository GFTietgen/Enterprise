using Application.Business.Abstratas;
using Application.Domain.Concretas;
using Application.Domain.Utils.Enums;
using Application.Repository.Concretas;
using System.Collections.Generic;

namespace Application.Business.Concretas
{
    public class FuncionarioBusiness : AbstractFacade<Funcionario, string>
    {
        private FuncionarioRepository repository;

        public FuncionarioBusiness(FuncionarioRepository _repository)
        {
            repository = _repository;
        }

        public override string Create(Funcionario data)
        {
            string operacao = string.Empty;
            string retorno = string.Empty;

            Funcionario func = new Funcionario(data.Nome, data.CPF_CNPJ, data.UF_RG, data.RG);

            operacao = repository.Create(func);

            if (operacao.Equals(Operacoes.CADASTRADO.ToString()))
            {
                retorno = Operacoes.CADASTRADO.ToString();
            }

            else retorno = Operacoes.ERRO.ToString();

            return retorno;
        }

        public override List<Funcionario> Read()
        {
            var funcionarios = repository.Read();

            return funcionarios;
        }

        public override Funcionario Read(int id)
        {
            var consulta = repository.Read(id);
            if (consulta != null)
            {
                Funcionario funcionario = new Funcionario(consulta.ID, consulta.Nome, consulta.CPF_CNPJ, consulta.UF_RG, consulta.RG);

                return funcionario;
            }

            else return null;
        }

        public override string Update(Funcionario data)
        {
            string retorno = string.Empty;
            string operacao = string.Empty;

            var consulta = repository.Read(data.ID);

            if (consulta != null)
            {
                Funcionario atualizado
                    = new Funcionario
                    (
                        string.IsNullOrEmpty(data.Nome)     ? consulta.Nome     : data.Nome,
                        string.IsNullOrEmpty(data.CPF_CNPJ) ? consulta.CPF_CNPJ : data.CPF_CNPJ,
                        string.IsNullOrEmpty(data.UF_RG)    ? consulta.UF_RG    : data.UF_RG,
                        string.IsNullOrEmpty(data.RG)       ? consulta.RG       : data.RG
                    );

                operacao = repository.Update(atualizado);

                if (operacao.Equals(Operacoes.ATUALIZADO.ToString()))
                    retorno = Operacoes.ATUALIZADO.ToString();

                else retorno = Operacoes.ERRO.ToString();

            }

            else retorno = Operacoes.ERRO.ToString();

            return retorno;
        }

        public override string Delete(int id)
        {
            string operacao = string.Empty;
            string retorno = string.Empty;

            var registro = repository.Read(id);

            if (registro != null)
                operacao = repository.Delete(id);

            else operacao = Operacoes.ERRO.ToString();

            retorno = operacao;

            return retorno;

        }
    }
}
