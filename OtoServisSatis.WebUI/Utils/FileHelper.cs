namespace OtoServisSatis.WebUI.Utils
{
    public class FileHelper
    {
        //default olarak IMG Klasörüne resim yüklenecek resmin yükleneceği klasörü değiştirebiliriz de
        public static async Task<string> FileLoaderAsync(IFormFile formFile,string filePath="/Img/")
        {
            var fileName = "";
            if (formFile!=null && formFile.Length>0)
            {
                fileName = formFile.FileName;
                string directory = Directory.GetCurrentDirectory()+"/wwwroot/"+filePath+fileName;
                using var stream = new FileStream(directory,FileMode.Create);
                await formFile.CopyToAsync(stream);//sunucuya kopyalama
            }
            return fileName;
        }
    }
}
