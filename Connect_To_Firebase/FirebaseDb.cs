using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Connect_To_Firebase
{
    public class FirebaseDb
    {
        public FirebaseDb(string baseURL)
        {
            this.RootNode = baseURL;
        }

        private string RootNode { get; set; }

        public FirebaseDb Node(string node)
        {
            if (node.Contains("/"))
            {
                throw new FormatException("Node không được chứa \'/\'");
            }
            return new FirebaseDb(this.RootNode + '/' + node);
        }

        public FirebaseDb NodePath(string nodePath)
        {
            return new FirebaseDb(this.RootNode + '/' + nodePath);
        }

        public FirebaseResponse Get()
        {
            return new FirebaseRequest(HttpMethod.Get, this.RootNode).Execute();
        }
        public FirebaseResponse Put(string jsonData)
        {
            return new FirebaseRequest(HttpMethod.Put, this.RootNode, jsonData).Execute();
        }

        /// <summary>  
        /// Make Post request  
        /// </summary>  
        /// <param name="jsonData">JSON string to POST</param>  
        /// <returns>Firebase Response</returns>  
        public FirebaseResponse Post(string jsonData)
        {
            return new FirebaseRequest(HttpMethod.Post, this.RootNode, jsonData).Execute();
        }

        /// <summary>  
        /// Make Patch request  
        /// </summary>  
        /// <param name="jsonData">JSON sting to PATCH</param>  
        /// <returns>Firebase Response</returns>  
        public FirebaseResponse Patch(string jsonData)
        {
            return new FirebaseRequest(new HttpMethod("PATCH"), this.RootNode, jsonData).Execute();
        }

        /// <summary>  
        /// Make Delete request  
        /// </summary>  
        /// <returns>Firebase Response</returns>  
        public FirebaseResponse Delete()
        {
            return new FirebaseRequest(HttpMethod.Delete, this.RootNode).Execute();
        }

        /// <summary>  
        /// To String  
        /// </summary>  
        /// <returns>Current resource URL as string</returns>  
        public override string ToString()
        {
            return this.RootNode;
        }
    }
}
