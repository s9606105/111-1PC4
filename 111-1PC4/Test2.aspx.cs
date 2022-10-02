using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC4
{
    public partial class Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* 笛摩根 */
            int i_Age = 51;
            int i_Sex = 0;
            if (!(!(i_Age >= 50) || !(i_Sex == 1))) /* i_Age >= 50 && i_Sex == 1 */
            {
                /*壯年男人的程式執行程式碼區域*/
                Response.Write("壯年男人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 1))) /* i_Age < 50 && i_Sex == 1 */
            {
                /*年輕男人的程式執行程式碼區域*/
                Response.Write("年輕男人");
            }
            else if (!(!(i_Age >= 50) || !(i_Sex == 0))) /* i_Age >= 50 && i_Sex == 0 */
            {
                /*壯年女人的程式執行程式碼區域*/
                Response.Write("壯年女人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 0))) /* i_Age < 50 && i_Sex == 0 */
            {
                /*年輕女人的程式執行程式碼區域*/
                Response.Write("年輕女人");
            }
            else
            {
                /*其他*/
                Response.Write("二次元");
            }
        }
    }
}