using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        private byte[] GetFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;

            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }

        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);

            List<Photo> photos = new List<Photo> {
                new Photo{ Title = "Test Photo", Description = "A fine Description", UserName = "Satoshi Nakamoto", PhotoFile = GetFileBytes("\\Images\flower.jpg"), ImageMimeType = "image/jpeg", CreatedDate = DateTime.Today },
            };

            photos.ForEach(p => context.Photos.Add(p));
            context.SaveChanges();

            List<Comment> comments = new List<Comment>
            {
                new Comment{ PhotoID = 1, UserName = "Satoshi Nakamoto", Subject = "*pok* *pok - is this thing on?", Body = "This comment should appear in photo 1" },
            };

            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}