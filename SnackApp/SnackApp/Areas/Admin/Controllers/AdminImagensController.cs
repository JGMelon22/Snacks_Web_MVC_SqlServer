using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SnackApp.Models;
using SnackApp.Models.SnackApp.Models;

namespace SnackApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminImagensController : Controller
    {
        // environment variable
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ConfigurationImagens _myConfig;

        // ctor
        // Dependency injection into the ctor
        public AdminImagensController(IWebHostEnvironment hostingEnvironment,
            IOptions<ConfigurationImagens> myConfiguration)
        {
            _hostingEnvironment = hostingEnvironment;
            _myConfig = myConfiguration.Value;
        }

        // GET
        // Action method which will presents a report 
        // where you will display options to send and consult archives
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            // Check if the archive count it is null or zero.
            // If so, throws and error
            if (files == null || files.Count == 0)
            {
                ViewData["Erro"] = "Error: Arquivo(s) não selecionado(s)";
                return View(ViewData);
            }

            // Check if the archive count it is greater than 10
            // If so, throws and error
            if (files.Count > 10)
            {
                ViewData["Erro"] = "Error: Quantidade de arquivos excedeu o limite";
                return View(ViewData);
            }

            // Calculate the total in bytes
            var size = files.Sum(f => f.Length);

            // Storage the archive names which were sent
            var filePathsName = new List<string>();

            // Obtains the full path where we storage the archives
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                _myConfig.NomePastaImagensProdutos);

            // Walks trough the files and then verifies if they are image archives
            foreach (var formFile in files)
                if (formFile.FileName.Contains(".jpg") || formFile.FileName.Contains(".gif")
                                                       || formFile.FileName.Contains(".png"))
                {
                    // Send the archive and build a name
                    // Use the line below, which is commented, if you are on Windows
                    // var fileNameWithPath = string.Concat(filePath, "\\", formFile.FileName);
                    var fileNameWithPath = string.Concat(filePath, "/", formFile.FileName);

                    filePathsName.Add(fileNameWithPath);

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }

            ViewData["Resultado"] = $"{files.Count} arquivos foram enviados ao servidor, " +
                                    $"com tamanho total de : {size} bytes";

            // Allow to carry small data amount between views or controller to view
            ViewBag.Arquivos = filePathsName;

            return View(ViewData);
        }

        // See infos about the images storaged on the server
        public IActionResult GetImagens()
        {
            var model = new FileManagerModel();

            var userImagesPath = Path.Combine(_hostingEnvironment.WebRootPath,
                _myConfig.NomePastaImagensProdutos);


            var dir = new DirectoryInfo(userImagesPath);

            var files = dir.GetFiles();

            model.PathImagesProduto = _myConfig.NomePastaImagensProdutos;


            // If there are no archives in the file, throws error with a viedata
            if (files.Length == 0) ViewData["Erro"] = $"Nenhum arquivo encontrado na pasta {userImagesPath}";

            // Relationship between archives obtained from the server file
            model.Files = files;

            return View(model);
        }

        public IActionResult Deletefile(string fname)
        {
            /*
             var _imagemDeleta = Path.Combine(_hostingEnvironment.WebRootPath,
                _myConfig.NomePastaImagensProdutos + "\\", fname);
                */
            // If you are on Windows, use the code block above 
            var _imagemDeleta = Path.Combine(_hostingEnvironment.WebRootPath,
                _myConfig.NomePastaImagensProdutos + "/", fname);

            // If exists, delete
            if (System.IO.File.Exists(_imagemDeleta))
            {
                System.IO.File.Delete(_imagemDeleta);

                // Builds a ViewData with the archive wich was deleted
                ViewData["Deletado"] = $"Arquivo(s) {_imagemDeleta} deletado com sucesso";
            }

            return View("index");
        }
    }
}