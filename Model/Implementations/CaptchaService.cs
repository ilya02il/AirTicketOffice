using Model.Contracts;

namespace Model.Implementations
{
	public class CaptchaService : ICaptchaService
	{
		public string CaptchaText { get; set; }
		public bool IsValid { get; set; }
		public bool CheckCaptcha(string captchaText)
		{
			if (captchaText != CaptchaText) return false;

			IsValid = true;
			return true;
		}
	}
}
