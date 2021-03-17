using Advokati.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Advokati.Mobile
{
   public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private string _route = null;
#if DEBUG
        private string _apiUrl = "http://localhost:12345/api";
#endif

#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                   
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }

        }


        public async Task<T> Get2<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}/test";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.GetJsonAsync<T>();
            return result;
        }




        public async Task<T> Get<T>()
        {
            var url = $"{_apiUrl}/{_route}";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();

            return result;
        }



        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }


        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return default(T);
            }


        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/uredi/{id}";
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return default(T);
            }


        }


        public async Task<T> UpdateDelete<T>(object id, object request)
        {

            var url = $"{_apiUrl}/{_route}/brisanje/{id}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> GetAdvokatiPreporuka<T>(int search)
        {

            var url = $"{_apiUrl}/{_route}/{search}/advokati";

            var result = await url.GetJsonAsync<T>();
            return result;
        }

    }
}
