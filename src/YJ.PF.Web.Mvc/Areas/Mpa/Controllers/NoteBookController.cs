using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YJ.PF.Authorization;
using YJ.PF.Controllers;
using YJ.PF.NoteBooks;
using YJ.PF.NoteBooks.Authorization;
using YJ.PF.NoteBooks.Dtos;
using YJ.PF.Web.Areas.Mpa.Models.NoteBook;

namespace YJ.PF.Web.Mvc.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(NoteBookPermissions.Node)]
    [Area("Mpa")]
    [AbpMvcAuthorize]
    public class NoteBookController : PFControllerBase
    {
        private readonly INoteBookAppService _noteBookAppService;

        public NoteBookController(INoteBookAppService noteBookAppService)
        {
            _noteBookAppService = noteBookAppService;
        }

        public async Task<ActionResult> Index()
        {
            // Paging not implemented yet
             //var noteBooks = (await _noteBookAppService.GetPaged(new GetNoteBooksInput { MaxResultCount = int.MaxValue })).Items;
            var noteBooks = (await _noteBookAppService.GetPaged(new GetNoteBooksInput ())).Items;

            var model = new NoteBookViewModel
            {
                FilterText = Request.Query["filterText"],
                NoteBookListDto = noteBooks
            };
            return View(model);
        }

        public async Task<ActionResult> NoteBookEditModal(Guid? id)
        {
            var model = new EditNoteBookViewModel();
            if (id.HasValue)
            { 
            var noteBookEditDto = await _noteBookAppService.GetById(new EntityDto<Guid>(id.Value));
            model.NoteBookEditDto = noteBookEditDto.MapTo<NoteBookEditDto>();
            };
            return View("_EditNoteBookModal", model);
        }
    }

}