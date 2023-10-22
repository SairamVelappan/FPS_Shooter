using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using System.Threading.Tasks;

namespace FPS
{
    public class AuthenticationManager : MonoBehaviour
    {
       private async void Start()
       {
            await UnityServices.InitializeAsync();
            SignIn();
       }

       public async void SignIn()
       {
            await SignInAnonymous();
       }

       private async Task SignInAnonymous()
       {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                Debug.LogError("Anonymous SignIn Successfull " + " Player ID " + AuthenticationService.Instance.PlayerId);
            }
            catch(AuthenticationException ex)
            {
                Debug.LogError("SignIn Failed");
                Debug.LogException(ex);
            }

       }
    }
}
