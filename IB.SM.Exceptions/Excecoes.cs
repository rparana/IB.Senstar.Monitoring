using System;

namespace IB.SM.Exceptions
{
    public class Excecoes
    {
        //Todos
        public string ObjetoVazio { get; set; }
        public string SemPermissao { get; set; }
        public string FormatodoCodigoInvalido { get; set; }

        //Grupos
        public string GrupoSemNome { get; set; }
        public string GrupojaExiste { get; set; }
        public string GruponaoInformado { get; set; }
        public string GruponaoLocalizado { get; set; }
        public string GrupoSemPermissaoConsulta { get; set; }
        public string GrupoSemPermissaoIncluir { get; set; }
        public string GrupoSemPermissaoAlterar { get; set; }
        public string GrupoSemPermissaoExcluir { get; set; }

        //Usuarios
        public string UsuariosemLogin { get; set; }
        public string InformeLogin { get; set; }
        public string UsuariosemSenha { get; set; }
        public string InformeSenha { get; set; }
        public string UsuarioeSenhaIncorretos { get; set; }
        public string UsuariosemAcessoSistema { get; set; }
        public string UsuarionaoLocalizado { get; set; }
        public string UsuarioContaDesativada { get; set; }

        //Senhas
        public string SenhaDiferentedaConfirmacao { get; set; }
        public string SenhaNaoPodeSerVazio { get; set; }
        public string SenhaNaoPodeSerIgualAntiga { get; set; }

        //Centrais
        public string CentralNaoLocalizada { get; set; }
        public string CentralsemNome { get; set; }
        public string CentralsemEndereco { get; set; }
        public string CentralEnderecoRepetido { get; set; }
        public string CentralNomeRepetido { get; set; }

        //Zonas
        public string ZonaNaoLocalizada { get; set; }
        public string ZonasemNome { get; set; }
        public string ZonasemNumero { get; set; }
        public string ZonaNumeroRepetido { get; set; }
        public string ZonaNomeRepetido { get; set; }

        //Config
        public string ConfigNaoLocalizada { get; set; }
        public string ConfigSemCaminhoLog { get; set; }
        public string ConfigSemCaminhoSalvaLog { get; set; }

        //Eventos
        public string EventoNotadeReconhecimentoemBranco { get; set; }


        public Excecoes()
        {
            //Todos
            this.ObjetoVazio = "O Objeto encontra-se Vazio. Verifique";
            this.SemPermissao = "Você não tem permissão para realizar esta operação.";
            this.FormatodoCodigoInvalido = "O Código informado esta em um formato incorreto. Verifique.";

            //Grupo
            this.GrupoSemNome = "O nome do Grupo é obrigatório.";
            this.GrupojaExiste = "Já existe um Grupo com este nome.";
            this.GruponaoInformado = "O Grupo não foi informado.";
            this.GruponaoLocalizado = "O Grupo não foi localizado.";
            this.GrupoSemPermissaoConsulta = "Sem Permissão para consultar Grupo.";
            this.GrupoSemPermissaoIncluir = "Sem Permissão para incluir Grupo.";
            this.GrupoSemPermissaoAlterar = "Sem Permissão para alterar Grupo.";
            this.GrupoSemPermissaoExcluir = "Sem Permissão para excluir Grupo.";

            //Usuarios
            this.UsuariosemLogin = "Usuário deve conter um Login";
            this.UsuariosemSenha = "Usuário deve conter uma senha";
            this.InformeLogin = "Informe o nome do usuário.";
            this.InformeSenha = "Informe a senha.";
            this.UsuarioeSenhaIncorretos = "Login ou senha inválida!";
            this.UsuariosemAcessoSistema = "O usuário informado não possui permissão de acesso ao sistema.";
            this.UsuarionaoLocalizado = "O usuário não foi localizado.";
            this.UsuarioContaDesativada = "Conta desativada.";

            //Senhas
            this.SenhaDiferentedaConfirmacao = "Senhas digitadas não são iguais.";
            this.SenhaNaoPodeSerVazio = "Senha não pode ser em branco.";
            this.SenhaNaoPodeSerIgualAntiga = "Senha não pode ser igual a antiga.";

            //Centrais
            this.CentralNaoLocalizada = "Central não localizada.";
            this.CentralsemNome = "Nome é de preenchimento obrigatório.";
            this.CentralsemEndereco = "Endereço é de preenchimento obrigatório.";
            this.CentralEnderecoRepetido = "Já existe uma Central com este endereço.";
            this.CentralNomeRepetido = "Já existe uma Central com este nome.";

            //Zonas
            this.ZonaNaoLocalizada = "Zona não localizada.";
            this.ZonasemNome = "Nome é de preenchimento obrigatório.";
            this.ZonasemNumero = "Número é de preenchimento obrigatório.";
            this.ZonaNumeroRepetido = "Já existe uma Zona com este Número.";
            this.ZonaNomeRepetido = "Já existe uma Zona com este nome.";

            //Config
            this.ConfigNaoLocalizada = "Configuração não localizada.";
            this.ConfigSemCaminhoLog = "É necessário informar a pasta onde encontram-se os Logs.";
            this.ConfigSemCaminhoSalvaLog = "É necessário informar a pasta onde será salvo os Logs após coleta.";

            //Eventos
            this.EventoNotadeReconhecimentoemBranco = "É necessário informar uma nota de reconhecimento.";
        }
    }
}
