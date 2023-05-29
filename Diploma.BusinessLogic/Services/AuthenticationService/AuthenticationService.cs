﻿using Diploma.Domain;
using Diploma.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.BusinessLogic.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;

        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseFromServer<int>> Register(CreateUserDTO request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/authentication/register", request);
            return await result.Content.ReadFromJsonAsync<ResponseFromServer<int>>();
        }

        public async Task<ResponseFromServer<string>> Login(AuthenticateUserDTO request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/authentication/login", request);
            return await result.Content.ReadFromJsonAsync<ResponseFromServer<string>>();
        }

        public async Task<ResponseFromServer<bool>> ChangePassword(ChangePasswordDTO request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/authentication/change-password", request.Password);
            return await result.Content.ReadFromJsonAsync<ResponseFromServer<bool>>();
        }
    }
}
