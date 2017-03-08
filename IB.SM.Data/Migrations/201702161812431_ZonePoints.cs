namespace IB.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZonePoints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zonas", "x1", c => c.Single(nullable: false));
            AddColumn("dbo.Zonas", "y1", c => c.Single(nullable: false));
            AddColumn("dbo.Zonas", "x2", c => c.Single(nullable: false));
            AddColumn("dbo.Zonas", "y2", c => c.Single(nullable: false));

            Sql("Update dbo.Zonas set Nome='Z009A - MURO PERIMETRO DIR.', x1=748, y1=183, x2=799, y2=201 Where Nome Like 'Z009%'");
            Sql("Update dbo.Zonas set Nome='Z010A - FUNDOS LOTE 04', x1=646, y1=188, x2=728, y2=174 Where Nome Like 'Z010%'");
            Sql("Update dbo.Zonas set Nome='Z011A - FUNDOS LOTE 03', x1=572, y1=207, x2=617, y2=194 Where Nome Like 'Z011%'");
            Sql("Update dbo.Zonas set x1=500, y1=231, x2=572, y2=207 Where Nome Like 'Z012%'");
            Sql("Update dbo.Zonas set Nome='Z013A - FUNDOS LOTE 01', x1=431, y1=252, x2=460, y2=250 Where Nome Like 'Z013%'");
            Sql("Update dbo.Zonas set Nome='Z014A - LATERAL ESQ. LOTE 01', x1=423, y1=458, x2=431, y2=252 Where Nome Like 'Z014%'");
            Sql("Update dbo.Zonas set x1=420, y1=492, x2=309, y2=501 Where Nome Like 'Z015%'");
            Sql("Update dbo.Zonas set x1=309, y1=501, x2=151, y2=516 Where Nome Like 'Z016%'");
            Sql("Update dbo.Zonas set x1=151, y1=516, x2=77, y2=735 Where Nome Like 'Z017%'");
            Sql("Update dbo.Zonas set nome='Z018B - FUNDOS LOTE 17', x1=62, y1=779, x2=158, y2=863 Where Nome Like 'Z018%'");
            Sql("Update dbo.Zonas set x1=157, y1=862, x2=263, y2=955 Where Nome Like 'Z019%'");
            Sql("Update dbo.Zonas set x1=356, y1=1035, x2=262, y2=954 Where Nome Like 'Z020%'");
            Sql("Update dbo.Zonas set x1=445, y1=1112, x2=354, y2=1033 Where Nome Like 'Z021%'");
            Sql("Update dbo.Zonas set x1=561, y1=1213, x2=445, y2=1112 Where Nome Like 'Z022%'");
            Sql("Update dbo.Zonas set x1=644, y1=1287, x2=561, y2=1213 Where Nome Like 'Z023%'");
            Sql("Update dbo.Zonas set nome='Z024C - FUNDOS LOTE 22', x1=686, y1=1243, x2=643, y2=1286 Where Nome Like 'Z024%'");
            Sql("Update dbo.Zonas set x1=638, y1=986, x2=798, y2=1193 Where Nome Like 'Z025%'");

            Sql("Update dbo.Zonas set x1=1216, y1=158, x2=1233, y2=61 Where Nome Like 'Z129%'");
            Sql("Update dbo.Zonas set nome='Z130C - LATERAL DIR. LOTE 08', x1=1194, y1=294, x2=1216, y2=158 Where Nome Like 'Z130%'");
            Sql("Update dbo.Zonas set x1=1462, y1=392, x2=1203, y2=417 Where Nome Like 'Z131%'");
            Sql("Update dbo.Zonas set x1=1641, y1=376, x2=1462, y2=392 Where Nome Like 'Z132%'");
            Sql("Update dbo.Zonas set x1=1622, y1=479, x2=1641, y2=376 Where Nome Like 'Z133%'");
            Sql("Update dbo.Zonas set x1=1551, y1=485, x2=1622, y2=479 Where Nome Like 'Z134%'");
            Sql("Update dbo.Zonas set x1=1551, y1=485, x2=1471, y2=492 Where Nome Like 'Z135%'");
            Sql("Update dbo.Zonas set x1=1341, y1=504, x2=1206, y2=516 Where Nome Like 'Z136%'");
            Sql("Update dbo.Zonas set x1=1206, y1=516, x2=1190, y2=648 Where Nome Like 'Z137%'");
            Sql("Update dbo.Zonas set x1=1190, y1=648, x2=1096, y2=649 Where Nome Like 'Z138%'");
            Sql("Update dbo.Zonas set x1=1001, y1=651, x2=1096, y2=649 Where Nome Like 'Z139%'");
            Sql("Update dbo.Zonas set x1=908, y1=653, x2=1001, y2=651 Where Nome Like 'Z140%'");
            Sql("Update dbo.Zonas set x1=816, y1=656, x2=908, y2=653 Where Nome Like 'Z141%'");
            Sql("Update dbo.Zonas set x1=728, y1=658, x2=816, y2=656 Where Nome Like 'Z142%'");
            Sql("Update dbo.Zonas set x1=648, y1=661, x2=728, y2=658 Where Nome Like 'Z143%'");
            Sql("Update dbo.Zonas set x1=618, y1=662, x2=648, y2=661 Where Nome Like 'Z144%'");
            Sql("Update dbo.Zonas set x1=591, y1=925, x2=618, y2=662 Where Nome Like 'Z145%'");
            Sql("Update dbo.Zonas set x1=638, y1=986, x2=591, y2=925 Where Nome Like 'Z146%'");

            //Zona 9
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z009B - MURO PERIMETRO DIR.', 26, 2, 'A', 0, 0, GETDATE(), NEWID(), 799, 201, 913, 186)");
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z009C - MURO PERIMETRO DIR.', 27, 2, 'A', 0, 0, GETDATE(), NEWID(), 913, 186, 1041, 152)");
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z009D - MURO PERIMETRO DIR.', 28, 2, 'A', 0, 0, GETDATE(), NEWID(), 1041, 152, 1143, 111)");

            //Zona 10
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z010B - FUNDOS LOTE 04', 29, 2, 'A', 0, 0, GETDATE(), NEWID(), 727, 174, 748, 183)");

            //Zona 11
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z011B - FUNDOS LOTE 03', 30, 2, 'A', 0, 0, GETDATE(), NEWID(), 617, 194, 646, 188)");

            //Zona 13
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z013B - FUNDOS LOTE 01', 31, 2, 'A', 0, 0, GETDATE(), NEWID(), 460, 250, 500, 231)");

            //Zona 14B antiga Zona 15
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z014B - LATERAL ESQ. LOTE 01', 32, 2, 'B', 0, 0, GETDATE(), NEWID(), 423, 458, 420, 492)");

            //Zona 18
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z018B - FUNDOS LOTE 17', 33, 2, 'B', 0, 0, GETDATE(), NEWID(), 77, 735, 62, 779)");

            //Zona 24
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z024B - FUNDOS LOTE 22', 34, 1, 'A', 0, 0, GETDATE(), NEWID(), 736, 1215, 685, 1244)");
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z024A - FUNDOS LOTE 22', 35, 1, 'A', 0, 0, GETDATE(), NEWID(), 798, 1193, 736, 1215)");

            //Zona 130
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z130B - LATERAL DIR. LOTE 08', 36, 3, 'B', 0, 0, GETDATE(), NEWID(), 1200, 293, 1194, 294)");
            Sql("INSERT INTO dbo.Zonas (Nome, NumeroZona, NumeroZonaCentral, Lado, Inicio, Fim, Ultimoupdate, GlobalID, x1, y1, x2, y2) VALUES ('Z130A - LATERAL DIR. LOTE 08', 37, 3, 'B', 0, 0, GETDATE(), NEWID(), 1203, 417, 1200, 293)");

        }

        public override void Down()
        {
            DropColumn("dbo.Zonas", "y2");
            DropColumn("dbo.Zonas", "x2");
            DropColumn("dbo.Zonas", "y1");
            DropColumn("dbo.Zonas", "x1");
        }
    }
}
