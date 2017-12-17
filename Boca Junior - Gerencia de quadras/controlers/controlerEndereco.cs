using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Boca_Junior___Gerencia_de_quadras
{
    class controlerEndereco
    {

        daoEndereco daoEndereco = new daoEndereco();
       

        public modelEndereco carregaEndereco(string cep)
        {
            modelEndereco enderecoCb = new modelEndereco();
            modelBairro bairroCb = new modelBairro();
            modelCidade cidadeCb = new modelCidade();
            modelUf ufCb = new modelUf();
            MySqlDataReader endereco = daoEndereco.BuscaEndereco(cep);
            while(endereco.Read()){

                enderecoCb.Cep = cep;
                enderecoCb.Endereco = endereco["endereco_logradouro"].ToString();
                bairroCb.Nome = endereco["bairro_descricao"].ToString();
                cidadeCb.Nome = endereco["cidade_descricao"].ToString();
                ufCb.Sigla = endereco["uf_sigla"].ToString();
                cidadeCb.Uf = ufCb;
                bairroCb.Cidade = cidadeCb;
                enderecoCb.Bairro = bairroCb;                
            }
            return enderecoCb;
        }
        public MySqlDataReader buscaUF()
        {
           return daoEndereco.buscaUF();
        }
        public MySqlDataReader buscaCidade(string UF_cod)
        {
            return daoEndereco.buscaCidade(UF_cod);
        }
        public string buscaCodCidade(string sigla)
        {
            MySqlDataReader cod_uf = daoEndereco.buscaCidadeCod(sigla);
            while(cod_uf.Read()){
                return cod_uf["cidade_codigo"].ToString();
            }
            return null;
        }
        public string buscaCodUF(string sigla)
        {
            MySqlDataReader cod_uf = daoEndereco.buscaUF(sigla);
            while (cod_uf.Read())
            {
                return cod_uf["uf_codigo"].ToString();
            }
            return null;
        }
        public MySqlDataReader buscaBairro(string cidade_cod)
        {
            return daoEndereco.buscaBairro(cidade_cod);
        }
    }
}
