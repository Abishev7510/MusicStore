﻿using Diploma.BusinessLogic.Services.ItemService;
using Diploma.Domain.Entities;
using Diploma.DTO;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Diploma.Client.Pages
{
    public partial class ItemDetails
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IItemService ItemService { get; set; }
        private ItemDTO? Item { get; set; }
        private string ErrorMessage { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            ErrorMessage = "Sorry, an error has occured.";
            Item = await ItemService.GetItem(Id);
        }
    }
}