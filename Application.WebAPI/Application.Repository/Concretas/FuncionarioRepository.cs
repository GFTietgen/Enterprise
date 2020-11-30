using System;
using System.Collections.Generic;
using Application.Domain.Concretas;
using Application.Domain.Utils.Enums;

namespace Application.Repository.Concretas
{
    public class FuncionarioRepository : AbstractRepository<Funcionario, string>
    {
        public FuncionarioRepository() : base() { }

        public override string Create(Funcionario data)
        {
            string _sql = $"INSERT INTO funcionarios (NOME, CPF_CNPJ, UF_RG, RG, dt_Cadastro) VALUES ({data.Nome}, {data.CPF_CNPJ}, {data.UF_RG}, {data.RG}, {data.dtCadastro})";
            string retorno = string.Empty;

            try
            {
                ExecuteSql(_sql);

                retorno = Operacoes.CADASTRADO.ToString();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }

        public override List<Funcionario> Read()
        {
            string _sql = $"SELECT * FROM funcionarios";
            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                var consulta = ReturnDataTable(_sql);

                if (consulta.Rows.Count > 0)
                {
                    for (int i = 0; i < consulta.Rows.Count; i++)
                    {
                        Funcionario funcionario = new Funcionario
                            (
                                Convert.ToInt32(consulta.Rows[i]["ID"].ToString()),
                                Convert.ToString(consulta.Rows[i]["NOME"].ToString()),
                                Convert.ToString(consulta.Rows[i]["CPF_CNPJ"].ToString()),
                                Convert.ToString(consulta.Rows[i]["UF_RG"].ToString()),
                                Convert.ToString(consulta.Rows[i]["RG"].ToString())
                            );

                        funcionarios.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return funcionarios;
        }

        public override Funcionario Read(int id)
        {
            string _sql = $"SELECT * FROM funcionarios WHERE ID = {id}";

            try
            {
                var consulta = ReturnDataTable(_sql);
                if (consulta.Rows.Count > 0)
                {
                    Funcionario funcionario = new Funcionario
                        (
                                Convert.ToInt32(consulta.Rows[0]["ID"].ToString()),
                                Convert.ToString(consulta.Rows[0]["NOME"].ToString()),
                                Convert.ToString(consulta.Rows[0]["CPF_CNPJ"].ToString()),
                                Convert.ToString(consulta.Rows[0]["UF_RG"].ToString()),
                                Convert.ToString(consulta.Rows[0]["RG"].ToString())
                        );
                    return funcionario;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override string Update(Funcionario data)
        {
            string _sql = $"UPDATE Funcionarios SET NOME = {data.Nome}, CPF_CNPJ = {data.CPF_CNPJ}, UF_RG = {data.UF_RG}, RG = {data.RG} WHERE ID = {data.ID}";
            string retorno = string.Empty;

            try
            {
                ExecuteSql(_sql);

                retorno = Operacoes.ATUALIZADO.ToString();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }

        public override string Delete(int id)
        {
            string _sql = $"DELETE FROM Funcionarios WHERE ID = {id}";
            string retorno = string.Empty;

            try
            {
                ExecuteSql(_sql);

                retorno = Operacoes.DELETADO.ToString();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }
    }
}
