using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Tables;


namespace DataAccessLayer
{
    public class Database
    {
        public userInfos Userinfotable { set; get; }
        public transportinfos Transportinfotable { set; get; }
        public hotelinfos Hotelinfotable { set; get; }


        public Database()
        {
            Userinfotable = new userInfos();
            Transportinfotable = new transportinfos();
            Hotelinfotable = new hotelinfos();
        }

    }
}
