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
    public class ConfigController : IConfigController
    {
        private IRepository<ConfigSys> configRepository { get; set; }
        private string erro = "NadaCF";

        public ConfigController()
        {
            configRepository = new RepositoryFactory<ConfigSys>().CriarRepositorio();
        }
        public ConfigSys ListConfig()
        {
            try
            {
                erro = "Chegou ListConfig";
                return configRepository.GetAll().FirstOrDefault();
                erro = "Passou configRepository";
            }
            catch (Exception ex)
            {
                throw new Exception(erro + ex.Message);
            }

        }

        public ConfigSys SaveConfig(ConfigSys target)
        {
            Valida(target);
            return configRepository.Save(target);
        }

        private bool Valida(ConfigSys target)
        {
            bool retorno = true;

            try
            {
                if (target == null)
                {
                    throw new ConfigNaoLocalizada();
                }

                if (String.IsNullOrEmpty(target.CaminhoLogs))
                {
                    throw new ConfigSemCaminhoLog();
                }

                if (target.SalvarDepoisdeLer && String.IsNullOrEmpty(target.CaminhoLogsSalvos))
                {
                    throw new ConfigSemCaminhoSalvaLog();
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
