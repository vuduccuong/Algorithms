using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Connect_To_Firebase
{
    class Program
    {
         static void Main(string[] args)
        {
            ConnectToFB();
            
            #region CRUD fireBase
            //FirebaseDb firebaseDB = new FirebaseDb("https://test-281c3.firebaseio.com");

            //FirebaseDb firebaseDBTeams = firebaseDB.Node("Teams");

            //var data = @"{  
            //                'Team-Awesome': {  
            //                    'Members': {  
            //                        'M1': {  
            //                            'City': 'Hà Nội',  
            //                            'Name': 'Cường VD'  
            //                            },  
            //                        'M2': {  
            //                            'City': 'Ninh Bình',  
            //                            'Name': 'cuongvd'  
            //                            },  
            //                        'M3': {  
            //                            'City': 'Test',  
            //                            'Name': 'data'  
            //                            }  
            //                       }  
            //                   }  
            //              }";
            //Console.WriteLine("GET Request");
            //FirebaseResponse getResponse = firebaseDBTeams.Get();
            //Console.WriteLine(getResponse.Success);
            //if (getResponse.Success)
            //    Console.WriteLine(getResponse.JSONContent);
            //Console.WriteLine();

            //Console.WriteLine("PUT Request");
            //FirebaseResponse putResponse = firebaseDBTeams.Put(data);
            //Console.WriteLine(putResponse.Success);
            //Console.WriteLine();

            //Console.WriteLine("POST Request");
            //FirebaseResponse postResponse = firebaseDBTeams.Post(data);
            //Console.WriteLine(postResponse.Success);
            //Console.WriteLine();

            ////Console.WriteLine("PATCH Request");
            ////FirebaseResponse patchResponse = firebaseDBTeams
            ////    // Use of NodePath to refer path lnager than a single Node  
            ////    .NodePath("Team-Awesome/Members/M1")
            ////    .Patch("{\"Designation\":\"CRM Consultant\"}");
            ////Console.WriteLine(patchResponse.Success);
            ////Console.WriteLine();

            ////Console.WriteLine("DELETE Request");
            ////FirebaseResponse deleteResponse = firebaseDBTeams.Delete();
            ////Console.WriteLine(deleteResponse.Success);
            ////Console.WriteLine();

            //Console.WriteLine(firebaseDBTeams.ToString());
            //Console.ReadLine();
            #endregion
        }

        public static async void ConnectToFB()
        {
            #region Using FireSharp
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "1JJsr4n4BG0M3SG7bNNLxDXITGak6GWR9LFaPZmQ",
                BasePath = "https://test-281c3.firebaseio.com/",
            };

            IFirebaseClient client = new FirebaseClient(config);

            FirebaseResponse response = await client.GetAsync("Teams/Team-Awesome");
            Todo todo = response.ResultAs<Todo>();
            Console.WriteLine(todo);
            #endregion


        }
    }
}
