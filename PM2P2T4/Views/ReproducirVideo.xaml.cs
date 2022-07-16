using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM2P2T4.Models;
using Xam.Forms.VideoPlayer;

namespace PM2P2T4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReproducirVideo : ContentPage
    {
        public ReproducirVideo(Video video)
        {
            InitializeComponent();
            setearDatos(video);
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void setearDatos(Video video)
        {
            lbldescripcion.Text = video.Descripcion;
            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = video.Uri
            };
            videoPlayer2.Source = uriVideoSurce;
        }
    }
}