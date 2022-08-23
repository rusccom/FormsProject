using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Collections.Specialized;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Windows.Media;

namespace FormsProject.Forms.IStore
{
    
    public partial class FormListOrders : BaseForm
    {
        static HttpClient client = new HttpClient();
        public FormListOrders()
        {
            InitializeComponent();

            SendRequestAsync();

            
        }
             
        public string GetHash(string input)
        {
            //input = "apple";
            byte[] hash = Encoding.ASCII.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach (var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }

        public async Task SendRequestAsync()
        {
            string appId = "rmarket-getorders";
            string appSecret = "a4c2d2f465fea6265f72bcad3f330d11";
            string siteId = "81e3f4c4d09dc2dfdcce5df4a11d69c4";
            string sitePassword = "4bb4b20a002764f3fbdd70a9ca93e1f2";
            string siteHost = "nahodu.by";
            string method = "Order/Get";

            string md5Hash = GetHash(method + ":" + appId + ":" + appSecret + ":" + sitePassword);
            //string md5Hash = GetHash("Order/Get:rmarket-getorders:a4c2d2f465fea6265f72bcad3f330d11:4bb4b20a002764f3fbdd70a9ca93e1f2");

            string data;

            var baseAddress = new Uri("http://www.nahodu.by/");
            string url = "/api/2.3/order/get.json";

            //string url = "/api/2.3/order/574.json";
            /// api / 2.3 / order /#{id}.json (вместо #{id} - ID элемента)

            var content = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("auth[app_id]", "rmarket-getorders"),
        new KeyValuePair<string, string>("auth[method]", "Order/Get"),
        new KeyValuePair<string, string>("auth[token]", md5Hash),
    });

            using (var client = new HttpClient { BaseAddress = baseAddress })
            {
                var result = await client.PostAsync(url, content);

                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
            }

            ISData isData = null;

            try
            {
                
                isData = JsonConvert.DeserializeObject<ISData>(data);
            }
            catch(Exception exc)
            {

            }

            PrepareDataTable(isData);
            CalcDeliverd(isData);
        }

        private void CalcDeliverd(ISData iSDatat)
        {
            decimal deliveredLocal = 0;
            decimal deliverderPost = 0;

            int i = 0;

            foreach(ISOrders isOrders in iSDatat.data)
            {
                if (isOrders.Order.id == "574")
                {

                }
                if (isOrders.Status.id == 2)
                {
                    switch(isOrders.Order.payment_id)
                    {
                        case 8:
                            if (isOrders.Order.is_payed == 1)
                            {
                                deliveredLocal = deliveredLocal + Convert.ToDecimal(isOrders.Order.price);
                                i++;
                                if(isOrders.Order.id == "574")
                                {

                                }
                            }
                            break;

                        case 9:
                            break;
                    }
                }
            }



            lDeliveredLocal.Text = deliveredLocal.ToString();
        }

        private void PrepareDataTable(ISData iSDatat)
        {
            CreateColumnsTable();
            //dgvResult.DataSource = iSDatat.data.ToArray();

            foreach (ISOrders iSOrders in iSDatat.data)
            {
                int newRowId = dgvResult.Rows.Add();

                dgvResult["columnStatus", newRowId].Value = iSOrders.Status.name;

                dgvResult["columnNumber", newRowId].Value = iSOrders.Order.number;

                dgvResult["columnSum", newRowId].Value = iSOrders.Order.price;

                dgvResult["columnCreateDate", newRowId].Value = iSOrders.Order.created;

                dgvResult["columnModifeDate", newRowId].Value = iSOrders.Order.modified;

                dgvResult["columnCustomerTel", newRowId].Value = iSOrders.Order.user_phone;

                dgvResult["columnCustomerName", newRowId].Value = iSOrders.Order.user_fullname;

                dgvResult["columnCustomerAddress", newRowId].Value = iSOrders.Order.user_address;

                switch(iSOrders.Status.id)
                {
                    case 1:
                        dgvResult.Rows[newRowId].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(169, 217, 185); ;
                        break;

                    case 2:
                        dgvResult.Rows[newRowId].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(145, 183, 227);
                        break;

                    case 3:
                        dgvResult.Rows[newRowId].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 165, 165); ;
                        break;

                    case 4:
                        dgvResult.Rows[newRowId].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(222, 227, 145); ;
                        break;
                }
            }
        }

        private void CreateColumnsTable()
        {
            
            //dgvResult.ReadOnly = true;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "isSelected";
            checkBoxColumn.HeaderText = "Выбрать";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvResult.Columns.Add(checkBoxColumn);

            DataGridViewTextBoxColumn columnStatus = new DataGridViewTextBoxColumn();
            columnStatus.Name = "columnStatus";
            columnStatus.HeaderText = "Статус документа";
            columnStatus.Width = 100;
            dgvResult.Columns.Add(columnStatus);

            DataGridViewTextBoxColumn columnNumber = new DataGridViewTextBoxColumn();
            columnNumber.Name = "columnNumber";
            columnNumber.HeaderText = "Номер документа";
            columnNumber.Width = 120;
            dgvResult.Columns.Add(columnNumber);

            DataGridViewTextBoxColumn columnSum = new DataGridViewTextBoxColumn();
            columnSum.Name = "columnSum";
            columnSum.HeaderText = "Сумма документа";
            columnSum.Width = 80;
            dgvResult.Columns.Add(columnSum);

            DataGridViewTextBoxColumn columnCreateDate = new DataGridViewTextBoxColumn();
            columnCreateDate.Name = "columnCreateDate";
            columnCreateDate.HeaderText = "Дата создания";
            columnCreateDate.Width = 130;
            dgvResult.Columns.Add(columnCreateDate);

            DataGridViewTextBoxColumn columnModifeDate = new DataGridViewTextBoxColumn();
            columnModifeDate.Name = "columnModifeDate";
            columnModifeDate.HeaderText = "Дата изменения";
            columnModifeDate.Width = 130;
            dgvResult.Columns.Add(columnModifeDate);

            DataGridViewTextBoxColumn columnCustomerTel = new DataGridViewTextBoxColumn();
            columnCustomerTel.Name = "columnCustomerTel";
            columnCustomerTel.HeaderText = "Телефон";
            columnCustomerTel.Width = 100;
            dgvResult.Columns.Add(columnCustomerTel);

            DataGridViewTextBoxColumn columnCustomerName = new DataGridViewTextBoxColumn();
            columnCustomerName.Name = "columnCustomerName";
            columnCustomerName.HeaderText = "Клиент";
            columnCustomerName.Width = 250;
            dgvResult.Columns.Add(columnCustomerName);

            DataGridViewTextBoxColumn columnCustomerAddress = new DataGridViewTextBoxColumn();
            columnCustomerAddress.Name = "columnCustomerAddress";
            columnCustomerAddress.HeaderText = "Адрес клиента";
            columnCustomerAddress.Width = 500;
            dgvResult.Columns.Add(columnCustomerAddress);

            dgvResult.AllowUserToAddRows = false;
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
