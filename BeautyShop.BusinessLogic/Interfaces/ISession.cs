using BeautyShop.Models.Enteties.General;
using BeautyShop.Models.Enteties.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ResponseMsg GetUserSession(USessionData udata);
        void GetTest1();
    }
}
