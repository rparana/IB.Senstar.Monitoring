namespace IB.SM.Data.Migrations
{
    using Model.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IB.SM.Data.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IB.SM.Data.Context.DataContext context)
        {
            
            ////Centrais
            //var Centrais = new List<Central>
            //{
            //        new Central { Nome="Central01", Endereco=1, Ultimoupdate=DateTime.Now },
            //        new Central { Nome="Central02", Endereco=2, Ultimoupdate=DateTime.Now },
            //        new Central { Nome="Central03", Endereco=3, Ultimoupdate=DateTime.Now }
            //};
            //Centrais.ForEach(c => context.Centrais.AddOrUpdate(p => p.Nome, c));
            //context.SaveChanges();

            ////Zonad
            //var Zones = new List<Zone>
            //    {
            //        new Zone { Nome="Z009 - MURO PERIMETRO DIR.", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z010 - FUNDOS LOTE 04", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z011 - FUNDOS LOTE 03", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z012 - FUNDOS LOTE 02", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z013 - FUNDOS LOTE 01", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z014 - LATERAL ESQ. LOTE 01", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z015 - MURO PERIMETRAL PONTE", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z016 - LATERAL DIREITA LOTE 16", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z017 - FUNDOS LOTE 16", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z018 - FUNDOS LOTE 17", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z019 - FUNDOS LOTE 18", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z020 - FUNDOS LOTE 19", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z021 - FUNDOS LOTE 20", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z022 - FUNDOS LOTE 21", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z023 - LATERAL DIR. LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z024 - FUNDOS LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z025 - LATERAL ESQ. LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z129 - LATERAL PORTARIA", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z130 - LATERAL DIR. LOTE 08", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z131 - LATERAL ESQ. AREA LAZER", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z132 - LATERAL ESQ. QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z133 - FUNDOS QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z134 - LATERAL DIR. QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z135 - FUNDOS SALÃO DE FESTAS", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z136 - LATERAL QUADRA TENIS", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z137 - LATERAL ESQ. LOTE 09", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z138 - FUNDOS LOTE 09", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z139 - FUNDOS LOTE 10", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z140 - FUNDOS LOTE 11", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z141 - FUNDOS LOTE 12", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z142 - FUNDOS LOTE 13", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z143 - FUNDOS LOTE 14", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z144 - FUNDOS LOTE 15", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z145 - MURO PERIMETRAL LAGO", Lado = "A", Ultimoupdate=DateTime.Now },
            //        new Zone { Nome="Z146 - MURO FRENTE LOTE 21", Lado = "A", Ultimoupdate=DateTime.Now },
            //    };
            //Zones.ForEach(z => context.Zonas.AddOrUpdate(p => p.Nome, z));
            //context.SaveChanges();


            ////Grupos
            //var g = new Grupo
            //{
            //    Nome = "Administradores",
            //    Descricao = "Administradores do Sistema.",
            //    Ultimoupdate = DateTime.Now,
            //    Permissao = new Permissao
            //    {
            //        AcknowledgeEvents = true,
            //        AlarmViewAccess = true,
            //        ClearEvents = true,
            //        CreateCentral = true,
            //        CreateGroup = true,
            //        CreateMaps = true,
            //        CreateUser = true,
            //        CreateZone = true,
            //        DeleteCentral = true,
            //        DeleteGroup = true,
            //        DeleteMaps = true,
            //        DeleteUser = true,
            //        DeleteZone = true,
            //        FindCentral = true,
            //        FindGroup = true,
            //        FindMaps = true,
            //        FindUser = true,
            //        FindZone = true,
            //        ImportEvents = true,
            //        SilenceEvents = true,
            //        SystemADMAccess = true,
            //        SystemConfig = true,
            //        UpdateCentral = true,
            //        UpdateGroup = true,
            //        UpdateMaps = true,
            //        UpdateUser = true,
            //        UpdateZone = true,
            //    }
            //};
            //context.Grupos.AddOrUpdate(p => p.Nome, g);
            //context.SaveChanges();

            ////Usuário Admin
            //var Usuario = new Usuario
            //{
            //    Alterasenha = true,
            //    Ativo = true,
            //    Descricao = "Administrador do Sistema.",
            //    Login = "Admin",
            //    Nome = "Administrador",
            //    Senha= "939783638B0149E7E4001AD931D20334E6AFBD68BC9A80113125331B1CCCFBD2990B4241DB8710C37FB3B4DB820B17D44EAE46BE56BE82CAFF72375A240CF7A3",
            //    Senhaexpira = false,
            //    Grupo_ID = g.ID
            //};
            //context.Usuarios.AddOrUpdate(p => p.Nome, Usuario);
            //context.SaveChanges();

            //var conf = new Config
            //{
            //    CaminhoLogs = "C:\\logs",
            //    CaminhoLogsSalvos = "c:\\logs\\Bkp",
            //    SalvarDepoisdeLer = true
            //};
            //context.Configuracoes.AddOrUpdate(p => p.CaminhoLogs, conf);
            //context.SaveChanges();

            ////
        }
    }
}
