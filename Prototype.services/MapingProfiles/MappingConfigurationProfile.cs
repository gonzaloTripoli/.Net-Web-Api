using AutoMapper;
using Prototype.Services.ViewModels.Customer;
using PrototypeApp.DAL.Model;

namespace Prototype.Services.MapingProfiles
{
    public class MappingConfigurationProfile :Profile
    {

        public override string ProfileName
        {
            get
            {
                return "MappingConfigurationProfile";
            }
        }
        public MappingConfigurationProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<Customer, CustomerCreateViewModel>().ReverseMap();


        }
    }
}
