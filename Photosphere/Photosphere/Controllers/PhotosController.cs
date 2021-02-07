using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImageMagick;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Photosphere.Data;
using Photosphere.Models;

namespace Photosphere.Controllers
{
    [Authorize]
    public class PhotosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhotosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "User,Admin")]
        // GET: Photos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Photos.ToListAsync());
        }

        // GET: Photos/Details/5
        [Authorize(Roles ="User,Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }
        [Authorize(Roles = "User")]

        // GET: Photos/Create
        public IActionResult Create()
        {
            
            return View();
        }


        // POST: Photos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> Create(IFormFile Image, String FileName, String FileType)
        {
            Photo photo = new Photo();

            if (Image != null && FileName != null && FileType != null)
            {   
                if(FileType != "image/jpeg")
                {
                    return RedirectToAction("Create", "Photos");
                }
                var imageFile = Image.OpenReadStream();
                byte[] p1 = null;
                
                using (var image = new MagickImage(imageFile))
                {
                    var profile = image.GetExifProfile();

                    if (profile == null)
                    {
                        Debug.WriteLine("No profile");
                    }
                    else
                    {

                        foreach (var value in profile.Values)
                        {
                            
                            if (value.Tag.ToString().Equals("Make"))
                            {
                                photo.Manufacturer = value.ToString();
                            }
                            if (value.Tag.ToString().Equals("Model"))
                            {
                                photo.Model = value.ToString();
                            }
                            if (value.Tag.ToString().Equals("ExposureTime"))
                            {
                                photo.ExposureTime = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("FNumber"))
                            {
                                photo.FStop = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("FocalLength"))
                            {
                                photo.FocalLength = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("MaxApertureValue"))
                            {
                                photo.MaxAperture = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("ExposureBiasValue"))
                            {
                                photo.ExposureBias = value.ToString();
                            }

                        

                            if (value.Tag.ToString().Equals("PixelXDimension"))
                            {
                                photo.Width = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("PixelYDimension"))
                            {
                                photo.Height = value.ToString();
                            }

                            if (value.Tag.ToString().Equals("FocalLengthIn35mmFilm"))
                            {
                                photo.AffectedFocalLength = value.ToString();
                            }
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                            photo.FileName = FileName;
                            photo.FileType = FileType;                            
                            photo.Image = p1;

                        }
                        
                        _context.Add(photo);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }
                }
                
            }
            else
            {
                Debug.WriteLine(Image);
               // Debug.WriteLine(photo.FileName);
               // Debug.WriteLine(photo.FileType);
                Debug.WriteLine("No Image");
            }
            
           
            return View(photo);
        }
        [Authorize(Roles = "Admin")]
        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }
            return View(photo);
        }
        [Authorize]
        public async Task<IActionResult> AddToFav(long id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(f => f.Id == id);

            if (photo != null)
            {
                photo.Favourite = true;
                _context.Photos.Update(photo);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Favourite", "Photos");
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Photo photo, int id,String FileName, String FileType, String Manufacturer, String Model, String ExposureTime, String FStop, String FocalLength, String MaxAperture, String ExposureBias, String Width, String Height, String AffectedFocalLength, Boolean Favourite, String Comments)
        {

            if (id != photo.Id)
            {
                return NotFound();
            }

            if (id!= null)
            {
                try
                {
                    
                    photo.FileName = FileName;
                    photo.FileType = FileType;
                    photo.Manufacturer = Manufacturer;
                    photo.Model = Model;
                    photo.ExposureTime = ExposureTime;
                    photo.FStop = FStop;
                    photo.FocalLength = FocalLength;
                    photo.MaxAperture = MaxAperture;
                    photo.ExposureBias = ExposureBias;
                    photo.Width = Width;
                    photo.Height = Height;
                    photo.AffectedFocalLength = AffectedFocalLength;
                    photo.Favourite = Favourite;
                    photo.Comments = Comments;

                    _context.Update(photo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoExists(photo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(photo);
        }

        // GET: Photos/Delete/5
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }
            
            return View(photo);
        }
        [Authorize]

        public async Task<IActionResult> Favourite()
        {
           
            var photo = _context.Photos.Where(r => r.Favourite.Equals(true)).AsQueryable();

            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }
        
        [Authorize]
        public async Task<IActionResult> AddToCommentAsync(long id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(f => f.Id == id);

            if (id != photo.Id)
            {
                return NotFound();
            }

            if (photo != null)
            {
                return View(photo);

            }
            return View(photo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> AddToComment(long id, String Comments)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(f => f.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            if (id != null && Comments != null)
            {
                try
                {
                    photo.Comments = Comments;
                    _context.Photos.Update(photo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoExists(photo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return RedirectToAction("Index", "Photos");

        }
        [Authorize]
        public async Task<IActionResult> Search(String Search,String SearchType)
        {
            if (Search == null || SearchType == null)
            {
                return RedirectToAction("Index", "Photos");
            }

            
            
            switch (SearchType)
            {
                case "FileName":
                    var photo = _context.Photos.Where(r => r.FileName.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "FileType":
                    photo = _context.Photos.Where(r => r.FileType.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "Manufacturer":
                    photo = _context.Photos.Where(r => r.Manufacturer.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "Model":
                    photo = _context.Photos.Where(r => r.Model.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "ExposureTime":
                    photo = _context.Photos.Where(r => r.ExposureTime.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "FStop":
                    photo = _context.Photos.Where(r => r.FStop.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "FocalLength":
                    photo = _context.Photos.Where(r => r.FocalLength.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "MaxAperture":
                    photo = _context.Photos.Where(r => r.MaxAperture.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "ExposureBias":
                    photo = _context.Photos.Where(r => r.ExposureBias.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "Width":
                    photo = _context.Photos.Where(r => r.Width.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "Height":
                    photo = _context.Photos.Where(r => r.Height.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "AffectedFocalLength":
                    photo = _context.Photos.Where(r => r.AffectedFocalLength.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;
                case "Comments":
                    photo = _context.Photos.Where(r => r.Comments.ToLower().Contains(Search.ToLower())).AsQueryable();
                    if (photo != null)
                    {
                        return View(photo);
                    }

                    if (photo == null)
                    {
                        return NotFound();
                    }

                    return View(photo);
                    break;

            }
            

            return RedirectToAction("Index", "Home");


        }


        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotoExists(int id)
        {
            return _context.Photos.Any(e => e.Id == id);
        }

    }
}
