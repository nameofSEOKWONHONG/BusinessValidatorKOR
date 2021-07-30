using System.Collections.Generic;

namespace BusinessValidateApiConsole
{
    public class BusinessValidateReqeustDto
    {
        /// <summary>
        /// 사업자등록번호
        /// </summary>
        public string b_no { get; set; }
        /// <summary>
        /// 개업일자 (YYYYMMDD 포맷)
        /// </summary>
        public string start_dt { get; set; }
        /// <summary>
        /// 대표자성명
        /// </summary>
        public string p_nm { get; set; }
        /// <summary>
        /// 대표자성명2 - 대표자성명1 이 한글이 아닌 경우, 이에 대한 한글명
        /// </summary>
        public string p_nm2 { get; set; }
        /// <summary>
        /// 상호 (Optional)
        /// </summary>
        public string b_nm { get; set; }
        /// <summary>
        /// 법인등록번호 (Optional)
        /// </summary>
        public string corp_no { get; set; }
        /// <summary>
        /// 주업태명 (Optional)
        /// </summary>
        public string b_sector { get; set; }
        /// <summary>
        /// 주종목명 (Optional)
        /// </summary>
        public string b_type { get; set; }
    }

    public class BusinessValidateResultDto
    {
        /// <summary>
        /// API 상태 코드
        /// </summary>
        public string status_code { get; set; }
        /// <summary>
        /// 조회 요청 수
        /// </summary>
        public int request_cnt { get; set; }
        /// <summary>
        /// 검증 Valid 수
        /// </summary>
        public int valid_cnt { get; set; }
        public IEnumerable<BusinessValidateResultDetailDto> data { get; set; }
    }

    public class BusinessValidateResultDetailDto
    {
        /// <summary>
        /// 사업자등록번호
        /// </summary>
        public string b_no { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string valid { get; set; }
        public string valid_msg { get; set; }
        public BusinessValidateReqeustDto request_param { get; set; }
        public BusinessValidateStatusDto status { get; set; }
    }

    public class BusinessValidateStatusDto
    {
        public string b_no { get; set; }
        /// <summary>
        /// 납세자상태(명칭)
        /// </summary>
        public string b_stt { get; set; }
        /// <summary>
        /// 납세자상태(코드)
        /// </summary>
        public string b_stt_cd { get; set; }
        /// <summary>
        /// 과세유형메세지(명칭):
        /// 01:부가가치세 일반과세자,
        /// 02:부가가치세 간이과세자,
        /// 03:부가가치세 과세특례자,
        /// 04:부가가치세 면세사업자,
        /// 05:수익사업을 영위하지 않는 비영리법인이거나 고유번호가 부여된 단체,국가기관 등,
        /// 06:고유번호가 부여된 단체,
        /// 07:부가가치세 간이과세자(세금계산서 발급사업자),
        /// </summary>
        public string tax_type { get; set; }
        /// <summary>
        /// 과세유형메세지(코드):
        /// 01:부가가치세 일반과세자,
        /// 02:부가가치세 간이과세자,
        /// 03:부가가치세 과세특례자,
        /// 04:부가가치세 면세사업자,
        /// 05:수익사업을 영위하지 않는 비영리법인이거나 고유번호가 부여된 단체,국가기관 등,
        /// 06:고유번호가 부여된 단체,
        /// 07:부가가치세 간이과세자(세금계산서 발급사업자)
        /// </summary>
        public string tax_type_cd { get; set; }
        /// <summary>
        /// 폐업일 (YYYYMMDD 포맷)
        /// </summary>
        public string end_dt { get; set; }
        /// <summary>
        /// 단위과세전환폐업여부(Y,N)
        /// </summary>
        public string utcc_tn { get; set; }
        /// <summary>
        /// 최근과세유형전환일자 (YYYYMMDD 포맷)
        /// </summary>
        public string tax_type_change_dt { get; set; }
        /// <summary>
        /// 세금계산서적용일자 (YYYYMMDD 포맷)
        /// </summary>
        public string invoice_apply_dt { get; set; }
    }
}