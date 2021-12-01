using Incubadora.Repository.Infraestructure.Contract;

namespace Incubadora.Business
{
    public class AspNetRolesBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        public AspNetRolesBusiness(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }
    }
}
