using IB.SM.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IB.SM.Model.Entities;

namespace IB.SM.Business
{
    public class PermissionController : IPermissionController
    {
        public Permissao DefaultPermission()
        {
            return new Permissao
            {
                AcknowledgeEvents = true,
                AlarmViewAccess = true,
                ClearEvents = true,
                CreateCentral = true,
                CreateGroup = true,
                CreateMaps = true,
                CreateUser = true,
                CreateZone = true,
                DeleteCentral = true,
                DeleteGroup = true,
                DeleteMaps = true,
                DeleteUser = true,
                DeleteZone = true,
                FindCentral = true,
                FindGroup = true,
                FindMaps = true,
                FindUser = true,
                FindZone = true,
                ImportEvents = true,
                SilenceEvents = true,
                SystemADMAccess = true,
                SystemConfig = true,
                UpdateCentral = true,
                UpdateGroup = true,
                UpdateMaps = true,
                UpdateUser = true,
                UpdateZone = true,
            };
        }
    }
}
