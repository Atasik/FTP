using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace Client
{
    static class ClientManager
    {
        static string url;
        static User user;
        static string responseFromServer;

        public static void Authorization(User _user)
        {
            user = _user;
            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection
            {
                ["user_name"] = user.GetName(),
                ["user_password"] = user.GetPassword()
            };

            UploadValues(webClient, formData);
            webClient.Dispose();
        }

        public static void DownloadFile(string downloadPath, string fileName)
        {
            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection
            {
                ["download_path"] = downloadPath,
                ["user_name"] = user.GetName(),
                ["user_password"] = user.GetPassword(),
                ["file_name"] = fileName
            };

            UploadValues(webClient, formData);
            webClient.Dispose();
        }

        public static void UploadFile(string uploadPath, string fileName)
        {
            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection
            {
                ["user_name"] = user.GetName(),
                ["user_password"] = user.GetPassword(),
                ["upload_path"] = uploadPath,
                ["file_name"] = fileName
            };

            UploadValues(webClient, formData);
            webClient.Dispose();
        }

        static void UploadValues(WebClient webClient, NameValueCollection formData)
        {
            byte[] responseBytes = webClient.UploadValues(url, "POST", formData);
            responseFromServer = Encoding.UTF8.GetString(responseBytes);
            System.Console.WriteLine(responseFromServer);
        }

        public static string GetResponse()
        {
            return responseFromServer;
        }

        public static void SetURL(string _url)
        {
            url = _url;
        }
    }
}
