using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FunWithStringsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "Dustin Vandehey";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }

            string names= "Luke,Leia,Han,Chewbacca";
            string[] rebels = names.Split(',');
            string result = "";
            for (int i = rebels.Length-1; i >=0; i--)
            {
                result += rebels[i] +",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
            string[] rebels = names.Split(',');
            string result = "";
            for (int i = 0; i < rebels.Length; i++)
            {
                int padLeft = (14 - rebels[i].Length) / 2;
                string temp = rebels[i]. PadLeft(rebels[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br/>";
            }
            resultLabel.Text = result;

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            resultLabel.Text=puzzle;

        }
        


        protected void okButton_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}