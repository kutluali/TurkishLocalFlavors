using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using TurkishLocalFlavors.DataAccess.Concrete;

namespace TurkishLocalFlavorsApi.Hubs
{
    public class SignalRHub : Hub
    {
        FlavorsContext context=new FlavorsContext();

        public async Task SendCategoryCount()
        {

            var value = context.Categories.Count();

            await Clients.All.SendAsync("ReceiveCategoryCount", value);

        }

    }
}
