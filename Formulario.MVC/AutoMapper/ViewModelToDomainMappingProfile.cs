using AutoMapper;
using Formulario.Domain.Entities;
using Formulario.MVC.ViewModels;

namespace Formulario.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
        }
    }
}