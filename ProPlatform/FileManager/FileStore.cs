using SmartWatch.DbModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.ProPlatform.FileManager
{
    public class FileStore
    {
        public List<FileData> StoreUploadFiles(HttpContext context, long fileTypeId, string filePrifix, string description, long documentId = 0)
        {
            List<FileData> addedFiles = new List<FileData>();

            string fName = string.Empty;
            string filePath = string.Empty;
            string title = string.Empty;

            string folderPath = "1";
            string paths= context.Request.Path;
            var path = paths.Split("/");

            folderPath =Path.Combine("DataFolder", "1", path[1], path[2]);

            

            var files = context.Request.Form.Files;
            foreach (var file in files)
            {
                try
                {
                    FileData fileData = new FileData();
                    // make the file name
                    string name = DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-";
                    name += file.FileName;
                    fileData.OriginalFileName = name; // get original name
                    if(filePrifix != string.Empty)
                    {
                        title = filePrifix;
                    }
                    else
                    {
                        title= file.FileName;
                    }
                    name = name.Trim('"');
                    name = name.Replace('"', '-');
                    name = name.Replace(' ', '-');
                    fName = name;
                    //store the server file
                    string localFileName = file.FileName;
                    filePath = Path.Combine(folderPath, name);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(stream);
                    }


                    /*Document document = null;
                    using (LMSContext db = new LMSContext())
                    {
                        if(documentId>0)
                        {
                            document = db.Document.Where(w => w.DocumentId == documentId).FirstOrDefault();
                        }
                        if(document == null)
                        {

                            document = new Document();
                            db.Document.Add(document);
                        }
                        document.DocumentName = title;
                        document.DocumentFilePath = filePath;
                        document.DocumentTypeId = fileTypeId;
                        document.DocumentDescription = description;
                        document.DocumentIsDelete = false;
                        fileData.document = document;
                        
                        db.SaveChanges();
                    }*/
                    addedFiles.Add(fileData);
                }
                catch(Exception)
                {
                    continue;
                }
                


            }

            return addedFiles;
        }

    }
}
