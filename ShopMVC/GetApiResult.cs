using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ShopMVC
{
    public class GetApiResult
    {
        #region 封装WebAPI
        /// <summary>
        /// 封装WebAPI的方法
        /// </summary>
        /// <param name="verbs">请求的动作名称</param>
        /// <param name="actionName">请求的API方法名称</param>
        /// <param name="uri">要请求的方法的路径地址</param>
        /// <param name="obj">添加或者修改需要传入的参数</param>
        /// <returns>返回json字符串</returns>
        public static string Use(string verbs, string actionName, string uri, object obj = null)
        {
            Task<HttpResponseMessage> task = null;
            string json = "";
            //创建一个Http客户端对象
            HttpClient client = new HttpClient()
            {
                //指定访问WebAPI的URI地址
                BaseAddress = new Uri(uri)
            };
            //根据不同的动作执行不同的方法
            switch (verbs)
            {
                case "get":
                    task = client.GetAsync(actionName);
                    break;
                case "post":
                    task = client.PostAsJsonAsync(actionName, obj);
                    break;
                case "put":
                    task = client.PutAsJsonAsync(actionName, obj);
                    break;
                case "delete":
                    task = client.DeleteAsync(actionName);
                    break;
                default:
                    break;
            }
            //等待请求的过程
            task.Wait();
            //接收响应的结果
            var response = task.Result;
            //判断响应的状态码是成功的时候
            if (response.IsSuccessStatusCode)
            {
                //从响应对象的内容中读取字符串
                var read = response.Content.ReadAsStringAsync();
                //等待读取的过程
                read.Wait();
                //接收读取的结果
                json = read.Result;
            }
            return json;
        }
        #endregion
    }
}