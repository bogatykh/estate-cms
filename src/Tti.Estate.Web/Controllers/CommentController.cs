using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentController(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CommentModel model = new CommentModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentModel model)
        {
            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<Comment>(model);

                await _commentRepository.CreateAsync(comment);

                return RedirectToAction("Details", new { id = comment.Id });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IEnumerable<CommentListItemModel>> GetData(CommentListRequestModel requestModel)
        {
            var data = await _commentRepository.ListAsync();

            return _mapper.Map<IEnumerable<CommentListItemModel>>(data);
        }
    }
}
