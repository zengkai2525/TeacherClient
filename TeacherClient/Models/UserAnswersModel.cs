using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherClient.Models
{
    public class UserAnswersModel
    {
        public string stay_time { get; set; }//所用时间，单位为秒
        public string guid { get; set; }//题目ID
        public string correct_percent { get; set; }//正确百分比
        public string complete_percent { get; set; }//完成百分比
        public string text_answer { get; set; }//文本答案,
        //与以下三个draw_*字段互斥
        public string draw_answer_guid { get; set; } //圈化题合成图Guid			 draw_answer_guid 圈化题答案key
        public string draw_answer_inkguid { get; set; }		 //笔迹guid
        public string draw_answer_origuid { get; set; }		 //原图guid
        public int type { get; set; }//	0选择题，1圈画题

    }
}
