using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure;
using System.IO;

namespace AzureStorageSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=jetcdn;AccountKey=accountkey");
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("yourcontainer");
            
            //CloudBlockBlob blockBlob = container.GetBlockBlobReference("025700702511.JPG");

            foreach (var blob in container.ListBlobs().OfType<CloudBlockBlob>())
            {
                //if (Path.GetExtension(blob.Uri.AbsoluteUri) == ".GIF")
                //{
                //    blob.Properties.ContentType = "image/gif";
                //    Console.WriteLine(blob.Name);
                //}
                
                //blob.SetProperties();
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
