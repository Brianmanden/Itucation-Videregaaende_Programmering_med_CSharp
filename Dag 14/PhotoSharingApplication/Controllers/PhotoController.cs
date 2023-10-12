using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication.Controllers
{
    [ValueReporter]
    public class PhotoController : Controller
    {
        private PhotoSharingContext context = new PhotoSharingContext(); 

        // GET: Photo
        public ActionResult Index()
        {
            return View(context.Photos.ToList());
        }

        public ActionResult Display(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var foundPhoto = context.Photos.Find(id);

            if (foundPhoto == null)
            {
                return HttpNotFound();
            }

            return View("Display", foundPhoto);
        }

        public ActionResult Create()
        {
            Photo newPhoto = new Photo();
            newPhoto.CreatedDate = DateTime.Today;

            return View("Create", newPhoto);
        }

        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
            photo.CreatedDate = DateTime.Today;

            if (!ModelState.IsValid) {
                return View("Create", photo);
            }
            else
            {
                if (image != null)
                {
                    photo.ImageMimeType = image.ContentType;
                    photo.PhotoFile = new byte[image.ContentLength];
                    image.InputStream.Read(
                        photo.PhotoFile, 0, image.ContentLength);
                }

                context.Photos.Add(photo);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            Photo foundPhoto = context.Photos.Find(id);

            if (foundPhoto == null) {
                return HttpNotFound();
            }
            else
            {
                return View("Delete", foundPhoto);
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id) {
            Photo photoToDelete = context.Photos.Find(id);
            context.Photos.Remove(photoToDelete);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public FileContentResult GetImage(int id)
        {
            Photo foundPhoto = context.Photos.Find(id);

            if (foundPhoto != null) {
                return File(foundPhoto.PhotoFile, foundPhoto.ImageMimeType);
            }

            return null;
        }
    }
}
