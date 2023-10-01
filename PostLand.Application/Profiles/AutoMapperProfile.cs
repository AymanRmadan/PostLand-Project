using AutoMapper;
using PostLand.Application.Features.Categories.Commands.CreateCategory;
using PostLand.Application.Features.Categories.Commands.UpdateCateory;
using PostLand.Application.Features.Categories.Queries.GetAllCategory;
using PostLand.Application.Features.Categories.Queries.GetCategoryByID;
using PostLand.Application.Features.Posts.Commands.CreatePost;
using PostLand.Application.Features.Posts.Commands.DeletePost;
using PostLand.Application.Features.Posts.Commands.UpdatePost;
using PostLand.Application.Features.Posts.Queries.GetPostDetail;
using PostLand.Application.Features.Posts.Queries.GetPostsList;
using PostLand.Domain.Entities;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
            CreateMap<Category, GetListCategoryViewModel>().ReverseMap();
            CreateMap<Category, GetCategoryByIDViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

        }
    }
}
