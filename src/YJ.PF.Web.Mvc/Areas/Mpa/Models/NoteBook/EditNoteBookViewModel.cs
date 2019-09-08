using Abp.AutoMapper;
using YJ.PF.NoteBooks.Dtos;
using YJ.PF.Roles.Dto;
using YJ.PF.Web.Models.Common;

namespace YJ.PF.Web.Areas.Mpa.Models.NoteBook
{
    public class EditNoteBookViewModel
    {
        public NoteBookEditDto NoteBookEditDto { get; set; }

        public EditNoteBookViewModel()
        {
            this.NoteBookEditDto = new NoteBookEditDto();
        }
    }
}
