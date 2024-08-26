using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tienda.Modelo;

namespace Tienda.Datos
{
    public class DProductos
    {
        public ObservableCollection<MProductos> ListarProductos()
        {
            return new ObservableCollection<MProductos>()
            {
                new MProductos()
                {
                    descripcion ="Iphone 15 Pro Max",
                    precio ="S/6,999",
                    capacidad= "128 GB",
                    icono="https://w7.pngwing.com/pngs/60/414/png-transparent-iphone-14.png"
                },

                new MProductos()
                {
                    descripcion ="SMartTV Samsung",
                    precio ="S/3,799",
                    capacidad="55''",
                    icono="https://e7.pngegg.com/pngimages/595/623/png-clipart-4k-resolution-smart-tv-samsung-led-backlit-lcd-ultra-high-definition-television-samsung-television-display-advertising.png"
                },

                new MProductos()
                {
                    descripcion ="Parlante",
                    precio ="S/99.99",
                    icono="https://w7.pngwing.com/pngs/771/852/png-transparent-computer-speakers-loudspeaker-sound-disc-jockey-treble-speaker-miscellaneous-electronics-speaker-thumbnail.png"
                },

                new MProductos()
                {
                    descripcion ="Refrigeradora Samsung",
                    precio ="S/6,789",
                    icono="https://w7.pngwing.com/pngs/191/476/png-transparent-refrigerator-home-appliance-freezers-russell-hobbs-fridge-electronics-kitchen-appliance-refrigeration-thumbnail.png"
                },

                new MProductos()
                {
                    descripcion ="Iphone 15",
                    precio ="S/5,999",
                    capacidad="128 GB",
                    icono="https://w7.pngwing.com/pngs/60/414/png-transparent-iphone-14.png"
                },

                new MProductos()
                {
                    descripcion ="Iphone 14 Pro Max",
                    precio ="S/5,789",
                    capacidad="512 GB",
                    icono="https://w7.pngwing.com/pngs/60/414/png-transparent-iphone-14.png"
                },

                new MProductos()
                {
                    descripcion ="Refrigeradora Samsung",
                    precio ="S/6,789",
                    icono="https://w7.pngwing.com/pngs/191/476/png-transparent-refrigerator-home-appliance-freezers-russell-hobbs-fridge-electronics-kitchen-appliance-refrigeration-thumbnail.png"
                },
                new MProductos()
                {
                    descripcion ="SMartTV Samsung",
                    precio ="S/3,799",
                    capacidad="55''",
                    icono="https://e7.pngegg.com/pngimages/595/623/png-clipart-4k-resolution-smart-tv-samsung-led-backlit-lcd-ultra-high-definition-television-samsung-television-display-advertising.png"
                }
            };
        }
    }
}
