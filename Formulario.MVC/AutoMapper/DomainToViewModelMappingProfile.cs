using AutoMapper;
using Formulario.Domain.Entities;
using Formulario.MVC.ViewModels;

namespace Formulario.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
        }
    }
}