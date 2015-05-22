using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace TeacherClient.Styles.CustomControl
{
    public class ImageButton : Button
    {
        /// <summary>
        /// 
        /// </summary>
        public string ImageNomarl { get; set; }
        /// <summary>
        /// 鼠标划过
        /// </summary>
        public string ImageOver { get; set; }
        /// <summary>
        /// 鼠标按下
        /// </summary>
        public string ImageDown { get; set; }
        /// <summary>
        /// 图片高
        /// </summary>
        public int ImageHeight { get; set; }
        /// <summary>
        /// 图片宽
        /// </summary>
        public int ImageWidth { get; set; }

    }
}
