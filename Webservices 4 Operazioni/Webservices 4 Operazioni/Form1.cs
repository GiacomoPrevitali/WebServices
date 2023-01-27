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
using System.Net.Http.Json;
using System.Text.Json;
using Client;

namespace Webservices_4_Operazioni
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        int choose = 0;

     

        public Form1()
        {
            InitializeComponent();
        }
        private void visione(RJButtons bl, RJButtons bm, RJButtons ba, RJButtons be)
        {
            bl.Visible = !bl.Visible;
            bm.Visible = !bm.Visible;
            ba.Visible = !ba.Visible;
            be.Visible = !be.Visible;
        }
       
        private void Btn_Leggi_Click(object sender, EventArgs e)
        {
            choose = 0;
            visione(Btn_Leggi,btn_modifica,Btn_Aggiungi,btn_elimina);
            lbl_NUP.Visible = true;
            nUD.Visible = true;
        }
        private void Btn_Aggiungi_Click(object sender, EventArgs e)
        {
            choose = 1;
            visione(Btn_Leggi, btn_modifica, Btn_Aggiungi, btn_elimina);
            lbl_Title.Visible = true;
            txt_Title.Visible = true;
        }
        private void btn_modifica_Click(object sender, EventArgs e)
        {
            choose = 2;
            visione(Btn_Leggi, btn_modifica, Btn_Aggiungi, btn_elimina);
            lbl_Title.Visible = true;
            txt_Title.Visible = true;
            lbl_NUP.Visible = true;
            nUD.Visible = true;
        }
        private void btn_elimina_Click(object sender, EventArgs e)
        {
            choose = 3;
            visione(Btn_Leggi, btn_modifica, Btn_Aggiungi, btn_elimina);
            
            lbl_NUP.Visible = true;
            nUD.Visible = true;
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            Esegui(txt_Risultato, choose, nUD, txt_Title);
            visione(Btn_Leggi, btn_modifica, Btn_Aggiungi, btn_elimina);
        }

        static async Task Esegui(TextBox t, int c, NumericUpDown n, TextBox title)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Album album = new Album();

            switch (c)
            {
                case 0:
                    album = null;
                    album = await GetAlbumAsync("/albums/"+n.Text);
                    //t.Text = album.ToString();
                    t.Text = "Id: " + album.id + Environment.NewLine + "Title: " + album.title + Environment.NewLine + "userID: " + album.userId;
                    break;
                case 1:
                    album.id = 99; album.title = title.Text; album.userId = 9;
                    var url = await CreateProductAsync(album);
                    t.Text = "il seguente album è stato aggiunto:"+ Environment.NewLine +"Titolo:" + album.title + Environment.NewLine+"id:" + Convert.ToString(album.id) + Environment.NewLine+"userID:" + Convert.ToString(album.userId);
                    break;
                case 2:
                    album.title = title.Text;
                    album.id = Convert.ToInt32(n.Text);
                    if (album.id < 10)
                    {
                        album.userId = 1;
                    }else 
                    {
                        if (album.id % 10 == 0)
                        {
                            album.userId = Convert.ToInt32((album.id / 10));
                        }
                        else
                        {
                            album.userId = Convert.ToInt32((album.id / 10) + 1);
                        } 
                    }

                    MessageBox.Show(Convert.ToString(album.id));
                    await UpdateProductAsync(album);
                    t.Text = Convert.ToString(album.title + " " + album.id + " " + album.userId);
                    t.Text = "l'album con id: "+album.id+" è stato modificato nel seguente modo:" + Environment.NewLine + "Titolo:" + album.title + Environment.NewLine + "id:" + Convert.ToString(album.id) + Environment.NewLine + "userID:" + Convert.ToString(album.userId);

                    break;
                case 3:
                    var statusCode = await DeleteProductAsync(n.Text + "");
                    if (Convert.ToString(statusCode) == "OK")
                    {
                        t.Text = "l'album con id: "+n.Text + " è stato cancellato";
                    }
                    else
                    {
                        MessageBox.Show("Qualcosa è andato storto");
                    }
                   
                    break;      
            }
        }

        static async Task<Album> GetAlbumAsync(string path)
        {
            Album product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<Album>(await response.Content.ReadAsStreamAsync());
            }
            return product;
        }
        static async Task<Uri> CreateProductAsync(Album product)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync("/albums", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        static async Task<Album> UpdateProductAsync(Album product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"/albums/{product.id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await JsonSerializer.DeserializeAsync<Album>(await response.Content.ReadAsStreamAsync());
            return product;
        }
        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"/albums/{id}");
            return response.StatusCode;
        }
    }
}


public class Album
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }

    override
    public string ToString()
    {
        return "Album: " + id + " " + title + " owned by " + userId;
    }
}
