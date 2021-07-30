using System.Collections.Generic;

namespace BusinessValidateApiConsole
{
    public class BusinessStatusResultDto
    {
        public string status_code { get; set; }
        public int match_cnt { get; set; }
        public int request_cnt { get; set; }
        public IEnumerable<BusinessStatusResultDto> data { get; set; }
    }
}