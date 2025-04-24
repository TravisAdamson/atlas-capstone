using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using REST.Services;

public class CustomAuthProvider : AuthenticationStateProvider
{
	private readonly UserState _userState;

	public CustomAuthProvider(UserState userState)
	{
		_userState = userState;
	}

	public override Task<AuthenticationState> GetAuthenticationStateAsync()
	{
		ClaimsIdentity identity;

		if (!string.IsNullOrEmpty(_userState.UserName) && _userState.UserName != "None")
		{
			identity = new ClaimsIdentity(new[]
			{
				new Claim(ClaimTypes.Name, _userState.UserName)
			}, "Custom");
		}
		else
		{
			identity = new ClaimsIdentity(); // not authenticated
		}

		var user = new ClaimsPrincipal(identity);
		return Task.FromResult(new AuthenticationState(user));
	}

	public void NotifyAuthenticationChanged()
	{
		NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
	}
}
