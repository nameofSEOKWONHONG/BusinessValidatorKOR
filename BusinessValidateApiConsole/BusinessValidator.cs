using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using RestSharp;

namespace BusinessValidateApiConsole
{
    /// <summary>
    /// 국세청 제공 사업자 진위여부 API 구현
    /// </summary>
    public class BusinessValidator
    {
        public BusinessValidator()
        {
            
        }

        public async Task<BusinessValidateResultDto> ValidateAsync(BusinessValidateReqeustDto requestDto)
        {
            var client = new RestClient(new Uri("https://api.odcloud.kr/api/nts-businessman/v1/validate"));
            var request = new RestRequest(Method.POST);
            request.AddParameter("businesses", new[] {requestDto});
            var response = await client.ExecuteAsync<BusinessValidateResultDto>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }

            return null;
        }

        public async Task<BusinessStatusResultDto> StatusAsync(string b_no)
        {
            var client = new RestClient(new Uri("https://api.odcloud.kr/api/nts-businessman/v1/status"));
            var request = new RestRequest(Method.POST);
            request.AddParameter("b_no", b_no);
            var response = await client.ExecuteAsync<BusinessStatusResultDto>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }

            return null;
        }
    }
}