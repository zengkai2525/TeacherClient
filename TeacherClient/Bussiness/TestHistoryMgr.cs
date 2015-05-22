using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherClient.Bussiness
{
    public class TestHistoryMgr
    {
        #region 单例
        private static TestHistoryMgr _instance;

        public static TestHistoryMgr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TestHistoryMgr();
                }
                return _instance;
            }
        }
        #endregion
    }
}
