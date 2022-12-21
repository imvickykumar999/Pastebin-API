var url = "https://pastebin.com/api/api_post.php";

var httpRequest = (HttpWebRequest)WebRequest.Create(url);
httpRequest.Method = "POST";

httpRequest.ContentType = "application/x-www-form-urlencoded";

var data = "api_dev_key=XXXXXXXXXXXXXXXXXXX&api_paste_code=import math;print(math.pi)&api_paste_name=GitHub&api_paste_private=0&api_paste_expire_date=1Y&api_option=paste";

using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
{
   streamWriter.Write(data);
}

var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
{
   var result = streamReader.ReadToEnd();
}

Console.WriteLine(httpResponse.StatusCode);
