﻿#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Alejof.SimpleBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Alejof.SimpleBlog.Controllers
{
    [Route("api/v1/")]
    public class EditorApiController : Controller
    {
        private readonly Services.IPostService _postService;
        private readonly ILogger<EditorApiController> _logger;

        public EditorApiController(
            Services.IPostService postService,
            ILogger<EditorApiController> logger)
        {
            _postService = postService;
            _logger = logger;
        }

        [HttpGet, Route("posts")]
        public async Task<IActionResult> Index()
        {
            var posts = await _postService.GetPosts();

            return Ok(
                posts
                    .Where(p => p.Status == Services.PostStatus.Pending)
                    .OrderByDescending(c => c.UpdatedDate)
                    .Select(p => Models.PostEditViewModel.FromModel(p)));
        }

        [HttpPost, Route("posts/{slug?}/approve")]
        public async Task<IActionResult> Approve([FromRoute]string slug)
        {
            var post = await _postService.GetPost(slug);
            if (post?.Status != Services.PostStatus.Pending) return NotFound();

            post.Status = Services.PostStatus.Published;
            post.ApprovalDate = DateTime.Now;

            var result = await _postService.SavePost(post);
            if (!result.Success)
                return this.UnprocessableEntity(result.Error);

            return Ok();
        }

        [HttpPost, Route("posts/{slug?}/reject")]
        public async Task<IActionResult> PostReject([FromRoute]string slug)
        {
            var post = await _postService.GetPost(slug);
            if (post?.Status != Services.PostStatus.Pending) return NotFound();

            post.Status = Services.PostStatus.Draft;

            var result = await _postService.SavePost(post);
            if (!result.Success)
                return this.UnprocessableEntity(result.Error);

            return Ok();
        }
    }
}
