using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Question.QuestionType enumerated type defines the type of the question raised.
    /// </summary>
    public enum VcenterDeploymentQuestionQuestionTypeA
    {
        [EnumMember(Value = "YES_NO")]
        YESNO = 1,
        [EnumMember(Value = "OK_CANCEL")]
        OKCANCEL = 2,
        [EnumMember(Value = "ABORT_RETRY_IGNORE")]
        ABORTRETRYIGNORE = 3,
    }
}
