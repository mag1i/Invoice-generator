using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using static Google.Apis.Drive.v3.DriveService;

namespace Invoice_generator
{
    class Class1
    {
        private static DriveService GetService()
        {
            var tokenResponse = new TokenResponse
            {
                AccessToken = "ya29.A0AVA9y1v4ekt6DmIJ9bKwlinoAumYVcV5A53ewY31-yvucfg4jqNChjROf5uslrk9HIfNAKgBwchH7Ipyucuo2EiosaDgtNwKuAQjLBktLVbSs4d3kHL3hL1IVNgT8d61X4Q8kyYoHSP1ZPR7xSE5mF3KTzhlaCgYKATASATASFQE65dr86ygnjqAPye-kqybM4-kj-w0163",
                RefreshToken = "1//04trtrOtxo0GKCgYIARAAGAQSNwF-L9IrBqFRn-lLoA930hWHsWiPFIdzoH2WAQnvYrsh6MLG2psJ0JMeg8f-Yj1KtHi4HXTxTis",
            };


            var applicationName = "My First Project"; // Use the name of the project in Google Cloud
            var username = "bechmanel@gmail.com"; // Use your email


            var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = "441051712155-8pmu9h6e0532dt6t2j60bq8h1rv9fop8.apps.googleusercontent.com",
                    ClientSecret = "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"
                },
                Scopes = new[] { Scope.Drive },
                DataStore = new FileDataStore(applicationName)
            });


    UserCredential credential = new UserCredential(apiCodeFlow, username, tokenResponse);


    var service = new DriveService(new BaseClientService.Initializer
    {
        HttpClientInitializer = credential,
        ApplicationName = applicationName
    });
    return service;
        }
        private static bool Exists(string name)
        {
            DriveService service = GetService();
            var listRequest = service.Files.List();
            listRequest.PageSize = 100;
            listRequest.Q = $"trashed = false and name contains '{name}' and 'root' in parents";
            listRequest.Fields = "files(name)";
            try
            {
                var files = listRequest.Execute().Files;
            

            foreach (var file in files)
            {
                if (name == file.Name)
                    return true;
            }
            }
            catch
            {
                MessageBox.Show("No internet");
            }
            return false;
        }



        public string CreateFolder(string parent, string folderName)
       // public string CreateFolder(string folderName)
        {
            DriveService service = GetService();
            bool exists = Exists(folderName);
            try
            {
                if (!exists)
                {
                    FilesResource.ListRequest listRequest = service.Files.List();
                    listRequest.PageSize = 10;
                    listRequest.Q = "mimeType = 'application/vnd.google-apps.folder' and name = '" + folderName + "'";
                    listRequest.Fields = "nextPageToken, files(id, name)";

               
                    IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
                    string s = "";

                    foreach (var file in files)
                    {   //My TextBlock(WPF)
                        s = $"{file.Id}";
                    }

                    return s;
                }



                else
                {

                    var driveFolder = new Google.Apis.Drive.v3.Data.File();
                    driveFolder.Name = folderName;
                    driveFolder.MimeType = "application/vnd.google-apps.folder";

                    driveFolder.Parents = new string[] { parent };
                    var command = service.Files.Create(driveFolder);
                    var file = command.Execute();

                    return file.Id;
                } }
                catch
                {
                    return " ";

                }
            }
        public string getnm( string fileid)
        // public string CreateFolder(string folderName)
        {
            DriveService service = GetService();
          /*  var fileListRequest = service.Files.List();
            fileListRequest.Q = "mimeType = 'application/vnd.google-apps.folder' and name contains '8-22'";
            var fileListResponse = fileListRequest.Execute();
            var filesInParent = service.Files.List();
            filesInParent.Q = $"parents in {fileListResponse.Files.FirstOrDefault().Id}";
            var allFilesInParentResponse = filesInParent.Execute();*/

         FilesResource.ListRequest listRequest = service.Files.List();
        listRequest.PageSize = 10;
        listRequest.Q = "mimeType = 'application/vnd.google-apps.folder' and name = '"+DateTime.Today.Month.ToString()+"-"+DateTime.Today.Year.ToString()+"'";
        listRequest.Fields = "nextPageToken, files(id, name)";

        IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
        .Files;
            string s = "";
       
            foreach (var file in files)
            {   //My TextBlock(WPF)
                s = $"{file.Id}"; 
            }
        
            return s;




        }



        public string UploadFile(Stream file, string fileName, string fileMime, string fileDescription)
        {
            DriveService service = GetService();
 

    var driveFile = new Google.Apis.Drive.v3.Data.File();
            driveFile.Name = fileName;
            driveFile.Description = fileDescription;
            driveFile.MimeType = fileMime;
            driveFile.Parents = new string[] {  CreateFolder("1DTncbuT6v2DL_E_180mwPK2WIfU_9Pq1", DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString()) };
 

    var request = service.Files.Create(driveFile, file, fileMime);
            request.Fields = "id";

            var response = request.Upload();
            try
            {
                if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                {
                    throw response.Exception;


                    /*Form2 popup = new Form2();
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("You clicked OK");
                    }
                    else if (dialogresult == DialogResult.Cancel)
                    {
                        Console.WriteLine("You clicked either Cancel or X button in the top right corner");
                    }
                    popup.Dispose();*/
                }

           

            return request.ResponseBody.Id;
            }
            catch
            {
                MessageBox.Show("file wasn't uploaded, make sure you upload it");
                return " ";

            }
        }



        public IEnumerable<Google.Apis.Drive.v3.Data.File> GetFiles(string folder)
        {
            var service = GetService();

            var fileList = service.Files.List();
            fileList.Q = $"mimeType!='application/vnd.google-apps.folder' and '{folder}' in parents";
            fileList.Fields = "nextPageToken, files(id, name, size, mimeType)";

           

            var result = new List<Google.Apis.Drive.v3.Data.File>();
            string pageToken = null;
            do
            {
                fileList.PageToken = pageToken;
                var filesResult = fileList.Execute();
                var files = filesResult.Files;
                pageToken = filesResult.NextPageToken;
                result.AddRange(files);
            } while (pageToken != null);


    return result;
        }
    }
}
