using HamishInsights.Data;
using HamishInsights.Models;
using HamishInsights.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HamishInsights.Controllers
{
    public class PostController : Controller
    {
        private readonly HamishInsightContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        // this is our allowed extensions and we campare the extension coming from image file name
        private readonly string[] _allowedExtensions = { ".jpg", ".png", ".jpeg" };

        public PostController(HamishInsightContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Create()
        {
            PostViewModel postViewModel = new PostViewModel();
            postViewModel.Categories = _context.Categories.Select(c =>

            new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name

            }).ToList();
            ViewBag.Categories = _context.Categories.ToList();


            return View(postViewModel);
        }

        public async Task<IActionResult> Create(PostViewModel postViewModel)
        {
            _context
            return View();
        }



























        //public IActionResult Index(int? categoryId)
        //{
        //    var postQuery = _context.Posts.Include(p => p.Category).AsQueryable();
        //    if (categoryId.HasValue)
        //    {
        //        postQuery = postQuery.Where(p => p.CategoryId == categoryId);
        //    }
        //    var posts = postQuery.ToList();
        //    ViewBag.Categories = _context.Categories.ToList();
        //    return View(posts);
        //}

        //// Here are The Post Model Actions
        ////================================




        //// Pass Categories
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    
        //    postViewModel.Categories = _context.Categories.Select(c =>
        //    new SelectListItem
        //    {
        //        Value = c.Id.ToString(),
        //        Text = c.Name,
        //    }).ToList();

        //    return View(postViewModel);
        //}





        //[HttpPost]
        //public async Task<IActionResult> Create(PostViewModel postViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var fileextension = Path.GetExtension(postViewModel.FeatureImage.FileName).ToLower();
        //        bool isallowed = _allowedExtensions.Contains(fileextension);
        //        if (!isallowed)
        //        {
        //            ModelState.AddModelError("", "The File is Invalid Allowed .JPG, .JPEG, .PNG");
        //            return View(postViewModel);
        //        }
        //        else
        //        {
        //            postViewModel.Post.FeatureImagePath = await UploadFileToFolder(postViewModel.FeatureImage);
        //            await _context.Posts.AddAsync(postViewModel.Post);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction("Index");


        //        }

        //        // if File Extension is Matched With AllowedExtensions Then ---->

        //    }

        //    return View(postViewModel);
        //}


        //private async Task<string> UploadFileToFolder(IFormFile file) // Coming from PostViewModel
        //{
        //    var fileExtension = Path.GetExtension(file.FileName);
        //    var SetUniqueFileName = Guid.NewGuid().ToString() + fileExtension; // Set Unique name to file
        //    var wwwrootFolderPath = _webHostEnvironment.WebRootPath;
        //    var ImageFolderPath = Path.Combine(wwwrootFolderPath, "Images");

        //    if (!Directory.Exists(ImageFolderPath))
        //    {
        //        Directory.CreateDirectory(ImageFolderPath);
        //    }

        //    var filepath = Path.Combine(ImageFolderPath, SetUniqueFileName);
        //    try
        //    {
        //        await using (var FileStream = new FileStream(filepath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(FileStream);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return "File Not Created";
        //    }

        //    return "/Images/" + SetUniqueFileName;

    }
}