using BeautyShop.BusinessLogic.Core;
using BeautyShop.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop.BusinessLogic.LogicBL
{
    class MainBL: UserApi, IMain
    {
        public void GetTest1()
        {
            Test1();
        }
        public void GetTest2()
        {
            Test2();
        }
    }
}
