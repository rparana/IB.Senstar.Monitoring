//22/02/2017
//  Criado a função findZonebyID

using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model;
using System.IO;
using IB.SM.Model.Entities;
using System.Collections;
using System.Windows.Forms;
using IB.SM.Data.Context;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Factory;
using IB.SM.Exceptions;

namespace IB.SM.Business
{
    public class EventsController : IEventsController
    {
        private string _path;

        private IRepository<SenstarEvents> seRepository { get; set; }
        private IRepository<Zone> znRepository { get; set; }
        private IRepository<Central> ceRepository { get; set; }
        private IRepository<LogFile> logRepository { get; set; }

        private DataContext db = new DataContext();

        public EventsController()
        {
            seRepository = new RepositoryFactory<SenstarEvents>().CriarRepositorio();
            znRepository = new RepositoryFactory<Zone>().CriarRepositorio();
            ceRepository = new RepositoryFactory<Central>().CriarRepositorio();
            logRepository = new RepositoryFactory<LogFile>().CriarRepositorio();
        }

        public bool alreadyread(string filename, long filesize)
        {
            bool retorno = false;

            var query = from f in db.LogFiles select f;
            query = query.Where(f => f.nome == filename && f.tamanho == filesize);
            if (query.Count() > 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public LogFile recordFileRead(string filename, long filesize)
        {
            LogFile retorno = new LogFile();

            //retorno = (from f in db.LogFiles where f.nome==filename select f).FirstOrDefault<LogFile>();
            retorno = logRepository.Query(f => f.nome == filename).FirstOrDefault();

            if (retorno != null)
            {
                retorno.tamanho = filesize;
                retorno.dataLeitura = DateTime.Now;
            }
            else
            {
                retorno = new LogFile();
                retorno.nome = filename;
                retorno.tamanho = filesize;
                retorno.dataLeitura = DateTime.Now;
            }

            logRepository.Save(retorno);

            return retorno;
        }

        public FileInfo[] listFiles()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            _path = (System.IO.Path.GetDirectoryName(executable));
            return listFiles(_path);
        }

        public FileInfo[] listFiles(string path)
        {
            DirectoryInfo Dir = new DirectoryInfo(path);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] retorno = Dir.GetFiles("EvAD*.txt", SearchOption.AllDirectories);
            return retorno;
        }

        public List<SenstarEvents> readRecordLogs(string file)
        {
            return readRecordLogs(file, false);
        }

        public List<SenstarEvents> readRecordLogs(string file, bool record)
        {
            return readRecordLogs(file, record, false, String.Empty);
        }

        public List<SenstarEvents> readRecordLogs(string file, bool record, bool moveAfterRead, string pathToMove)
        {
            return readRecordLogs(file, record, moveAfterRead, pathToMove, null);
        }

        public List<SenstarEvents> readRecordLogs(string file, bool record, bool moveAfterRead, string pathToMove, ProgressBar progress)
        {
            List<SenstarEvents> retorno = new List<SenstarEvents>();

            bool newFileAlreadyExist = false;
            string newFile = "";
            int iLine = 0;
            try
            {
                if (File.Exists(file)) //verifica se o arquivo informado existe.
                {

                    if (moveAfterRead)
                    {
                        if (!Directory.Exists(pathToMove))
                            Directory.CreateDirectory(pathToMove);
                        newFile = Path.GetFileName(file).Replace("EvAD", "IB");
                        newFile = Path.Combine(pathToMove, newFile);
                        newFileAlreadyExist = File.Exists(newFile);
                        File.Move(file, file.Replace(".txt", "_tmp.txt"));
                        file = file.Replace(file, file.Replace(".txt", "_tmp.txt"));
                    }

                    StreamReader objReader = new StreamReader(file);

                    //variavel de sequencia de caracteres em que cada linha do arquivo ser  armazenada … medida que o processamento for executado
                    string sLine = string.Empty;
                    DateTime dt;
                    SenstarEvents se = new SenstarEvents();


                    String[] substrings;
                    ArrayList arrText = new ArrayList();

                    if (progress != null)
                    {
                        progress.Value = 0;
                        string[] s = File.ReadAllLines(file);
                        progress.Maximum = s.Count();
                    }

                    while (sLine != null)
                    {
                        iLine++;
                        sLine = objReader.ReadLine();
                        if (sLine != null)
                        {

                            if (moveAfterRead)
                            {
                                if (newFileAlreadyExist)
                                {
                                    if (iLine > 2)
                                    {
                                        using (System.IO.StreamWriter wfile = new System.IO.StreamWriter(newFile, true))
                                        {
                                            wfile.WriteLine(sLine);
                                        }
                                    }
                                }
                                else
                                {
                                    using (System.IO.StreamWriter wfile = new System.IO.StreamWriter(newFile, true))
                                    {
                                        wfile.WriteLine(sLine);
                                    }
                                }
                            }

                            if (sLine.IndexOf("Sensor", 0, sLine.Length) > -1 && sLine.IndexOf("Alarm", 0, sLine.Length) > -1 && sLine.IndexOf("Side", 0, sLine.Length) > -1)
                            {
                                se = new SenstarEvents();
                                substrings = sLine.Split(("\t").ToCharArray());
                                dt = Convert.ToDateTime(substrings[0] + " " + substrings[1]);
                                se.Timestamp = dt;
                                se.Central = Convert.ToInt32(substrings[3]);
                                se.Zona = Convert.ToInt32(substrings[7].Replace("Zone ", ""));
                                se.Lado = substrings[9].Replace("Side ", "");
                                se.Distancia = Convert.ToInt32(substrings[10]);
                                if (record)
                                {
                                    //var query = (from s in db.SenstarEvents where s.Timestamp == se.Timestamp && s.Central == se.Central && s.Lado == se.Lado && s.Distancia == se.Distancia select s);
                                    SenstarEvents query = seRepository.Query(s => s.Timestamp == se.Timestamp && s.Central == se.Central && s.Lado == se.Lado && s.Distancia == se.Distancia).FirstOrDefault();
                                    if (query == null)
                                    {
                                        seRepository.Save(se);
                                    }
                                    else
                                    {
                                        se = query;
                                    }
                                }
                                retorno.Add(se);
                            }
                        }
                        if (progress != null)
                        {
                            progress.Value = iLine;
                            progress.Refresh();
                        }
                    }
                    objReader.Close();
                    if (moveAfterRead)
                        File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return retorno;
        }

        public IEnumerable<ViewEvents> ListTop(int top)
        {
            List<ViewEvents> retorno = new List<ViewEvents>();
            ViewEvents viewTemp = null;
            IEnumerable<SenstarEvents> temp = new List<SenstarEvents>();

            try
            {
                temp = seRepository.Query(q => q.Tratado != true).OrderByDescending(i => i.ID).Take(top);
                foreach (SenstarEvents s in temp)
                {
                    viewTemp = new ViewEvents
                    {
                        ID = s.ID,
                        Data_Hora = s.Timestamp,
                        Lado = s.Lado,
                        Distancia = s.Distancia.ToString()
                    };
                    Central c = ceRepository.Query(cn => cn.Endereco == s.Central).FirstOrDefault();
                    if (c != null)
                    {
                        viewTemp.Central = c.Nome;
                        Zone z = znRepository.Query(q => q.Central_ID == c.ID && q.NumeroZonaCentral == s.Zona && q.Lado == s.Lado && q.Inicio <= s.Distancia && q.Fim >= s.Distancia).FirstOrDefault();
                        if (z != null)
                        {
                            viewTemp.IDZona = z.ID;
                            viewTemp.Zona = z.Nome;
                            viewTemp.PoM = true;
                        }
                        else
                        {
                            viewTemp.Zona = "Zona na Central: " + s.Zona.ToString();
                        }
                    }
                    else
                    {
                        viewTemp.Central = "Endereço da central: " + s.Central;
                        viewTemp.Zona = "Zona na Central: " + s.Zona.ToString();
                    }
                    retorno.Add(viewTemp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return retorno;
        }

        public ViewEvents BuscaporID(int id)
        {
            ViewEvents retorno = new ViewEvents();

            SenstarEvents temp = new SenstarEvents();

            try
            {
                temp = seRepository.Query(q => q.ID == id).FirstOrDefault();
                if (temp != null)
                {
                    retorno = new ViewEvents
                    {
                        ID = temp.ID,
                        Data_Hora = temp.Timestamp,
                        Lado = temp.Lado,
                        Distancia = temp.Distancia.ToString()
                    };
                    Central c = ceRepository.Query(cn => cn.Endereco == temp.Central).FirstOrDefault();
                    if (c != null)
                    {
                        retorno.Central = c.Nome;
                        Zone z = znRepository.Query(q => q.Central_ID == c.ID && q.NumeroZonaCentral == temp.Zona && q.Lado == temp.Lado && q.Inicio <= temp.Distancia && q.Fim >= temp.Distancia).FirstOrDefault();
                        if (z != null)
                        {
                            retorno.IDZona = z.ID;
                            retorno.Zona = z.Nome;
                            retorno.PoM = true;
                        }
                        else
                        {
                            retorno.Zona = "Zona na Central: " + temp.Zona.ToString();
                        }
                    }
                    else
                    {
                        retorno.Central = "Endereço da central: " + temp.Central;
                        retorno.Zona = "Zona na Central: " + temp.Zona.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return retorno;
        }

        public void ReconheceEvento(int id, string nota)
        {
            SenstarEvents temp = new SenstarEvents();
            try
            {
                temp = seRepository.Query(q => q.ID == id).FirstOrDefault();
                if (String.IsNullOrEmpty(nota))
                {
                    throw new EventoNotadeReconhecimentoemBranco();
                }
                temp.Nota = nota;
                temp.Tratado = true;
                seRepository.Save(temp);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Zone> listZones()
        {
            try
            {
                return znRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public Zone findZonebyID(int id)
        {
            try
            {
                return znRepository.Query(q => q.ID == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<ReportViewer> GeraRelatorio(int tipo, DateTime dt_Ini, DateTime dt_Fim, List<Zone> zonas)
        {
            List<ReportViewer> retorno = new List<ReportViewer>();
            ReportViewer rv = new ReportViewer();
            IEnumerable<SenstarEvents> temp = new List<SenstarEvents>();
            string tipoRel = String.Empty;

            try
            {
                switch (tipo)
                {
                    case 0:
                    default:
                        tipoRel = "RELATÓRIO DE EVENTOS RECONHECIDOS";
                        foreach (Zone z in zonas)
                        {
                            temp = seRepository.Query(q => q.Tratado == true && q.Timestamp >= dt_Ini && q.Timestamp <= dt_Fim && q.Central == z.Central.Endereco && q.Distancia >= z.Inicio && q.Distancia <= z.Fim && q.Lado == z.Lado).OrderByDescending(i => i.Timestamp);
                            foreach (SenstarEvents se in temp)
                            {
                                rv = new ReportViewer
                                {
                                    Dt_Inicio = dt_Ini.ToString(),
                                    Dt_Fim = dt_Fim.ToString(),
                                    Zona = z.Nome,
                                    Central = z.Central.Nome,
                                    Data_Hora = se.Timestamp,
                                    Distancia = se.Distancia.ToString(),
                                    Lado = se.Lado,
                                    Nota = se.Nota,
                                    TipoRel = tipoRel
                                };
                                retorno.Add(rv);
                            }
                        }
                        break;
                    case 1:
                        tipoRel = "RELATÓRIO DE EVENTOS";
                        foreach (Zone z in zonas)
                        {
                            temp = seRepository.Query(q => q.Timestamp >= dt_Ini && q.Timestamp <= dt_Fim && q.Central == z.Central.Endereco && q.Distancia >= z.Inicio && q.Distancia <= z.Fim && q.Lado == z.Lado).OrderByDescending(i => i.Timestamp);
                            foreach (SenstarEvents se in temp)
                            {
                                rv = new ReportViewer
                                {
                                    Dt_Inicio = dt_Ini.ToString(),
                                    Dt_Fim = dt_Fim.ToString(),
                                    Zona = z.Nome,
                                    Central = z.Central.Nome,
                                    Data_Hora = se.Timestamp,
                                    Distancia = se.Distancia.ToString(),
                                    Lado = se.Lado,
                                    Nota = se.Nota,
                                    TipoRel = tipoRel
                                };
                                retorno.Add(rv);
                            }
                        }
                        break;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
