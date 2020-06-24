using DemoSite.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DemoSite.Client.Pages.Personal
{
    public class UsersBase : ComponentBase
    {
        [Parameter]
        public string userName { get; set; }
        public User[] users { get; set; } 
        [Inject]
        public HttpClient Http { get; set; }
        public bool dialogIsOpen { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            users = await Http.GetFromJsonAsync<User[]>("UserDetails/ListUsers");
        }
        public async Task LoadUser(string UserName)
        {
            user  = await Http.GetFromJsonAsync<User>($"UserDetails/{UserName}");
            dialogIsOpen = true;
        }
        public User user { get; set; }
    }
}
