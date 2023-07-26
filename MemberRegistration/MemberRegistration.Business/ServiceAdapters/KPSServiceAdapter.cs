using MemberRegistration.Business.KPSServiceReference;
using MemberRegistration.Entities.Concrete;

using System;

namespace MemberRegistration.Business.ServiceAdapters
{
    public class KPSServiceAdapter : IKPSService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            var result = client.TCKimlikNoDogrula(
                TCKimlikNo: Convert.ToInt64(member.TCNo),
                Ad: member.FirstName,
                Soyad: member.LastName.ToUpper(),
                DogumYili: member.DateOfBirth.Year
                );

            return result;
        }
    }
}
