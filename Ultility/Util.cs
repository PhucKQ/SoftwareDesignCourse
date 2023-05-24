using Microsoft.AspNetCore.Http;

namespace Ultility
{
    public static class Util
    {
        public const int PageHas9Items = 9;
        public const int PageHas18Items = 18;
        public const int PageHas36Items = 36;

        public static string? UploadImage(string? existingImagePath, IFormFile? file, string wwwRootPath, string parentFolder)
        {
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string brandPath = Path.Combine(wwwRootPath, @"img\" + parentFolder);

                // if exist old image
                if (!string.IsNullOrEmpty(existingImagePath))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, existingImagePath.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                using (var fileStream = new FileStream(Path.Combine(brandPath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                return @"\img\" + parentFolder + "\\" + fileName;
            }

            return existingImagePath;
        }

        public static void DeleteImage(string existingImagePath, string wwwRootPath)
        {
            if (existingImagePath != null)
            {
                var oldImagePath = Path.Combine(wwwRootPath, existingImagePath.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
        }
    }
}