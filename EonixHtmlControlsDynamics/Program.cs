using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace EonixHtmlControlsDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            HtmlGenericControl createDiv = new HtmlGenericControl("DIV");
            createDiv.ID = "createDiv";
            createDiv.Style.Add(HtmlTextWriterStyle.BackgroundColor, "Grey");
            createDiv.Style.Add(HtmlTextWriterStyle.Color, "Red");
            createDiv.Style.Add(HtmlTextWriterStyle.Height, "250px");
            createDiv.Style.Add(HtmlTextWriterStyle.Width, "500px");
            createDiv.InnerHtml = "I'm a custom div";
            createDiv.TagName = "div";

            HtmlGenericControl ul = new HtmlGenericControl("ul");
            ul.Attributes.Add("style", "list-style-type:square;");




            HtmlGenericControl liLibel = new HtmlGenericControl("li");
            HtmlGenericControl spanCust = new HtmlGenericControl("span");

            spanCust.InnerHtml = "my custom column name";
            spanCust.Attributes.Add("Style", "background-color:#ddd;");
            liLibel.Attributes.Add("style", "background: #cce5ff;;width:150px;");
            liLibel.Controls.Add(spanCust);





            TextBox txtBox = new TextBox();
            txtBox.ID = "myCustomId";
            txtBox.Text = "my custom text into";
            txtBox.CssClass = "myCustomClassCss";

            HtmlGenericControl liTxtbox = new HtmlGenericControl("li");
            liTxtbox.Attributes.Add("style", "width:auto;");
            liTxtbox.Controls.Add(txtBox);





            ul.Controls.Add(liLibel);
            ul.Controls.Add(liTxtbox);

            createDiv.Controls.Add(ul);




            //Part2
            //Page page
            //var controlerFounder = FindDiv(MyPage,"createDiv");;
        }

        private HtmlGenericControl FindDiv(Page page, string customId)
        {
            var myCustomDiv = (HtmlGenericControl)page.FindControl(customId);
            return myCustomDiv;
        }
    }
}



/* <DIV id="createDiv">
 *      <ul>
 *          <liLibel>
 *              <span>
 *              </span>
 *          </liLibel>
 *          <liTxtBox>
 *              <input>
 *          </liTxtBox>
 *      <ul>
 * </div>
 */
