using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model.Entities;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Factory;
using IB.SM.Exceptions;

namespace IB.SM.Business
{
    public class ZonesController : IZonesController
    {
        private IRepository<Zone> zoneRepository { get; set; }
        private string[] includeCentral = { "Central" };

        public ZonesController()
        {
            zoneRepository = new RepositoryFactory<Zone>().CriarRepositorio();
        }

        public Zone BuscaporNome(string nome)
        {
            return BuscaporNome(nome, false);
        }

        public Zone BuscaporNome(string nome, bool carregaCentral)
        {
            List<string> include = new List<string>();
            if (carregaCentral)
                include.Add(includeCentral.FirstOrDefault());
            return zoneRepository.Query(u => u.Nome == nome, includeCentral.ToArray()).FirstOrDefault();
        }

        public Zone BuscaporNumeroZona(int num)
        {
            return BuscaporNumeroZona(num, false);
        }

        public Zone BuscaporNumeroZona(int num, bool carregaCentral)
        {
            List<string> include = new List<string>();
            if (carregaCentral)
                include.Add(includeCentral.FirstOrDefault());
            return zoneRepository.Query(u => u.NumeroZona == num, includeCentral.ToArray()).FirstOrDefault();
        }

        public Zone BuscaporNumeroZonaCentral(int num)
        {
            return BuscaporNumeroZonaCentral(num, false);
        }

        public Zone BuscaporNumeroZonaCentral(int num, bool carregaCentral)
        {
            List<string> include = new List<string>();
            if (carregaCentral)
                include.Add(includeCentral.FirstOrDefault());
            return zoneRepository.Query(u => u.NumeroZonaCentral == num, includeCentral.ToArray()).FirstOrDefault();
        }

        public Zone BuscarporID(int ID)
        {
            return BuscarporID(ID, false);
        }

        public Zone BuscarporID(int ID, bool carregaCentral)
        {
            List<string> include = new List<string>();
            if (carregaCentral)
                include.Add(includeCentral.FirstOrDefault());
            return zoneRepository.Query(u => u.ID == ID, includeCentral.ToArray()).FirstOrDefault();
        }

        public List<Zone> DefaultZones()
        {
            List<Zone> retorno = new List<Zone>
                {
                    new Zone { Nome="Z009 - MURO PERIMETRO DIR.", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z010 - FUNDOS LOTE 04", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z011 - FUNDOS LOTE 03", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z012 - FUNDOS LOTE 02", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z013 - FUNDOS LOTE 01", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z014 - LATERAL ESQ. LOTE 01", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z015 - MURO PERIMETRAL PONTE", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z016 - LATERAL DIREITA LOTE 16", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z017 - FUNDOS LOTE 16", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z018 - FUNDOS LOTE 17", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z019 - FUNDOS LOTE 18", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z020 - FUNDOS LOTE 19", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z021 - FUNDOS LOTE 20", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z022 - FUNDOS LOTE 21", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z023 - LATERAL DIR. LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z024 - FUNDOS LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z025 - LATERAL ESQ. LOTE 22", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z129 - LATERAL PORTARIA", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z130 - LATERAL DIR. LOTE 08", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z131 - LATERAL ESQ. AREA LAZER", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z132 - LATERAL ESQ. QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z133 - FUNDOS QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z134 - LATERAL DIR. QUADRA FUTEBOL", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z135 - FUNDOS SALÃO DE FESTAS", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z136 - LATERAL QUADRA TENIS", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z137 - LATERAL ESQ. LOTE 09", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z138 - FUNDOS LOTE 09", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z139 - FUNDOS LOTE 10", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z140 - FUNDOS LOTE 11", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z141 - FUNDOS LOTE 12", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z142 - FUNDOS LOTE 13", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z143 - FUNDOS LOTE 14", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z144 - FUNDOS LOTE 15", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z145 - MURO PERIMETRAL LAGO", Lado = "A", Ultimoupdate=DateTime.Now },
			        new Zone { Nome="Z146 - MURO FRENTE LOTE 21", Lado = "A", Ultimoupdate=DateTime.Now },
			    };

            return retorno;
        }

        public void Excluir(Zone target)
        {
            try
            {
                if (target == null)
                {
                    throw new ZonaNaoLocalizada();
                }

                zoneRepository.Delete(target);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public IEnumerable<Zone> ListarTodos()
        {
            return ListarTodos(false);
        }

        public IEnumerable<Zone> ListarTodos(bool carregaCentral)
        {
            List<string> include = new List<string>();
            if (carregaCentral)
                include.Add(includeCentral.FirstOrDefault());
            return zoneRepository.GetAll(include.ToArray());
        }

        public Zone Salvar(Zone target)
        {
            return Salvar(target, false);
        }

        public Zone Salvar(Zone target, bool saveNestedProperties)
        {
            try
            {
                Valida(target);
                return this.zoneRepository.Save(target, saveNestedProperties);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private bool Valida(Zone target)
        {
            bool retorno = true;

            try
            {
                if (target == null)
                {
                    throw new ZonaNaoLocalizada();
                }

                if (String.IsNullOrEmpty(target.Nome))
                {
                    throw new ZonasemNome();
                }

                if (target.NumeroZona == 0)
                {
                    throw new ZonasemNumero();
                }

                Zone c = zoneRepository.Query(q => q.Nome.ToUpper().Equals(target.Nome.ToUpper())).FirstOrDefault();
                if (c != null)
                {
                    if (c.ID != target.ID)
                    {
                        throw new ZonaNomeRepetido();
                    }
                }

                c = zoneRepository.Query(q => q.NumeroZona == target.NumeroZona).FirstOrDefault();
                if (c != null)
                {
                    if (c.ID != target.ID)
                    {
                        throw new ZonaNumeroRepetido();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return retorno;
        }
    }
}
