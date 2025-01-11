using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> logicLayerPersonelLst()
        {
            return DALPersonel.PersonelList();
        }
        public static int logicLayerAddPersonel(EntityPersonel entityPersonel)
        {
            if(entityPersonel.Ad!="" && entityPersonel.Soyad !="" && entityPersonel.Ad.Length>=3 && entityPersonel.Maas > 2900)
            {
                return DALPersonel.AddPersonel(entityPersonel);
            }
            else
            {
                return -1;
            }
        }
        
        public static bool logicLayerRemovePersonel(int personel)
        {
            if (personel>0)
            {
                return DALPersonel.RemovePersonel(personel);
            }
            else
            {
                return false;
            }
        }
    }
}