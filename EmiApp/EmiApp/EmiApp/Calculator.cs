namespace EmiApp
{
    public class Calculator: ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            var response = new Response();
            try
            {
                var rate = request.InterestRateInPercentage / 100;
                var power = request.LoanDurationInYearCount * rate ;
                var accumulated = (double)request.Principal * Math.Exp(power);
                // convert to response object
                response.EmiPayment = (decimal)accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }

            return response;
        }

        public Response CalculateDailyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 365;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 365, power)-(double)request.Principal;
                // convert to response object
                response.EmiPayment = (decimal)accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }

            return response;
        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * Math.Pow(1 + rate / 12, power);
                // convert to response object
                response.EmiPayment = (decimal)accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            
                return response;
            
        }
    }
}