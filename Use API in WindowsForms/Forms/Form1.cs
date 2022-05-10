using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Use_API_in_WindowsForms.Functions;

namespace Use_API_in_WindowsForms.Forms
{
    public partial class Form1 : XtraForm
    {
        Photos photo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_GetAllData.Click += Btn_GetAllData_Click;
        }

        private void Btn_GetAllData_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        }

        private async void GetAPIData(string request)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
             HttpResponseMessage response = await client.GetAsync(request);
            if (response.IsSuccessStatusCode)
                var data = await response.Content.ReadAsAsync<IEnumerable<Photos>>();
            //var model = await JsonConvert.DeserializeObject<List<Photos>>(responseMessage);
        }
    }
}
