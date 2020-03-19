using BeautyShop.BusinessLogic.Interfaces;
using BeautyShop.BusinessLogic.LogicBL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.BusinessLogic
{
   public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public IMain GetMainBL()
        {
            return new MainBL();
        }
    }
}
