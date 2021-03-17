using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Advokati.Model;
using System.Net.Http;
using System.Windows.Forms;

namespace Advokati.WinUI
{
    public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
                return result;
            
           

        }


        public async Task<T> Login<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/login";


            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;



        }


        public async Task<T> Get2<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/test";

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

            var result = await $"{Properties.Settings.Default.APIUrl}/{_route}".WithBasicAuth(KorisnickoIme,Lozinka).GetJsonAsync<T>();
         
            return result;
        }



        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

       
        public async Task<T> Insert<T>(object request)
        {
            
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }


        }

        public async Task<T> Update<T>(object id,object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/uredi/{id}";
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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }


        }


        public async Task<T> UpdateDelete<T>(object id, object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/brisanje/{id}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> GetAllForReport<T>(DateTime search1, DateTime search2)
        {

          
            var date1 = search1.ToString("dd/MM/yyyy").Replace('/', '-');
            var date2 = search2.ToString("dd/MM/yyyy").Replace('/', '-');
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/trosakOdDo/{date1}/{date2}";
          
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }


    }
}
