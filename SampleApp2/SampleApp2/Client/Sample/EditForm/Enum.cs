using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SampleApp2.Client.Sample.EditForm
{
    public enum GenderType
    {
        [Display(Name = "男")]
        Male,
        [Display(Name = "女")]
        Female,
    }

    public enum Prefecture
    {
        [Display(Name = "北海道")]
        Hokkaido,
        [Display(Name = "東京")]
        Tokyo,
        [Display(Name = "大阪")]
        Osaka,
        [Display(Name = "京都")]
        Kyoto,
        [Display(Name = "埼玉")]
        Saitama,
    }

}
