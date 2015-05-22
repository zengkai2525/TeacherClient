using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherClient.Models
{
    public class QuestionModel
    {

        public string guid { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string tag { get; set; }
        public string ext { get; set; }
        public string file_type { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string submit_date { get; set; }
        public string owner_tvmid { get; set; }
        public string packname { get; set; }

        public string answer { get; set; }
        public string question_type { get; set; }

        /*guid为试卷题目ID,也就是每一页资源的ID
        answer为正确答案
        question_type为试题类型:            
        "question_choice" "question_preview" "question_drawing" "question_typewriting"//四种类型。分别为选择，预览，圈化，键盘输入。
        question_choice, question_drawing,目前仅考虑这两种,前一种是需要学生选择ABCDE,学生在答案中设置text_answer完成回答.后一种是需要学生在该资源上进行圈           画，不计入统计中，学生通过在答案数据结构中，设置draw_*三个字段进行回答。*/

    }
}
