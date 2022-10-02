using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC4
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* 巢狀 */
            int i_Age = 51;
            int i_Sex = 3;
            if  (i_Sex == 1)
            {
                if (i_Age < 50)
                {
                    /*年輕男人的程式執行程式碼區域*/
                    Response.Write("年輕男人");
                }
                else if (i_Age >= 50)
                {
                    /*壯年男人的程式執行程式碼區域*/
                    Response.Write("壯年男人");
                }
                
            }
            else if (i_Sex == 0)
            {
                if (i_Age < 50)
                {
                    /*年輕女人的程式執行程式碼區域*/
                    Response.Write("年輕女人");
                }
                else if (i_Age >= 50)
                {
                    /*壯年女人的程式執行程式碼區域*/
                    Response.Write("壯年女人");
                }
            }
            else /* 上方需改寫為以i_Sex為首要判斷，此行才會執行 */
            {
                /*其他*/
                Response.Write("二次元");
            }

        }
    }
}