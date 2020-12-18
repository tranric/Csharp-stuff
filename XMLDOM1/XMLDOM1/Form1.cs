using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace XMLDOM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("http://munro.humber.ca/~fielder/CPAN202-XML/recipes.xml");
            //XmlNodeList nodeList = doc.SelectNodes("book/recipe",);
            //foreach (XmlNode node in nodeList){
            //    txtBox.Text = (node.SelectSingleNode("preparation").InnerText);
            //    lblName.Text = (node.SelectSingleNode("title").InnerText);
            //}
    //  //  //  //  //  //  //
            XmlDocument XmlDoc = new XmlDocument();
            XmlNodeList objXmlNodeList;
            XmlDoc.Load("http://munro.humber.ca/~fielder/CPAN202-XML/recipes.xml");
            objXmlNodeList = XmlDoc.SelectNodes("//recipe");
            XmlNodeList wordNodes = objXmlNodeList[Convert.ToInt32(numUp.Value-1)].ChildNodes;
            foreach (XmlNode characterNode in wordNodes){
                lblName.Text = characterNode.SelectSingleNode("//title").InnerText;
                //txtBox.Text = characterNode.InnerText;
                txtBox.Text = characterNode.SelectSingleNode("//step").InnerText;

            }
    //  //  //  //  //  //  //

        }
    }
}
