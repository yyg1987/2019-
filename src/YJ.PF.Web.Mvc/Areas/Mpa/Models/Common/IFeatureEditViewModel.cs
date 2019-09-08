using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YJ.PF.Editions.Dto;

namespace YJ.PF.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}