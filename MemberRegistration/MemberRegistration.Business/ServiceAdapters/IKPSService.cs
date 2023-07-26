using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.ServiceAdapters
{
    public interface IKPSService
    {
        bool ValidateUser(Member member);
    }
}
