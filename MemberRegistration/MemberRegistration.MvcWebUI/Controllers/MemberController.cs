using MemberRegistration.Business.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegistration.MvcWebUI.Filters;
using MemberRegistration.MvcWebUI.Models;

using System.Web.Mvc;

namespace MemberRegistration.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }

        [ExceptionHandler]
        [HttpPost]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);

            return View(new MemberAddViewModel());
        }
    }
}