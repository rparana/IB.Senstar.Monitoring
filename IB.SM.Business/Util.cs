using IB.SM.Data.Context;
using IB.SM.Data.Repositories;
using IB.SM;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using IB.SM.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Factory;
using IB.SM.Model.Data.Repositories.Base;
using System.IO;

namespace IB.SM.Business
{
    public class Util : IUtil
    {
        //private DataContext db = new DataContext();

        private IRepository<Central> cr { get; set; }
        private IRepository<Zone> zr { get; set; }
        private IRepository<Grupo> gr { get; set; }
        private IRepository<Usuario> ur { get; set; }
        private IRepository<ConfigSys> confr { get; set; }

        public bool firstConfig()
        {
            try
            {
                if (!databaseExist())
                    createDataBase();

                cr = new RepositoryFactory<Central>().CriarRepositorio();
                zr = new RepositoryFactory<Zone>().CriarRepositorio();
                gr = new RepositoryFactory<Grupo>().CriarRepositorio();
                ur = new RepositoryFactory<Usuario>().CriarRepositorio();
                confr = new RepositoryFactory<ConfigSys>().CriarRepositorio();

                bool retorno = false;

                CentralController cc = new CentralController();
                ZonesController zc = new ZonesController();
                GroupController gc = new GroupController();
                PermissionController pc = new PermissionController();
                UserController uc = new UserController();
                Grupo g = gc.DefaultGroup();


                g.Permissao = pc.DefaultPermission();

                Usuario u = uc.DefaultUser();

                List<Central> centrais = cc.DefaultCentrals();

                List<Zone> zonas = zc.DefaultZones();

                List<Central> cs = cr.GetAll().ToList();
                if (cs.Count() > 0)
                {
                    foreach (Central c in cs)
                    {
                        cr.Delete(c);
                    }
                }
                foreach (Central c in centrais)
                {
                    cr.Save(c);
                }

                List<Zone> zs = zr.GetAll().ToList();
                if (zs.Count() > 0)
                {
                    foreach (Zone z in zs)
                    {
                        zr.Delete(z);
                    }
                }
                foreach (Zone z in zonas)
                {
                    zr.Save(z);
                }

                List<Grupo> gs = gr.GetAll("Usuarios").ToList();
                if (gs.Count() > 0)
                {
                    foreach (Grupo g1 in gs)
                    {
                        List<Usuario> usersG = g1.Usuarios.ToList();
                        foreach (Usuario usr in usersG)
                        {
                            usr.Grupo_ID = null;
                            usr.Grupo = null;
                            ur.Save(usr);
                        }
                        g1.Usuarios = null;
                        gr.Delete(g1);
                    }
                }

                gr.Save(g, true);


                Usuario u2 = ur.Query(n => n.Login == "Admin").FirstOrDefault();
                if (u2 != null)
                {
                    ur.Delete(u2);
                }
                u.Senha = encrypt("IBtech@844");
                u.Grupo_ID = g.ID;
                ur.Save(u, true);

                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (Path.GetDirectoryName(executable));

                ConfigSys conf = new ConfigSys {
                    CaminhoLogs = Path.Combine(path, "logs"),
                    CaminhoLogsSalvos = Path.Combine(path, "logs\\Bkp"),
                    SalvarDepoisdeLer = true
                };

                confr.Save(conf);
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("UtilController" + ex.Message);
            }

        }

        public bool readyStart()
        {
            throw new NotImplementedException();
        }

        public bool databaseExist()
        {
            using (var db = new DataContext())
            {
                return db.Database.Exists();
            }
        }

        public void createDataBase()
        {
            using (var db = new DataContext())
            {
                db.Database.CreateIfNotExists();
            }
        }

        #region Função para Criptografar a Senha

        /// <summary>
        /// sha512encrypt - Criptografa a senha de forma que não possa ser descriptografada.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA512Managed sha512hasher = new SHA512Managed();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }

        static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }

        #endregion

    }
}
