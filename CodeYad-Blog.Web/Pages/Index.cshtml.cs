using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News_Ajums.CoreLayer.DTOs;
using News_Ajums.CoreLayer.DTOs.Posts;
using News_Ajums.CoreLayer.Services;
using News_Ajums.CoreLayer.Services.Posts;
using Microsoft.AspNetCore.Authorization;

namespace News_Ajums.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPostService _postService;
        private readonly IMainPageService _mainPageService;

       
        public IndexModel(IPostService postService, IMainPageService mainPageService)
        {
            _postService = postService;
            _mainPageService = mainPageService;
        }

        public MainPageDto MainPageData { get; set; }

        public List<PostSlidShowDto> PostSlids { get; set; }

        public void OnGet()
        {
            MainPageData = _mainPageService.GetData();
            PostSlids = _postService.PostSlidSows();
        }

        public IActionResult OnGetLatestPosts(string categorySlug)
        {
            var filterDto = _postService.GetPostsByFilter(new PostFilterParams()
            {
                CategorySlug = categorySlug,
                PageId = 1,
                Take = 6
            });
            return Partial("_LatestPosts", filterDto.Posts);
        }
        public IActionResult OnGetPopularPost()
        {
            return Partial("_PopularPosts", _postService.GetPopularPost());
        }

    }
}
