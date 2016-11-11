using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://wsdiplomski.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
    public List<Model.Kategorija> getKategorije() 
    {
        return Biz.BAL.getKategorije();
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
    public List<Model.Post> getPosts(string nazivKategorije) 
    {
        return Biz.BAL.getPosts(nazivKategorije);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<Model.Kategorija> getKategorijeJson()
    {
        return Biz.BAL.getKategorije();
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<Model.Post> getPostsJson(string nazivKategorije)
    {
        return Biz.BAL.getPosts(nazivKategorije);
    }
}
