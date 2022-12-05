using AutoMapper;
using OefeningBlogEF.Entities;
using OefeningBlogEF.ViewModels;
namespace OefeningBlogEF;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Entities.Category, ViewModels.Category>();
        CreateMap<PostCreateViewModel, Post>();
        CreateMap<PostUpdateViewModel, Post>();
    }
}
