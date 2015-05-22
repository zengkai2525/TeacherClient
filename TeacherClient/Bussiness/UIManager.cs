using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using TeacherClient.Views;

namespace TeacherClient.Bussiness
{
    public class UIManager
    {
        #region 单例
        private static UIManager _instance;

        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UIManager();
                }
                return _instance;
            }
        } 
        #endregion

        #region UI
        public Canvas Container;
        private readonly TestMainView testMain = new TestMainView();
        private readonly TestingView testing = new TestingView();
        private readonly TestResultView testResult = new TestResultView();
        private readonly HistoryView history = new HistoryView();
        private readonly PopSaveWin popSave = new PopSaveWin();
        #endregion
        public void ShowUI(string uiName)
        {
            Container.Children.Clear();
            switch (uiName)
            {
                case "TestMainView":
                    Container.Children.Add(testMain);
                    break;
                case "TestingView":
                    Container.Children.Add(testing);
                    break;
                case "TestResultView":
                    Container.Children.Add(testResult);
                    break;
                case "HistoryView":
                    Container.Children.Add(history);
                    break;
            }
        }
    }
}
