using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Calculator : System.Web.Services.WebService
{
    public Calculator () {}
    [WebMethod]
    public int Add(int a, int b){
        return a + b;
    }
    [WebMethod]
    public int Subtract(int a, int b){
        return a - b;
    }
    [WebMethod]
    public int Multiply(int a, int b){
        return a * b;
    }
    [WebMethod]
    public int Divide(int a, int b){
        return a / b;
    }

}
