using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode {  get; set; }

        public List<string> Message { get; set; }

        public Object Result {  get; set; }

        public ApiResponse(HttpStatusCode Code ,List<string> Message ,Object Result ) {
            StatusCode = Code;
            this.Message = Message;
            this.Result = Result;
        }
        public ApiResponse(){}
    }
}
