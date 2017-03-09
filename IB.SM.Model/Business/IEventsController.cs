//22/02/2017
//  Criado a função findZonebyID

using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.Model.Business
{
    public interface IEventsController
    {
        FileInfo[] listFiles(); //Rotina para listagem de arquivos na pasta raiz do sistema
        FileInfo[] listFiles(string path); //Rotina para listagem de arquivos na pasta informada em path
        Boolean alreadyread(string filename, long filesize); //Rotina para verificação se o arquivo já foi lido.
        LogFile recordFileRead(string filename, long filesize); //Rotina para gravação dos dados do  arquivo lido.
        List<SenstarEvents> readRecordLogs(string file); //Rotina para somente ler os eventos no arquivo.
        List<SenstarEvents> readRecordLogs(string file, bool record); //Rotina para ler e gravar (se "record" = true), os logs do arquivo.
        List<SenstarEvents> readRecordLogs(string file, bool record, bool moveAfterRead, string pathToMove); //Rotina para ler e gravar (se "record" = true), os logs do arquivo e se devo mover o log apos a coleta.
        List<SenstarEvents> readRecordLogs(string file, bool record, bool moveAfterRead, string pathToMove, ProgressBar progress); //Rotina para ler e gravar (se "record" = true), os logs do arquivo e se devo mover o log apos a coleta.
        List<Zone> listZones();
        Zone findZonebyID(int id);
        IEnumerable<ViewEvents> ListTop(int top);
        ViewEvents BuscaporID(int id);
        void ReconheceEvento(int id, string nota);
        List<ReportViewer> GeraRelatorio(int tipo, DateTime dt_Ini, DateTime dt_Fim, List<Zone> zonas);
    }
}
