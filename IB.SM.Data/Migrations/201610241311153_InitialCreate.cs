namespace IB.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Centrais",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 4000),
                        Descricao = c.String(maxLength: 4000),
                        Ultimoupdate = c.DateTime(nullable: false),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Zonas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        NumeroZona = c.Int(nullable: false),
                        NumeroZonaCentral = c.Int(nullable: false),
                        Lado = c.String(maxLength: 1),
                        Inicio = c.Int(nullable: false),
                        Fim = c.Int(nullable: false),
                        Ultimoupdate = c.DateTime(nullable: false),
                        Central_ID = c.Int(),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Centrais", t => t.Central_ID)
                .Index(t => t.Central_ID);
            
            CreateTable(
                "dbo.Configuracoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tempoleitura = c.Int(nullable: false),
                        CaminhoLogs = c.String(maxLength: 4000),
                        CaminhoLogsSalvos = c.String(maxLength: 4000),
                        SalvarDepoisdeLer = c.Boolean(nullable: false),
                        Ultimoupdate = c.DateTime(nullable: false),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Grupos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 4000),
                        Descricao = c.String(maxLength: 4000),
                        Ultimoupdate = c.DateTime(nullable: false),
                        Permisssao_ID = c.Int(nullable: false),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Permissoes", t => t.Permisssao_ID)
                .Index(t => t.Permisssao_ID);
            
            CreateTable(
                "dbo.Permissoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SystemADMAccess = c.Boolean(nullable: false),
                        AlarmViewAccess = c.Boolean(nullable: false),
                        SystemConfig = c.Boolean(nullable: false),
                        CreateUser = c.Boolean(nullable: false),
                        UpdateUser = c.Boolean(nullable: false),
                        FindUser = c.Boolean(nullable: false),
                        DeleteUser = c.Boolean(nullable: false),
                        CreateGroup = c.Boolean(nullable: false),
                        UpdateGroup = c.Boolean(nullable: false),
                        FindGroup = c.Boolean(nullable: false),
                        DeleteGroup = c.Boolean(nullable: false),
                        CreateCentral = c.Boolean(nullable: false),
                        UpdateCentral = c.Boolean(nullable: false),
                        FindCentral = c.Boolean(nullable: false),
                        DeleteCentral = c.Boolean(nullable: false),
                        CreateZone = c.Boolean(nullable: false),
                        UpdateZone = c.Boolean(nullable: false),
                        FindZone = c.Boolean(nullable: false),
                        DeleteZone = c.Boolean(nullable: false),
                        CreateMaps = c.Boolean(nullable: false),
                        UpdateMaps = c.Boolean(nullable: false),
                        FindMaps = c.Boolean(nullable: false),
                        DeleteMaps = c.Boolean(nullable: false),
                        ClearEvents = c.Boolean(nullable: false),
                        ImportEvents = c.Boolean(nullable: false),
                        AcknowledgeEvents = c.Boolean(nullable: false),
                        SilenceEvents = c.Boolean(nullable: false),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 4000),
                        Descricao = c.String(maxLength: 4000),
                        Login = c.String(maxLength: 4000),
                        Senha = c.String(maxLength: 4000),
                        Senhaexpira = c.Boolean(nullable: false),
                        Alterasenha = c.Boolean(nullable: false),
                        Dataexpirar = c.DateTime(nullable: false),
                        Ultimoupdate = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Grupo_ID = c.Int(),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Grupos", t => t.Grupo_ID)
                .Index(t => t.Grupo_ID);
            
            CreateTable(
                "dbo.LogFiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 4000),
                        dataLeitura = c.DateTime(nullable: false),
                        tamanho = c.Long(nullable: false),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SenstarEvents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Central = c.Int(nullable: false),
                        Zona = c.Int(nullable: false),
                        Lado = c.String(maxLength: 1),
                        Distancia = c.Int(nullable: false),
                        Tratado = c.Boolean(nullable: false),
                        Nota = c.String(maxLength: 4000),
                        GlobalID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Grupo_ID", "dbo.Grupos");
            DropForeignKey("dbo.Grupos", "Permisssao_ID", "dbo.Permissoes");
            DropForeignKey("dbo.Zonas", "Central_ID", "dbo.Centrais");
            DropIndex("dbo.Usuarios", new[] { "Grupo_ID" });
            DropIndex("dbo.Grupos", new[] { "Permisssao_ID" });
            DropIndex("dbo.Zonas", new[] { "Central_ID" });
            DropTable("dbo.SenstarEvents");
            DropTable("dbo.LogFiles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Permissoes");
            DropTable("dbo.Grupos");
            DropTable("dbo.Configuracoes");
            DropTable("dbo.Zonas");
            DropTable("dbo.Centrais");
        }
    }
}
