using System.Collections.Generic;
using YJ.PF.NoteBooks.Dtos;
using YJ.PF.Roles.Dto;

namespace YJ.PF.Web.Areas.Mpa.Models.NoteBook
{
    public class NoteBookViewModel
    {
        public string FilterText { get; set; }

        public IReadOnlyList<NoteBookListDto> NoteBookListDto { get; set; }

       // public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
