using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ManpowerManagement.Service.Helper
{
    public static class Helper
    {
        public static ExpandoObject ModelStateError(ModelStateDictionary modelState)
        {
            dynamic Response = new ExpandoObject();
            string errorMsg = string.Empty;
            foreach (var state in modelState.Values)
            {
                foreach (var error in state.Errors)
                {
                    if (string.IsNullOrEmpty(error.ErrorMessage)) continue;
                    errorMsg += error.ErrorMessage.TrimEnd('.') + ". ";
                }
            }
            Response.status = false;
            Response.message = errorMsg == "" ? "There is some problem to display the data. Kindly try later." : errorMsg;
            return Response;
        }
    }
}
