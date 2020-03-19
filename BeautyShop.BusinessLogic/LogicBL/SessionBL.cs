using BeautyShop.BusinessLogic.Core;
using BeautyShop.BusinessLogic.Interfaces;
using BeautyShop.Models.Enteties.General;
using BeautyShop.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.BusinessLogic.LogicBL
{
    class SessionBL: UserApi, ISession
    {
        public ResponseMsg GetUserSession(USessionData udata)
        {
            return UserSession(udata);
        }
        public void GetTest1()
        {
            Test1();
        }
    }
}
