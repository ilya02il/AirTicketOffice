namespace Model.Contracts
{
	public interface ICaptchaService
	{
		string CaptchaText { get; set; }
		bool IsValid { get; set; }

		bool CheckCaptcha(string captchaText);
	}
}
