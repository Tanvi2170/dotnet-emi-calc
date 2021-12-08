using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmiApp.api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmiController : ControllerBase
    {
        [HttpPost]
        [Route("api/[controller]/CalculateMonthlyEmi")]
        // [HttpPost(Name = "CalculateMonthlyEmi")]

        public Response CalculatorMonthlyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();
            var response = new Response();


            var emiMonthly = emiCalculator.CalculateMonthlyEmi(request);
            return emiMonthly;
        }

        // [HttpGet(Name = "CalculateDailyEmi")]
        [HttpPost]
        [Route("api/[controller]/CalculateDailyEmi")]
        public Response CalculatorDailyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();
            var response = new Response();

            var emiDaily = emiCalculator.CalculateDailyEmi(request);

            return emiDaily;
        }


        // [HttpPost(Name = "CalculateContinousEmi")]
        [HttpPost]
        [Route("api/[controller]/CalculateContinousEmi")]
        public Response CalculateContinousEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();
            var response = new Response();

            var emiContinous = emiCalculator.CalculateContinousEmi(request);

            return emiContinous;


        }
    }
}
