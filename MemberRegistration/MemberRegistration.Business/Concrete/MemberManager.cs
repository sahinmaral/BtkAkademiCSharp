using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegistration.Core.Aspects.Postsharp.ValidationAspects;

using System;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;
        IKPSService _kpsService;
        public MemberManager(IMemberDal memberDal, IKPSService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExists(member);

            CheckIfUserValidFromKPS(member);

            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKPS(Member member)
        {
            if (!_kpsService.ValidateUser(member))
            {
                throw new Exception("Kullanici dogrulamasi gecerli degil");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TCNo.Equals(member.TCNo)) != null)
                throw new Exception("Bu kullanici daha once kayit olmustur");
        }
    }
}
